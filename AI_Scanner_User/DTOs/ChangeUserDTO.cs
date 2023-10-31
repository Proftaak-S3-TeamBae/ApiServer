namespace AI_Scanner_User.DTOs
{
    public class ChangeUserDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? HashedPassword { get; set; }
        public int RoleId { get; set; }
    }
}
