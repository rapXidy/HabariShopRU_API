using Microsoft.AspNetCore.Mvc;

namespace HabariShopRU.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public CustomerController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "CreateCustomer")]
        public IActionResult CreateCustomer()
        {
            return Ok();
        }
    }
}