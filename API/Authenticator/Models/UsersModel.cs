namespace Athorization.Models
{
    public static class Users
    {
        public static List<User> UsersData = new List<User>() {new User(0,"Juan",19,"1234"), new User(1, "Pedro", 19,"aaa2"), new User(2, "Jose", 19, "garcia1") }; 
    }


    public class User
    {
        public User(int id, string? name, int age, string? password)
        {
            Id = id;
            Name = name;
            Age = age;
            Password = password;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Password { get; set; }
    }
}
