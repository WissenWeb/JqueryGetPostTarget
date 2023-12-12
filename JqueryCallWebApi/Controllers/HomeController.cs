using Microsoft.AspNetCore.Mvc;

namespace JqueryCallWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("JqueryGet")]
        public IActionResult Index()
        {
            return Ok(true);
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult Post([FromBody]Product product)
        {
            return Ok(product == null ? false : true);
        }
    }
}
