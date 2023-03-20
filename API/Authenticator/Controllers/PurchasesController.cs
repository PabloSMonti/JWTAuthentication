using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.JavaScript;

namespace Authenticator.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPurchases()
        {
            return Ok(Enumerable.Range(0, 20).Select(x => new
            {
                id = Guid.NewGuid(),
                productDescription = "Product " + x.ToString(),
                dateOperation = DateTime.Today,
                state = "delivered"
            }).ToList());
        }
    }
}
