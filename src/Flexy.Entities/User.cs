namespace Flexy.Entities
{

    using System.Text.Json.Serialization;

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public IEnumerable<Goal> Goals { get; set; }
        public Diary? Diary { get; set; }
        public string Avatar { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}
