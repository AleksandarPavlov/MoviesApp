namespace ConnectionTest.Data
{
    public class User
    {
        private int id;

        private string email;

        private string password;

        private string name;

        private string surname;

        public User() { 

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Email   
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
    }
}
