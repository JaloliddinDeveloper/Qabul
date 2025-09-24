using Microsoft.AspNetCore.Mvc;

namespace Qabul.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public ActionResult<string> Get()=>
             "Hello Qabul";
    }
}
