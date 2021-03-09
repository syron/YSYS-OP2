using KalleKulaDemo02.Models;
using KalleKulaDemo02.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string city, string city2)
        {
            // visa temperaturen för: Karlstad, Stockholm, Lund, Buxtehude
            Stopwatch sw = new Stopwatch();
            sw.Start();
            WeatherService ws = new WeatherService();


            var karlstadTempTask = ws.TempAsync("Karlstad");
            var sthlmTempTask = ws.TempAsync("Stockholm");
            var lundTempTask = ws.TempAsync("Lund");
            var buxtehudeTempTask = ws.TempAsync("Buxtehude");
            Task<double> customTempTask = null;

            if (!string.IsNullOrEmpty(city))
            {
                customTempTask = ws.TempAsync(city);
                Task.WaitAll(karlstadTempTask, sthlmTempTask, lundTempTask, buxtehudeTempTask, customTempTask);
            }
            else
            {
                Task.WaitAll(karlstadTempTask, sthlmTempTask, lundTempTask, buxtehudeTempTask);
            }

            sw.Stop();
            var viewModel = new Models.ViewModels.Home.IndexViewModel();
            viewModel.KarlstadTemp = karlstadTempTask.Result;
            viewModel.StockholmTemp = sthlmTempTask.Result;
            viewModel.LundTemp = lundTempTask.Result;
            viewModel.BuxtehudeTemp = buxtehudeTempTask.Result;

            if (customTempTask != null)
            {
                viewModel.HasCustomTemp = true;
                viewModel.CustomTempName = city;
                viewModel.CustomTemp = customTempTask.Result;
            }

            return View(viewModel);
        }

        public IActionResult Search(string s)
        {
            List<string> names = new List<string>()
            {
                "Robert",
                "Winston",
                "Leonard",
                "Jesko",
                "Paul",
                "Christian"
            };

            if (string.IsNullOrWhiteSpace(s)) 
                return View(names);

            names = names.Where(n => n.ToLower().Contains(s.ToLower())).ToList();

            return View(names);
        }

        public IActionResult KalleKula(string id)
        {
            return View("index");
        }
        //public IActionResult KalleKula()
        //{
        //    return View("index");
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }




    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }

        public double tempCelsius { get { return temp - 273; } }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Root
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

}
