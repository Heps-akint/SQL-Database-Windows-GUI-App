using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLSelfImprovementApp
{
    internal class Channel
    {
        // Adding properies of the SQL table
        public int ID { get; set; }
        public string ChannelName { get; set; }
        public string HostName { get; set; }
        public int Year { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        // Making a List<Video> video
        public List<Video> Videos { get; set; }
    }
}
