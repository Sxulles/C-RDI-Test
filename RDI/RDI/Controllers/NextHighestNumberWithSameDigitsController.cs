using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NextHighestNumberWithSameDigitsController : ControllerBase
    {
        [HttpGet]
        public int NextHighestNumberWithSameDigits(int number)
        {
            char[] digits = number.ToString().ToCharArray();

            int i = digits.Length - 2;
            // we search for the element that breaks the ascending order
            while (i >= 0 && digits[i] >= digits[i + 1]) i--;
            // if we find -1, then the next greater doesn't exist, we return num
            if (i == -1) return number;

            // we create and initialize j to the last index
            int j = digits.Length - 1;
            // we search for the first digit that is greater than digits[i]
            while (digits[j] <= digits[i]) j--;

            // we swap digits[i] with digits[j]
            char temp = digits[i];
            digits[i] = digits[j];
            digits[j] = temp;

            // we reverse the part that starts from i+1
            int left = i + 1, right = digits.Length - 1;
            while (left < right)
            {
                temp = digits[left];
                digits[left] = digits[right];
                digits[right] = temp;
                left++;
                right--;
            }

            // we return digits as an integer
            return Convert.ToInt32(new string(digits));
        }
    }
}
