using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5HiddenPalindromeController : ControllerBase
    {
        /// <summary>
        /// Finds the length of the longest palindrome in a given word.
        /// </summary>
        /// <param name="word">The word passed as a query parameter.</param>
        /// <returns>The length of the longest palindrome contained in the word.</returns>
        /// <example>
        /// GET: curl "https://localhost:7289/api/Q5HiddenPalindrome/FindLongestPalindrome?word=banana"
        /// -> 5
        /// </example>
        [HttpGet("FindLongestPalindrome")]
        public int FindLongestPalindrome([FromQuery] string word)
        {
            // Function to check if a substring is a palindrome
            bool IsPalindrome(string s)
            {
                int left = 0;
                int right = s.Length - 1;

                while (left < right)
                {
                    if (s[left] != s[right])
                    {
                        return false; // Not a palindrome if characters don't match
                    }
                    left++;
                    right--;
                }
                return true;
            }

            int maxLength = 1; // Minimum palindrome length is 1 (a single character)

            // Check all substrings of the word
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j <= word.Length; j++)
                {
                    string subString = word.Substring(i, j - i);

                    // Check if the substring is a palindrome
                    if (IsPalindrome(subString))
                    {
                        maxLength = Math.Max(maxLength, subString.Length);
                    }
                }
            }

            return maxLength; // Return the length of the longest palindrome
        }
    }
}
