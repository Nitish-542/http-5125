using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : Controller
    {
        /// <summary>
        /// Receives an HTTP POST request and provides a message.
        /// </summary>
        /// <returns>
        /// It returns a message like "Who's there?"
        /// </returns>
        /// <example>
        /// POST api/q4/knockknock -> Who's there?
        /// </example>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return ("Who's there?");
        }

        /// <summary>
        /// Receives an HTTP POST request and provides a message.
        /// </summary>
        /// <returns>
        /// It returns a message like "Boo"
        /// </returns>
        /// <example>
        /// POST api/q4/example -> Boo
        /// </example>
        [HttpPost(template: "example")]
        public string example()
        {
            return ("Boo");
        }
    }
}
