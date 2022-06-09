using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers;

[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    // GET api/values
    [HttpGet]
    public JsonResult GetAllValues()
    {
        return new JsonResult(new string[] { "Mister", "Naveed" });
    }

    // GET api/values/Helloworld
    [HttpGet("HelloWorld")]
    public JsonResult HelloWorld()
    {
        return new JsonResult("Hello world! You are hitting a aws lambda webserver api!");
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public JsonResult Get(int id)
    {
        return new JsonResult(id.ToString());
    }
}