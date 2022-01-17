using Microsoft.AspNetCore.Mvc;
using ClassLibrary;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class AdditionController : Controller
    {
        private readonly IAddition _addition;
        //Injecting dependencies in constructor
        public AdditionController(IAddition addition)
        {
            _addition = addition;
        }

        [HttpGet]
        public IActionResult GetJsonStaticValuesFromClassLibrary()
        {
            //var req = Request.Headers;
            //Response.Headers.Add("Access-Control-Allow-Origin", "*");
            //Response.Headers.Add("Access-Control-Allow-Headers", "Origin, Content-Type, X-Auth-Token, name");
            //Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PATCH, PUT, DELETE, OPTIONS");

            return Ok(_addition.JsonReposStaticValues());
        }

        [HttpGet("sum")]
        public IActionResult Index()
        { 
            return Ok(_addition.DoSum(5,8).ToString());
        }


    }
}
