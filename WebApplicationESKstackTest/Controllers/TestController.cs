using Microsoft.AspNetCore.Mvc;

namespace WebApplicationESKstackTest.Controllers;

[ApiController]
[Route("test/")]
public class TestController : ControllerBase
{
    private ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet("info")]
    public String GetInfo()
    {
        _logger.LogInformation("GetInfo called");
        return "ok";
    }
    
    [HttpGet("debug")]
    public String GetDebug()
    {
        _logger.LogDebug("GetDebug called");
        return "ok";
    }
    
    [HttpGet("warn")]
    public String GetWarn()
    {
        _logger.LogWarning("GetWarn called");
        return "ok";
    }
    
    [HttpGet("error")]
    public String GetError()
    {
        _logger.LogError("GetError called");
        return "ok";
    }
}