using AI_Scanner_User.DTOs;

namespace AI_Scanner_User.IManagers
{
    public interface IUserManager
    {
        public RegisterDTO RegisterUser();

        public LoginDTO Login(string username, string password);

        public bool IsEmailOfCorrectFormat(string email);

        public bool IsPasswordOfValidFormat(string password);

        public bool IsEmailAlreadyInUse(string email);

        public ChangeUserDTO ChangeUser(string username, string password);

        public UserDTO GetUser(string username);

        public void RemoveUser(int id);

        public UserDTO UploadUserPicture(string picture);
    }
}
