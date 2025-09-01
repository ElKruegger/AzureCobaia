using Microsoft.AspNetCore.Mvc;

namespace CobaiaAzure.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
    public class AzureMessageController : Controller
    {
       
            // GET: api/mensagem
            [HttpGet]
            public IActionResult GetMensagem()
            {
                return Ok(" .NET 8.0 as your service, i'm just an prototype, enjoy.");
            }

            // GET: api/mensagem/hello
            [HttpGet("hello")]
            public IActionResult GetHello()
            {
                return Ok(new { Mensagem = "Don't bother, im studying how destroy your world." });
            }
    }
}
