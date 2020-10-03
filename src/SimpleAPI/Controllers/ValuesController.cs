using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Value123", "Value21"
        };

        private readonly ILogger<ValuesController> _logger;

        public ValuesController(){
            
        }

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string[] Get()
        {
            var rng = new Random();
            return Summaries;
        }

        
         // This is a sample class
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
          return "Sarath Raj";
        }
    }
}
