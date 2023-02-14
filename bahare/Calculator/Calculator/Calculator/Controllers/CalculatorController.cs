using Calculator.DTO;
using Calculator.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;
        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ILogger<CalculatorController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }
        /// <summary>
        /// sum of two number
        /// </summary>
        /// <param name="firstNumber"> FirstNumber</param>
        /// <param name="secondNumber">SecondNumber</param>
        /// <response code="200">Result of Sum</response>

        /// <returns></returns>
        [HttpGet]
        public IActionResult getSum(int? firstNumber, int? secondNumber)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var sum = _calculatorService.getSum(firstNumber, secondNumber);
                    return Ok(sum);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "internal server error occured in getSum function.");
                }
            }
            return problem("/ calculator / getSum");

        }
        /// <summary>
        /// Minus of two number
        /// </summary>
        /// <param name="firstNumber"> FirstNumber</param>
        /// <param name="secondNumber">SecondNumber</param>
        /// <response code="200">Result of Minus</response>

        /// <returns></returns>

        [HttpGet]
        public IActionResult getMinus(int? firstNumber, int? secondNumber)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var minusResult = _calculatorService.getMinus(firstNumber, secondNumber);
                    return Ok(minusResult);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "internal server error occured in getSum function.");
                }
            }
            return problem("/ calculator / getMinus");
            
        }
        /// <summary>
        /// Multipl of two number
        /// </summary>
        /// <param name="firstNumber"> FirstNumber</param>
        /// <param name="secondNumber">SecondNumber</param>
        /// <response code="200">Result of Multipl</response>

        /// <returns></returns>
        [HttpGet]
        public IActionResult getMultiple(int? firstNumber, int? secondNumber)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var multipleResult = _calculatorService.getMultiple(firstNumber, secondNumber);
                    return Ok(multipleResult);
                }
                catch (Exception ex)
                {
                     _logger.LogError(ex, "internal server error occured in getSum function.");
                }
            }
            return problem("/ calculator / getMultiple");
             
        }
        /// <summary>
        /// Divide of two number
        /// </summary>
        /// <param name="firstNumber"> FirstNumber</param>
        /// <param name="secondNumber">SecondNumber</param>
        /// <response code="200">Result of Divide</response>

        [HttpGet]
        public IActionResult getDivide(int? firstNumber, int? secondNumber)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var divisionResult = _calculatorService.getDivide(firstNumber, secondNumber);
                    return Ok(divisionResult);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "internal server error occured in getSum function.");
                }
            }
            return problem("/calculator/getDivide");
            
        }
        private IActionResult problem(string _instance)
        {
            return Problem(
                type: ErrorTypes.invalid_request,
                statusCode: (int)HttpStatusCode.BadRequest,
                title: "Invalid Request.",
                detail: "",
                instance: _instance);
        }


    }
}