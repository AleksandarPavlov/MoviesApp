namespace ConnectionTest.Data
{
    public class Movie
    {
        private int id;

        private string name;

        private string description;

        private string category;

        private int rating;

        private DateTime releaseDate;

        public Movie() { 

        }
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

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
    }
}
