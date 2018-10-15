# asp-mvc
Learning asp.net
## Controler
#### Route
/api/HelloWorld/ActionName/23
```
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class HelloWorldController : Controller{
        [HttpGet("{id}")]
        public IActionResult Welcome(int id)
        {
            return Ok("Welcome " + id);
        }
    ...
    }
 ```
/api/HelloWorld/23
```
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class HelloWorldController : Controller{
        [HttpGet("{id}")]
        public IActionResult Welcome(int id)
        {
            return Ok("Welcome " + id);
        }
        ...
    }
 ```
 /api/23
```
    [Produces("application/json")]
    [Route("api")]
    public class HelloWorldController : Controller{
        [HttpGet("{id}")]
        public IActionResult Welcome(int id)
        {
            return Ok("Welcome " + id);
        }
        ...
    }
 ```
