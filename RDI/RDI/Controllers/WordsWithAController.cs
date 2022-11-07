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
    public class WordsWithAController : ControllerBase
    {
        [HttpPost]
        public IEnumerable<string> WordsWithA(List<string> words)
        {
            return words.Where(w => w.ToLower().Contains("a"));
        }

    }
}
