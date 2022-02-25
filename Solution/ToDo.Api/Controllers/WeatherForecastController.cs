using Microsoft.AspNetCore.Mvc;

namespace ToDo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private static List<string> MinhaLista = new List<string>();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetList")]
        public IList<string> Get()
        {
            return MinhaLista;
        }

        [HttpPost(Name ="PostList")]
        public void Post (string input)
        {
            MinhaLista.Add(input);
        }
    }
}