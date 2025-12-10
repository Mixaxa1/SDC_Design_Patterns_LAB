using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task3v2ApiSide.ApiSide.UserAuthorizationSystem;


namespace Task3v2ApiSide.ApiSide.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserAuthorizationService _userService {  get; set; }

        public UserController(IUserAuthorizationService userService)
        {
            _userService = userService;
        }

        [HttpGet("{login}")]
        public IActionResult Authorize([FromRoute] string login, [FromQuery] string password)
        {
            return Ok(_userService.Authorize(login, password));
        }

        [HttpGet("checkReg/{nickname}")]
        public IActionResult CheckRegistration([FromRoute]  string nickname)
        {
            return Ok(_userService.CheckRegistration(nickname));
        }
    }
}
