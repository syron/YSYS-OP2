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
    public class TimeForPizzaController : ControllerBase
    {
        [HttpGet]
        public int Get(DayOfWeek pizzaDayOfWeek, string unit = "seconds")
        {
            var nextPizzaDate = GetNextWeekDate(pizzaDayOfWeek);

            var timeSpan = nextPizzaDate - DateTime.Now;

            if (unit == "seconds")
                return (int)timeSpan.TotalSeconds;
            else if (unit == "minutes")
                return (int)timeSpan.TotalMinutes;
            else if (unit == "hours")
                return (int)timeSpan.TotalHours;
            else
            {
                return (int)timeSpan.TotalDays;
            }
        }

        private DateTime GetNextWeekDate(DayOfWeek day)
        {
            DateTime result = DateTime.Now;

            while (result.DayOfWeek != day)
                result = result.AddDays(1);

            return result;
        }
    }
}
