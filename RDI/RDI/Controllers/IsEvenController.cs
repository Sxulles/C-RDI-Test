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
    public class IsEvenController : ControllerBase
    {
        [HttpGet]
        public bool IsEven(int number)
        {
            bool result = true;
            if (number >= 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    result = !result;
                }
            }
            else
            {
                for (int i = 1; i >= number; i--)
                {
                    result = !result;
                }
            }
            return result;
        }
    }
}
