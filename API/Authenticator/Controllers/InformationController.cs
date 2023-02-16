using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Athorization.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> GetInformation()
        {
            return Ok("Si obtuviste esta información es porque estas autorizado...");
        }

    }
}
