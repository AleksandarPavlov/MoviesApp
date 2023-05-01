namespace ConnectionTest.Data
{
    public class Trailer
    {
        private int id;

        private string name;

        private string link;

        private DateTime releaseDate;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Link
        {
            get { return link; }
            set { link = value; }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public Trailer() { 
        
        }
    }
}
