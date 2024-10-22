using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1DeliveryScoreControllercs : ControllerBase
    
    {
        /// <summary>
        /// Calculates the final score based on successful deliveries and obstacles hit.
        /// </summary>
        /// <param name="successfulDeliveries">Number of successful deliveries.</param>
        /// <param name="obstaclesHit">Number of obstacles hit.</param>
        /// <returns>The computed final score.</returns>
        /// <example>
        /// Example 1: 
        /// POST: curl -H "Content-Type: application/x-www-form-urlencoded" -d "successfulDeliveries=5&obstaclesHit=2" "https://localhost:7289/api/Q1DeliveryScoreControllercs/CalculateDeliveryScore"
        /// 
        /// Example 2: 
        /// POST: curl -H "Content-Type: application/x-www-form-urlencoded" -d "successfulDeliveries=0&obstaclesHit=3" "https://localhost:7289/api/Q1DeliveryScoreControllercs/CalculateDeliveryScore"
        /// </example>
        [HttpPost("CalculateDeliveryScore")]
        [Consumes("application/x-www-form-urlencoded")]
        public int CalculateFinalScore([FromForm] int successfulDeliveries, [FromForm] int obstaclesHit)
        {
            // Calculate the base score
            int score = (successfulDeliveries * 50) - (obstaclesHit * 10);

            // Add bonus if successful deliveries exceed obstacles hit
            if (successfulDeliveries > obstaclesHit)
            {
                score += 500;
            }

            return score;
        }
    }
}
