using LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("INFO here is info message from our values controller");
        _logger.LogDebug("DEBUG here is debug message from our values controller");
        _logger.LogWarn("WARN here is warn message from our values controller");
        _logger.LogError("ERROR here is error message from our values controller");

        return new string[] { "value1", "value2" };
    }
}
