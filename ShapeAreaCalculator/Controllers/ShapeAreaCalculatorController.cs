using Microsoft.AspNetCore.Mvc;
using ShapeAreaCalculator.Backend.AreaCalculators;

namespace ShapeAreaCalculator.Controllers
{
    [Route("[controller]")]
    public class ShapeAreaCalculatorController : Controller
    {
        private readonly AreaCalculator areaCalculator;
        public ShapeAreaCalculatorController(AreaCalculator areaCalculator)
        {
            this.areaCalculator = areaCalculator;
        }
        [HttpGet]
        public IActionResult CalculateArea(List<double> shapeParams)
        {
            try
            {
                var calculationResult = areaCalculator.CalculateArea(shapeParams);
                return Ok(calculationResult);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
