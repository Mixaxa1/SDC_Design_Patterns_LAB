using Microsoft.AspNetCore.Mvc;
using Task3v2ApiSide.ApiSide.PermitionsStorageSystem;


namespace Task3v2ApiSide.ApiSide.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermitionsController : ControllerBase
    {
        private IPermitionStorage _permitionService {  get; set; }

        public PermitionsController(IPermitionStorage permitionService)
        {
            _permitionService = permitionService;
        }

        [HttpGet("{nickname}")]
        public IActionResult CheckPermition([FromRoute] string nickname, [FromQuery] string book)
        {
            return Ok(_permitionService.CheckPermition(nickname, book));
        }
    }
}
