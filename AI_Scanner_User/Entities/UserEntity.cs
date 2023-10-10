namespace AI_Scanner_User.Entities
{
    public class UserEntity
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }

        public string Picture { get; private set; }

        public UserEntity(int id, string name, string email, string password, string picture)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Picture = picture;
        }
    }
}
