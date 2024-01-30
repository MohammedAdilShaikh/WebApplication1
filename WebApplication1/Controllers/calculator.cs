using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// Create API Controller
[Route("api/[controller]")]
public class Calculator : ControllerBase
{

    // Addition Method
    [HttpGet("Add")]
    public decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    // Subtraction Method
    [HttpGet("Subtract")]
    public decimal Subtract(decimal a, decimal b)
    {
        return a - b;
    }

    // Multiplication Method
    [HttpGet("Multiply")]
    public decimal Multiply(decimal a, decimal b)
    {
        return a * b;
    }

    // Division Method
    [HttpGet("Divide")]
    public ActionResult<decimal> Divide(decimal a, decimal b)
    {
        if (b == 0)
        {
            return BadRequest("Cannot divide by zero");
        }

        return Ok(a / b);
    }
    // Modulo Method
    [HttpGet("Modulo")]
    public ActionResult<decimal> Modulo(decimal a, decimal b)
    {
        if (b == 0)
        {
            return BadRequest("Cannot perform modulo operation with zero divisor");
        }
        return a % b;
    }

}