using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[Controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public string Test(){
            return "hello world";
        }

        //[HttpGet("Add")]
        public decimal Add(decimal number1, decimal number2)
        {
            decimal sum = number1 + number2;
            return sum;
        }

        public string TestAgain(){
            return "hello world";
        }
    }
}
