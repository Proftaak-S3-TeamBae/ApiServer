namespace AI_Scanner_User.Entities
{
    public class LoginEntity
    {
        public int Id { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public LoginEntity(int id, string email, string password) 
        { 
            Id = id;
            Email = email;
            Password = password;
        }
    }
}
