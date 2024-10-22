using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2WinningScoreController : ControllerBase
    {
        /// <summary>
        /// Determines which team won based on the scoring inputs.
        /// </summary>
        /// <param name="apples3Points">Number of 3-point shots by the Apples.</param>
        /// <param name="apples2Points">Number of 2-point field goals by the Apples.</param>
        /// <param name="apples1Points">Number of 1-point free throws by the Apples.</param>
        /// <param name="bananas3Points">Number of 3-point shots by the Bananas.</param>
        /// <param name="bananas2Points">Number of 2-point field goals by the Bananas.</param>
        /// <param name="bananas1Points">Number of 1-point free throws by the Bananas.</param>
        /// <returns>The result of the game: 'A' for Apples win, 'B' for Bananas win, or 'T' for a tie.</returns>
        /// <example>
        /// POST: curl -H "Content-Type: application/x-www-form-urlencoded" -d "apples3Points=10&apples2Points=3&apples1Points=7&bananas3Points=8&bananas2Points=9&bananas1Points=6" "https://localhost:7289/api/Q2WinningScoreController/CalculateWinningScore"
        /// </example>
        [HttpPost("CalculateWinningScore")]
        [Consumes("application/x-www-form-urlencoded")]
        public string CalculateWinningScore([FromForm] int apples3Points, [FromForm] int apples2Points, [FromForm] int apples1Points, [FromForm] int bananas3Points, [FromForm] int bananas2Points, [FromForm] int bananas1Points)
        {
            // Calculate total points for Apples
            int applesScore = (apples3Points * 3) + (apples2Points * 2) + apples1Points;

            // Calculate total points for Bananas
            int bananasScore = (bananas3Points * 3) + (bananas2Points * 2) + bananas1Points;

            // Determine the result
            if (applesScore > bananasScore)
            {
                return "A"; // Apples win
            }
            else if (bananasScore > applesScore)
            {
                return "B"; // Bananas win
            }
            else
            {
                return "T"; // Tie
            }
        }
    }
}
