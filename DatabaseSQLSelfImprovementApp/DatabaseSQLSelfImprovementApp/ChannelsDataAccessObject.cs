using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DatabaseSQLSelfImprovementApp
{
    internal class ChannelsDataAccessObject
    {
        // The job of the data access object is to do all the SQL queries and provide a link between the front-end and the back-end

        // version 1 using fake data. No connection to database yet
        //public List<Channel> channels = new List<Channel>(); //Initialising list of zero values

        //Putting in the data source property (where does the data live). We use local host since our database is hosted locally using the MAMP server
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=selfimprovement";

        // Creating function/action to get all the data(channels) from my database
        public List<Channel> getAllChannels()
        {
            List<Channel> returnThese = new List<Channel>(); // starting with empty list named returnThese

            MySqlConnection connection = new MySqlConnection(connectionString); // connect to the mysql server. This doesnt work by default due to microsoft only expects communication with SQL but we use MySQL. We use a dependency to fix this.

            connection.Open(); // Creating an open connection which will log into the server

            // Define SQL statement to fetch all channels
            MySqlCommand command = new MySqlCommand("SELECT ID, CHANNEL_NAME, HOST_NAME, YEAR, IMAGE_URL, DESCRIPTION FROM SOURCES", connection); // This will Creating an SQL command

            using (MySqlDataReader reader = command.ExecuteReader()) //This Reader reads the sql quiry command in the commmand variable and when it's done, it destroys itself
            {
                while (reader.Read()) 
                {
                    Channel c = new Channel
                    {
                        ID = reader.GetInt32(0),
                        ChannelName = reader.GetString(1),
                        HostName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };

                    c.Videos = getVideosForChannel(c.ID); // Gets all the videos and adds them to list of things we're returning. Aloows us to save all videos whilst vetching the channel

                    returnThese.Add(c); 
                }
            }
            connection.Close();

            return returnThese;

        }

        // Craeting method to search for channels by title
        public List<Channel> searchTitles(String searchTerm) // Creating search function which takes a string as searchTerm
        {
            List<Channel> returnThese = new List<Channel>(); // starting with empty list named returnThese

            MySqlConnection connection = new MySqlConnection(connectionString); // connect to the mysql server. This doesnt work by default due to microsoft only expects communication with SQL but we use MySQL. We use a dependency to fix this.

            connection.Open(); // Creating an open connection which will log into the server

            String searchWildPhrase = "%" + searchTerm + "%"; // Creating a variable for the search term

            // Define SQL statement to fetch all channels
            MySqlCommand command = new MySqlCommand(); // This will Creating an SQL command
            command.CommandText = "SELECT ID, CHANNEL_NAME, HOST_NAME, YEAR, IMAGE_URL, DESCRIPTION FROM SOURCES WHERE CHANNEL_NAME LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            // The code above exexutes an sql quiry as a command

            using (MySqlDataReader reader = command.ExecuteReader()) //This Reader reads the sql quiry command in the commmand variable and when it's done, it destroys itself
            {
                while (reader.Read())
                {
                    Channel c = new Channel
                    {
                        ID = reader.GetInt32(0),
                        ChannelName = reader.GetString(1),
                        HostName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    returnThese.Add(c);
                }
            }
            connection.Close();

            return returnThese;

        }

        // Creating a method to add a channel to the database
        internal int addOneChannel(Channel channel)
        {

            MySqlConnection connection = new MySqlConnection(connectionString); // connect to the mysql server. This doesnt work by default due to microsoft only expects communication with SQL but we use MySQL. We use a dependency to fix this.

            connection.Open(); // Creating an open connection which will log into the server

            // Define SQL statement to fetch all channels
            MySqlCommand command = new MySqlCommand("INSERT INTO `sources`(`CHANNEL_NAME`, `HOST_NAME`, `YEAR`, `IMAGE_URL`, `DESCRIPTION`) VALUES (@channelname, @host, @year, @imageURL, @description)", connection); // This will Creating an SQL command

            command.Parameters.AddWithValue("@channelname", channel.ChannelName); // Associating the value parameters wiht their actual values input in the input window.

            command.Parameters.AddWithValue("@host", channel.HostName);

            command.Parameters.AddWithValue("@year", channel.Year);

            command.Parameters.AddWithValue("@imageURL", channel.ImageURL);

            command.Parameters.AddWithValue("@description", channel.Description);

            int newRows = command.ExecuteNonQuery(); // Saving the output of the executenonquery operation (returns number of rows effected which will be one in our case) to the neRows variable

            connection.Close();

            return newRows;
        }

        internal int deleteTrack(int videoID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString); // connect to the mysql server. This doesnt work by default due to microsoft only expects communication with SQL but we use MySQL. We use a dependency to fix this.

            connection.Open(); // Creating an open connection which will log into the server

            // Define SQL statement to fetch all channels
            MySqlCommand command = new MySqlCommand("DELETE FROM `videos` WHERE `videos`.`ID` = @videoID;", connection); // This will Creating an SQL command

            command.Parameters.AddWithValue("@videoID", videoID); // Associating the value parameters with their actual values input in the input window.

            int result = command.ExecuteNonQuery(); // Saving the output of the executenonquery operation (returns number of rows effected which will be one in our case) to the neRows variable

            connection.Close();

            return result;
        }

        // Creating a mehtod for selecting the videos for a channel
        public List<Video> getVideosForChannel(int channelID) // Creating search function which takes a string as searchTerm
        {
            List<Video> returnThese = new List<Video>(); // starting with empty list named returnThese

            MySqlConnection connection = new MySqlConnection(connectionString); // connect to the mysql server. This doesnt work by default due to microsoft only expects communication with SQL but we use MySQL. We use a dependency to fix this.

            connection.Open(); // Creating an open connection which will log into the server


            // Define SQL statement to fetch all channels
            MySqlCommand command = new MySqlCommand(); // This will Creating an SQL command
            command.CommandText = "SELECT * FROM VIDEOS WHERE sources_ID = @channelid";
            command.Parameters.AddWithValue("@channelid", channelID);
            command.Connection = connection;

            // The code above exexutes an sql quiry as a command

            using (MySqlDataReader reader = command.ExecuteReader()) //This Reader reads the sql quiry command in the commmand variable and when it's done, it destroys itself
            {
                while (reader.Read())
                {
                    Video t = new Video
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Transcript  = reader.GetString(4),
                    };
                    returnThese.Add(t);
                }
            }
            connection.Close();

            return returnThese;

        }

        // Creating a method for selecting the videos using a JOIN statement
        public List<JObject> getVideosUsingJoin(int channelID) // Creating search function which takes a string as searchTerm
        {
            List<JObject> returnThese = new List<JObject>(); // starting with empty list named returnThese

            MySqlConnection connection = new MySqlConnection(connectionString); // connect to the mysql server. This doesnt work by default due to microsoft only expects communication with SQL but we use MySQL. We use a dependency to fix this.

            connection.Open(); // Creating an open connection which will log into the server


            // Define SQL statement to fetch all channels
            MySqlCommand command = new MySqlCommand(); // This will Creating an SQL command
            command.CommandText = "SELECT videos.ID as videoID, sources.CHANNEL_NAME, `video_title`, `video_url`, `transcript` FROM `videos` JOIN sources ON sources_ID = sources.ID WHERE sources_ID = @channelid";
            command.Parameters.AddWithValue("@channelid", channelID);
            command.Connection = connection;

            // The code above exexutes an sql quiry as a command

            using (MySqlDataReader reader = command.ExecuteReader()) //This Reader reads the sql quiry command in the commmand variable and when it's done, it destroys itself
            {

                while (reader.Read())
                {
                    JObject newVideo = new JObject();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        newVideo.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }

                    returnThese.Add(newVideo);
                }
            }
            connection.Close();

            return returnThese;

        }

    }


}
