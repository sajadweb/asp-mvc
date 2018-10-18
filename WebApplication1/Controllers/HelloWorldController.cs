using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("/[action]")]
    public class HelloWorldController : Controller
    {
        public int Id { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            var book = new Books() {
                SeriesTitle = "THe Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Description demo issue</p>",
                Artists = new Artist[]
                {
                    new Artist(){Name="a",Role="a1"},
                    new Artist(){Name="b",Role="b1"},
                    new Artist(){Name="c",Role="c1"},
                }
            };
            return Ok(book);
        }

        // 
        // GET: Does not use the name of the action whene that route without [actions]
        // GET: /api/HelloWorld/1
        [HttpGet("{name}")]
        public IActionResult Welcome(string name)
        {
            return Redirect("/Goodby/"+ name);
        }

        [HttpGet("{name}")]
        public IActionResult Goodby(string name)
        {
            return Content("goodby " + name);
        }
    }
}