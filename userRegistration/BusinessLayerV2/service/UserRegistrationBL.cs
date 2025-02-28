using RepositoryLayerV2.service;

namespace BusinessLayerV2.service
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _userRegistrationRl;
        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRl = userRegistrationRL;
        }

       
           public string registrationBL(string name, string password)
        {
            var credentials = _userRegistrationRl.RegistrationRL();
            var username = credentials[0];
            var pass = credentials[1];

            if (name == username && password == pass)
            {
                return "Login Successful";
            }
            else
            {
                return "Invalid username and password.";
            }
        }

    }
}