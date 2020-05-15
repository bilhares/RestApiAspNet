using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("{firstNumber}/{secondNumber}")]
        public IActionResult sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }

        private decimal ConvertToDecimal(string number)
        {
            decimal d;
            if (decimal.TryParse(number, out d))
            {
                return d;
            }
            return 0;
        }

        private bool IsNumeric(string number)
        {
            double a;
            Boolean isNumber = double.TryParse(number, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out a);

            return isNumber;
        }
    }
}