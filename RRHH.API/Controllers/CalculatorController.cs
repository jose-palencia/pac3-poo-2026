using Microsoft.AspNetCore.Mvc;

namespace RRHH.API.Controllers
{
    [ApiController]
    [Route("api/calculator")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Operations([FromBody] CalculatorModel calculator)
        {
            int result = calculator.Operator switch
            {
                "+" => calculator.N1 + calculator.N2,
                "-" => calculator.N1 - calculator.N2,
                "x" => calculator.N1 * calculator.N2,
                "÷" => calculator.N1 / calculator.N2,
                _ => 0
            };

            return Ok(new
            {
                calculator.N1,
                calculator.N2,
                calculator.Operator,
                Total = result
            });
        }
    }

    public class CalculatorModel
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public string? Operator { get; set; }
    }
}