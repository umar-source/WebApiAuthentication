using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WebApiAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TestController : ControllerBase
    {


 //If i want to get/show this url only authenticated user use authorize attribute. We can use at class level or method level.
        [HttpGet]
        public IActionResult Get()
        { 
         
                return Ok("You hit me");
   
        }
           
    }
}
