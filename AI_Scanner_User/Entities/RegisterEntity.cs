namespace AI_Scanner_User.Entities
{
    public class RegisterEntity
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public string HashedPassword { get; private set; }

        public RegisterEntity(int id, string name, string email, string password, string hashedPassword) 
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            HashedPassword = hashedPassword;
        }
    }
}
