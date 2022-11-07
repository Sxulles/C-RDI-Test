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
    public class FirstTwoWhoseSumEqualsXController : ControllerBase
    {
        [HttpPost]
        public Tuple<int, int> FirstTwoWhoseSumEqualsX(int[] numbers, int x)
        {
            var twoDigitsSumEquals10 = numbers.SelectMany((i1, index) => numbers.Skip(index + 1).Select(i2 => Tuple.Create(i1, i2))).Where(t => t.Item1 + t.Item2 == x);
            return twoDigitsSumEquals10.First();
        }
    }
}
