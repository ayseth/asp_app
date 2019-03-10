namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        //everytime we add a new databse, make changes to datacontext.cs ==> migration
        
    }
}