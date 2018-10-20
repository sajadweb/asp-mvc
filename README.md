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
```
    [Route("api/books")]
    [HttpPost]
    public HttpResponseMessage CreateBook(Book book) { ... }
```
For all other HTTP methods, including non-standard methods, use the AcceptVerbs attribute, which takes a list of HTTP methods.
```
// WebDAV method
[Route("api/books")]
[AcceptVerbs("MKCOL")]
public void MakeCollection() { }
```
#### Route Prefixes
Often, the routes in a controller all start with the same prefix. For example:
```
public class BooksController : ApiController
{
    [Route("api/books")]
    public IEnumerable<Book> GetBooks() { ... }

    [Route("api/books/{id:int}")]
    public Book GetBook(int id) { ... }

    [Route("api/books")]
    [HttpPost]
    public HttpResponseMessage CreateBook(Book book) { ... }
}
```
You can set a common prefix for an entire controller by using the [RoutePrefix] attribute:

```
[RoutePrefix("api/books")]
public class BooksController : ApiController
{
    // GET api/books
    [Route("")]
    public IEnumerable<Book> Get() { ... }

    // GET api/books/5
    [Route("{id:int}")]
    public Book Get(int id) { ... }

    // POST api/books
    [Route("")]
    public HttpResponseMessage Post(Book book) { ... }
}

```
Use a tilde (~) on the method attribute to override the route prefix:
```
[RoutePrefix("api/books")]
public class BooksController : ApiController
{
    // GET /api/authors/1/books
    [Route("~/api/authors/{authorId:int}/books")]
    public IEnumerable<Book> GetByAuthor(int authorId) { ... }

    // ...
}
```
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
 [Load More](https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2)
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
