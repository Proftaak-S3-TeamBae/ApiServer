using AI_Scanner_Service.DTOs;
using AI_Scanner_Service.Irepositories;

namespace AI_Scanner_DB.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserRepository _userRepository;

        public UserRepository(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ChangeUserDTO changeUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public LoginDTO Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public RegisterDTO RegisterUser(string name, string email, string password)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
