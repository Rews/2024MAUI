using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;


[Route("api/")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [Route("testMethod")]
    [HttpGet]
    public IActionResult FirstGetMethod([FromQuery(Name = "aaa")]string name)
    {
        return Ok(new { Data = name });
    }
    
    [Route("news")]
    [HttpGet]
    public IActionResult GetNews()
    {
        var list = new List<NewsDTO>();
        
        return Ok(FakeData.NEWS);
    }
    
    [Route("login")]
    [HttpPost]
    public IActionResult Login([FromBody] LoginDTO login)
    {
        if (login.Username == "123" && login.Password == "123")
            return Ok(FakeData.USER);
        else
        {
            return StatusCode(400, new { message = "Username or password is incorrect" });
        }
    }
    
}