using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : Controller
    {
        /// <summary>
        /// It provides a greeting message with the specified name.
        /// </summary>
        /// <param name="name">The name of the person</param>
        /// <returns>
        /// It returns a string that says "Hi" followed by the specified name.
        /// </returns>
        /// <example>
        /// GET api/q2/greeting?name=Gary -> Hi Gary!
        /// GET api/q2/greeting?name=Ren%C3%A9e -> Hi Renée!
        /// </example>
        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {
            return ($"Hi {name}!");
        }
    }
}
