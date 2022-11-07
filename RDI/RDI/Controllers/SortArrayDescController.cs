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
    public class SortArrayDescController : ControllerBase
    {
        [HttpPost]
        public int[] SortArrayDescending(int[] a)
        {
            return a.OrderByDescending(x => x).ToArray();
        }
    }
}
