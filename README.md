# asp-mvc
Learning asp.net
## Route
#### HTTP Methods
1. HttpGet
2. HttpPost
3. HttpPut
4. HttpHead
5. HttpDelete
6. HttpPatch
7. HttpOptions

The following example maps the CreateBook method to HTTP POST requests.

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
 
## Controler

###  ContentResult
```
        ....
        public ContentResult Welcome(int id)
        {
            // String 
            return new ContentResult()
            {
                Content = "Welcome"
            };
        }
        ....
```
### IActionResult
#### Content
```
        public IActionResult Welcome(int id)
        {
            return Content("welcome");
        }
```
### Redirect
```
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
```
