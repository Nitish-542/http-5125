using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : Controller
    {
        /// <summary>
        /// It provides welcoming message by receiving the GET request.
        /// </summary>
        /// <returns>
        /// It returns the HTTP response with a body indicating "welcome to 5125!"
        /// </returns>
        /// <example>
        /// GET api/q1/welcome -> "welcome to 5125!"
        /// </example>
        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return ("Welcome to 5125!");
        }

        /// <summary>
        /// It provides the message by receiving the GET request.
        /// </summary>
        /// <returns>
        /// It returns the HTTP response with a string "This is Nitish Sharma."
        /// </returns>
        /// <example>
        /// GET api/q1/example -> This is Nitish Sharma.
        /// </example>
        [HttpGet(template: "example")]
        public string example()
        {
            return ("This is Nitish Sharma.");
        }
    }
}
