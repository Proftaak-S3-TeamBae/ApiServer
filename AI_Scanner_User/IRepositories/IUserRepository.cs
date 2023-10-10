using AI_Scanner_User.DTOs;

namespace AI_Scanner_User.IRepositories
{
    public interface IUserRepository
    {
        public UserDTO GetUser(int id);

        public LoginDTO Login(string email, string password);
        
        public ChangeUserDTO changeUser(string email, string password);

        public RegisterDTO RegisterUser(string name, string email, string password);

        public void RemoveUser(UserDTO user);
    }
}
