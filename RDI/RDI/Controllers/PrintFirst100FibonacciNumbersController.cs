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
    public class PrintFirst100FibonacciNumbersController : ControllerBase
    {
        [HttpPost]
        public List<int> PrintFirst100FibonacciNumbers()
        {
            List<int> fibonacci = new List<int>();
            int a = 0;
            int b = 1;

            for (int i = 0; i < 100; i++)
            {
                fibonacci.Add(a);
                int swap = a;
                a = b;
                b = swap + b;
            }
            return fibonacci;
        }
    }
}
