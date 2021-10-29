using FizzBuzz.Generator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FBGeneratorController : ControllerBase
    {
        private readonly ILogger<FBGeneratorController> _logger;

        public FBGeneratorController(ILogger<FBGeneratorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{inputNumString}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<string> Generate(string inputNumString)
        {
            try
            {
                int inputNum = int.Parse(inputNumString);
                FBGenerator fBGenerator = new FBGenerator();
                return Ok(fBGenerator.Generate(inputNum));
            }
            catch
            {
                return BadRequest("Invalid Input");
            }
        }
    }
}
