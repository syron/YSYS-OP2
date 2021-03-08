using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OP2WebApp.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        // https://localhost:44365/calculator?a=1&b=1&c=1
        public ActionResult Index(int a, int b, int c)
        {
            List<int> myList = new List<int>() { a, b, c };


            return View(myList);
        }

        // GET: CalculatorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculatorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculatorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromBody]IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculatorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculatorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculatorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculatorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
