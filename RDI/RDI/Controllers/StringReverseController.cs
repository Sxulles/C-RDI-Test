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
    public class StringReverseController : ControllerBase
    {
        [HttpGet]
        public string ReverseString(string a)
        {
            char[] chars = a.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
