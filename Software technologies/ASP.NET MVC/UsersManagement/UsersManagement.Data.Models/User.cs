namespace UsersManagement.Data.Models
{
    public class User
    {
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public User(int id, string username, string password)
            : this(username, password)
        {
            this.Id = id;
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
