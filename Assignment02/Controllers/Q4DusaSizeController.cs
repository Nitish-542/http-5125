using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4DusaSizeController : ControllerBase
    {
        /// <summary>
        /// Calculates Dusa's final size after encountering Yobis.
        /// </summary>
        /// <param name="initialSize">Dusa's starting size.</param>
        /// <param name="yobiSizes">A comma-separated list of Yobi sizes.</param>
        /// <returns>The final size of Dusa after she encounters Yobis.</returns>
        /// <example>
        /// POST: curl -X POST "https://localhost:7289/api/Q4DusaSize/CalculateFinalSize" -H "Content-Type: application/x-www-form-urlencoded" -d "initialSize=5&yobiSizes=3,2,9,20"
        /// -> 19
        /// curl -X POST "https://localhost:7289/api/Q4DusaSize/CalculateFinalSize" -H "Content-Type: application/x-www-form-urlencoded" -d "initialSize=10&yobiSizes=10,3,5,13"
        /// -> 10
        /// </example>
        [HttpPost(template: "CalculateFinalSize")]
        [Consumes("application/x-www-form-urlencoded")]
        public IActionResult CalculateFinalSize([FromForm] int initialSize, [FromForm] string yobiSizes)
        {
            int dusaSize = initialSize;

            // Split the comma-separated Yobi sizes
            string[] yobiArray = yobiSizes.Split(',');

            // Iterate through the Yobi sizes
            foreach (var yobi in yobiArray)
            {
                if (int.TryParse(yobi, out int yobiSize))
                {
                    // Dusa eats the Yobi if it's smaller, or runs away if it's the same size or larger
                    if (yobiSize < dusaSize)
                    {
                        dusaSize += yobiSize;
                    }
                    else
                    {
                        break; // Dusa runs away when encountering a Yobi the same size or larger
                    }
                }
                else
                {
                    return BadRequest("Invalid input"); // Return error if Yobi size isn't a valid integer
                }
            }

            // Return Dusa's final size
            return Ok(dusaSize);
        }
    }
}
