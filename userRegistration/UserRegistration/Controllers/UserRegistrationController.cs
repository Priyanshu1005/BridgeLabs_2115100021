using BusinessLayerV2.service;
using Microsoft.AspNetCore.Mvc;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        UserRegistrationBL _userRegistrationBL;
        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }
        [HttpGet]
        public string registration()
        {
            string username = "root";
            string password = "root";
            return _userRegistrationBL.registrationBL(username, password);
        }
    }
}
