namespace Assignment_3_skeleton
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

		//Initializes a User object.
		public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            UserName = username;
            Password = password;
        }
    }
}
