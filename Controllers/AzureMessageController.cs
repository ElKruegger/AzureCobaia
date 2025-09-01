using Microsoft.AspNetCore.Mvc;

namespace CobaiaAzure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AzureMessageController : Controller
    {

        // GET: api/mensagem
        [HttpGet("NetMessage")]
        public IActionResult GetMensagem()
        {
            return Ok(" .NET 8.0 as your service, i'm just an prototype, enjoy.");
        }

        // GET: api/mensagem/hello
        [HttpGet("DestroyMessage")]
        public IActionResult GetHello()
        {
            return Ok("Don't bother, im studying how destroy your world..");
        }


        [HttpGet("Sybau")]
        public IActionResult GetSybau()
        {
            return Ok("Ayo twin, shut yo bitch ass up u pmo sm >w< ");
        }
    }
}
