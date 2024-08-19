using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace SandboxAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IOptions<CustSettings> _customOptions;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<CustSettings> customOptions)
        {
            _logger = logger;
            _customOptions = customOptions;
        }

        [HttpGet()]
        public string Get()
        {
            return $"=> value: {_customOptions.Value.AppName}, version: {_customOptions.Value.Version}";
           
        }
    }
}
