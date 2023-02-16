using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Athorization.Controllers
{

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
