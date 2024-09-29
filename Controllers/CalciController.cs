using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalciController : ControllerBase
    {
        [HttpGet("addition")]
        public ActionResult<decimal> Add(decimal num1, decimal num2)
        {
            return Ok(num1 + num2);
        }

        [HttpGet("subtraction")]
        public ActionResult<decimal> Subtract(decimal num1, decimal num2)
        {
            return Ok(num1 - num2);
        }

        [HttpGet("multiplication")]
        public ActionResult<decimal> Multiply(decimal num1, decimal num2)
        {
            return Ok(num1 * num2);
        }

        [HttpGet("division")]
        public ActionResult<decimal> Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
                return BadRequest("Cannot divide by zero.");
            return Ok(num1 / num2);
        }

        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo(decimal num1, decimal num2)
        {
            return Ok(num1 % num2);
        }
    }
}
