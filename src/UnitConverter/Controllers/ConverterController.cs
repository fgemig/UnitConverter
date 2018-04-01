using Conversor.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace UnitConverter.Controllers
{
    [Route("api/[controller]")]
    public class ConverterController : Controller
    {
        private IConverterService _service;

        public ConverterController(IConverterService service)
            => _service = service;

        [HttpGet("meters/{input}")]       
        public IActionResult Meter(double input)
            => Json(_service.FromMeters(input));

        [HttpGet("feet/{input}")]
        public IActionResult Feet(double input)
            => Json(_service.FromFeet(input));

        [HttpGet("inches/{input}")]
        public IActionResult Inch(double input)
            => Json(_service.FromInches(input));

        [HttpGet("kilometers/{input}")]
        public IActionResult Kilometers(double input)
            => Json(_service.FromKilometers(input));
    }
}