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
    public class AllEvenNumbersController : ControllerBase
    {
        [HttpPost]
        public string AllEvenNumbers(int[] numbers)
        {
            string evenNumbers = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] != 0)
                {
                    evenNumbers += Convert.ToString($"{numbers[i]}|");
                }
            }
            return evenNumbers;
        }
    }
}
