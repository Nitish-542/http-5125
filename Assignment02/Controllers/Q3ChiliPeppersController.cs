using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3ChiliPeppersController : ControllerBase
    {
        /// <summary>
        /// Calculates the total Scoville Heat Units (SHU) based on the peppers added.
        /// </summary>
        /// <param name="Ingredients">A comma-separated string of pepper names.</param>
        /// <returns>The total SHU value of the peppers or an error message for invalid input.</returns>
        /// <example>
        /// GET: "https://localhost:7289/api/Q3ChiliPeppers/ChiliPeppers?Ingredients=Poblano,Cayenne,Thai,Poblano"
        /// -> 118500
        /// curl "https://localhost:7289/api/Q3ChiliPeppers/ChiliPeppers?Ingredients=Poblano,Cayenne,Thai,Poblano"
        /// -> "Invalid input"
        /// </example>
        [HttpGet(template: "ChiliPeppers")]
        public string ChiliPeppers([FromQuery] string Ingredients)
        {
            int totalShu = 0;

            // Split the ingredients based on commas
            string[] pepperArray = Ingredients.Split(',');

            foreach (var pepper in pepperArray)
            {
                // Add SHU based on the pepper name
                if (pepper == "Poblano")
                {
                    totalShu += 1500;
                }
                else if (pepper == "Mirasol")
                {
                    totalShu += 6000;
                }
                else if (pepper == "Serrano")
                {
                    totalShu += 15500;
                }
                else if (pepper == "Cayenne")
                {
                    totalShu += 40000;
                }
                else if (pepper == "Thai")
                {
                    totalShu += 75000;
                }
                else if (pepper == "Habanero")
                {
                    totalShu += 125000;
                }
                else
                {
                    return "Invalid input"; // If any pepper is invalid, return an error message
                }
            }

            return totalShu.ToString(); // Return the total SHU as a string
        }
    }
}
