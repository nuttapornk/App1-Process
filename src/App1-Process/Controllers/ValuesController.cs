using Microsoft.AspNetCore.Mvc;

namespace App1_Process.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("v1/get")]
        public IActionResult Get()
        {
            return Ok(new List<string>() { "1","2","3"});
        }
    }
}
