namespace AI_Scanner_User.DTOs
{
    public class RegisterDTO
    {
        public int Id;
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? HashedPassword { get; set; }
    }
}
