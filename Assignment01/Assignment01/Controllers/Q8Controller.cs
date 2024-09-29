using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text.Encodings.Web;

namespace Assignment01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : Controller
    {
        /// <summary>
        /// It gives the checkout summary for an order by receiving the POST request.
        /// </summary>
        /// <param name="Small"> Number of Small plushies ordered </param>
        /// <param name="Large"> Number of large plushies ordered </param>
        /// <returns>
        /// An HTTP response as a string including Subtotal, Tax, and Total
        /// </returns>
        /// <example>
        /// POST api/q8/squashfellows 
        /// Content-Type: application/x-www-form-urlencoded
        /// REQUEST BODY: Small=1&Large=1
        /// -> 1 Small @ $25.50 = $25.50; 1 Large @ $45.50 = $45.50; Subtotal = $71.00; Tax = $9.23 HST; Total = $80.23
        /// POST api/q8/squashfellows
        /// Content-Type: application/x-www-form-urlencoded
        /// REQUEST BODY: Small=2&Large=1
        /// -> 2 Small @ $25.50 = $51.00; 1 Large @ $45.50 = $45.50; Subtotal = $96.50; Tax = $12.54 HST; Total = $109.04
        /// POST api/q8/squashfellows 
        /// Content-Type: application/x-www-form-urlencoded
        /// REQUEST BODY: Small=100&Large=100
        /// -> 100 Small @ $25.50 = $2,550.00; 100 Large @ $45.50 = $4,550.00; Subtotal = $7,100.00; Tax = $923.00 HST; Total = $8,023.00
        /// </example>
        [HttpPost(template: "squashfellows")]
        public string squashfellows([FromForm] int Small, [FromForm] int Large)
        {
            decimal SmallPrice = 25.50m;
            decimal LargePrice = 45.50m;
            decimal HSTRate = 0.13m;

            decimal SmallTotal = Small * SmallPrice;
            decimal LargeTotal = Large * LargePrice;

            decimal SubTotal = SmallTotal + LargeTotal;

            decimal Tax = Math.Round(SubTotal * HSTRate, 2);

            decimal Total = Tax + SubTotal;

            string Summary = $"{Small} Small @ {SmallPrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-CA"))} = {SmallTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-CA"))}; " +
                              $"{Large} Large @ {LargePrice.ToString("C2", CultureInfo.CreateSpecificCulture("en-CA"))} = {LargeTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-CA"))}; " +
                              $"Subtotal = {SubTotal.ToString("C2", CultureInfo.CreateSpecificCulture("en-CA"))}; " +
                              $"Tax = {Tax.ToString("C2", CultureInfo.CreateSpecificCulture("en-CA"))} HST; " +
                              $"Total = {Total.ToString("C2", CultureInfo.CreateSpecificCulture("en-CA"))}";

            return Summary;
        }
    }
}
