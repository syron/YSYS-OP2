using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OP2WebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OP2WebApp.Controllers
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Name(string name, int age)
        {
            var person = new Person();
            person.Name = name;
            person.Age = age;

            return View(person);
        }

        public IActionResult Pencil()
        {
            return View();
        }

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
}
