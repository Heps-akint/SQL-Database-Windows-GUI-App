using System.Configuration;
using System.Windows.Forms;

namespace DatabaseSQLSelfImprovementApp
{
    public partial class Form1 : Form
    {
        BindingSource channelBindingSource = new BindingSource(); // Binding Source for first gridview

        BindingSource videosBindingSource = new BindingSource(); // Binding Source for the second gridview

        // Global list of Albums which we can refer to after it's been fetched
        List<Channel> channels = new List<Channel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // on-click event listener for load channel button
        {

            ChannelsDataAccessObject channelsDataAccessObject = new ChannelsDataAccessObject();

            channels = channelsDataAccessObject.getAllChannels();

            // Creating connection betwen list and the grid view control
            channelBindingSource.DataSource = channels; // This allows the grid source to show the new channels.

            dataGridView1.DataSource = channelBindingSource; //Setting the source of the data fro the grid view to be the list

            pictureBox1.Load("https://static.wikia.nocookie.net/youtube/images/b/be/What_I%27ve_Learned.jpg/revision/latest/scale-to-width-down/350?cb=20210523185558");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Similar code to the laod date button but modifications are made to search for specific sources/videos

            ChannelsDataAccessObject channelsDataAccessObject = new ChannelsDataAccessObject();

            // Creating connection betwen list and the grid view control
            channelBindingSource.DataSource = channelsDataAccessObject.searchTitles(textBox1.Text); // This allows the grid source to show the new channels.

            dataGridView1.DataSource = channelBindingSource; //Setting the source of the data fro the grid view to be the list
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender; // If we recieve a click event, it's coming from the click view

            // Getting the row number

            int rowClicked = dataGridView.CurrentRow.Index;

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString(); // Saving the string withing the fourth cell of where we click into the imageURL variable

            // Putting the URL into the picture box
            pictureBox1.Load(imageURL);
            
            // Creating connection betwen list and the grid view control
            videosBindingSource.DataSource = channels[rowClicked].Videos; // This allows the grid source to show the new channels.

            dataGridView2.DataSource = videosBindingSource; //Setting the source of the data fro the grid view to be the list
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add a new item to database
            Channel channel = new Channel //Creating a new channel item to add to the database and Saving the input text as the channel data.
            {
                ChannelName = txt_channelName.Text,
                HostName = txt_hostName.Text,
                Year = Int32.Parse(txt_channelYear.Text), // If user inputs none interger value, then you will get an error (out of project scope)
                ImageURL = txt_imageURL.Text,
                Description = txt_description.Text,
            };

            ChannelsDataAccessObject channelsDataAccessObject = new ChannelsDataAccessObject(); // Initiatin a new database access object for the new element to be added
            int result = channelsDataAccessObject.addOneChannel(channel);
            MessageBox.Show(result + " new row(s) inserted");



        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Getting the row number

            int rowClicked = dataGridView2.CurrentRow.Index;
            // MessageBox.Show("You clicked row " + rowClicked); // Showing message to calidate functionality

            int videoID = (int) dataGridView2.Rows[rowClicked].Cells[0].Value;
            // MessageBox.Show("ID of video " + videoID); // Showing message to calidate functionality

            ChannelsDataAccessObject channelsDataAccessObject = new ChannelsDataAccessObject();

            int result = channelsDataAccessObject.deleteTrack(videoID);
            // MessageBox.Show("Result " + result); // Showing message to calidate functionality

            dataGridView2.DataSource = null; // This line arases everything in the gridview upon deletion of an item
            channels = channelsDataAccessObject.getAllChannels();

        }
    }
}
