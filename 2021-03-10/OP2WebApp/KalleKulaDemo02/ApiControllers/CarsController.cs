using KalleKulaDemo02.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        public List<Car> Get(string s)
        {
            var demoContext = new demoContext();
            return demoContext.Cars.Where(c => c.Plate.Contains(s)).ToList();
        }
    }
}
