using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APITemperatura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversorTemperaturasController : ControllerBase
    {
        [HttpGet("Fahrenheit/{temperatura}")]
        public Temperatura Get(
            [FromServices]ILogger<ConversorTemperaturasController> logger,
            double temperatura)
        {
            logger.LogInformation(
                $"Recebida temperatura para conversão: {temperatura}");

            return new Temperatura()
            {
                Fahrenheit = temperatura,
                Celsius = ConversorTemperatura.FahrenheitParaCelsius(temperatura)
            };
        }
    }
}