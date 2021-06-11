using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<string> Get(){
            string[] nombres = new[] {
                "Matias", "Agustin", "Scarlet", "Nair", "Marisol", "Leonardo", "Steve"
            };

            return nombres;
        }

    }
}
