using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class HelloWorldController : Controller
    {
        public int Id { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("welcome");
        }

        // 
        // GET: Does not use the name of the action whene that route without [actions]
        // GET: /api/HelloWorld/1
        [HttpGet("{id}")]
        public IActionResult Welcome(int id)
        {
            return Ok("Welcome " + id);
        }
    }
}