using Microsoft.AspNetCore.Mvc;

namespace Assignment01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : Controller
    {
        /// <summary>
        /// It tells the secret number by receiving the POST request
        /// </summary>
        /// <param name="num">The secret number</param>
        /// <returns>
        /// It returns the secret number 
        /// </returns>
        /// <example>
        /// POST api/q5/secret
        /// Content-Type: application/json
        /// REQUEST BODY: 5
        /// -> Shh.. the secret is 5
        /// POST api/q5/secret
        /// Content-Type: application/json
        /// REQUEST BODY: -200
        /// -> Shh.. the secret is -200
        /// </example>
        [HttpPost(template: "secret")]
        public string secret([FromBody] int num)
        {
            return $"Shh.. the secret is {num}";
        }
    }
}
