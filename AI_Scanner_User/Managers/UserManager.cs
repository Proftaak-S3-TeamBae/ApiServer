using AI_Scanner_User.DTOs;
using AI_Scanner_User.IManagers;

namespace AI_Scanner_User.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IUserManager _Usermanager;

        public UserManager(IUserManager usermanager)
        {
            _Usermanager = usermanager;
        }

        public ChangeUserDTO ChangeUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public bool IsEmailAlreadyInUse(string email)
        {
            throw new NotImplementedException();
        }

        public bool IsEmailOfCorrectFormat(string email)
        {
            throw new NotImplementedException();
        }

        public bool IsPasswordOfValidFormat(string password)
        {
            throw new NotImplementedException();
        }

        public LoginDTO Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public RegisterDTO RegisterUser()
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserDTO UploadUserPicture(string picture)
        {
            throw new NotImplementedException();
        }
    }
}
