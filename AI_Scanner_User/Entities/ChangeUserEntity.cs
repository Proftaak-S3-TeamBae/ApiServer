namespace AI_Scanner_User.Entities
{
    public class ChangeUserEntity
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public string HashedPassword { get; private set; }

        public int RoleId { get; private set; }

        public ChangeUserEntity(int id, string name, string email, string password, string hashedpassword, int roleId) 
        { 
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            HashedPassword = hashedpassword;
            RoleId = roleId;
        }
    }
}
