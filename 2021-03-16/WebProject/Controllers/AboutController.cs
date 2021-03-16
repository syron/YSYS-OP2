using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person();
            person.Id = 1;
            person.Name = "Robert";
            person.DateOfBirth = DateTime.Parse("1988-05-03");

            Dog dog = new Dog();
            dog.Id = 1;
            dog.Name = "Zeus";


            List<Person> attendees = new List<Person>();
            attendees.Add(new Person() { Name = "Robert" });
            attendees.Add(new Person() { Name = "Roberta" });

            AboutIndexViewModel viewModel = new AboutIndexViewModel();
            viewModel.Dog = dog;
            viewModel.Person = person;
            viewModel.Attendees = attendees;

            return View(viewModel);
        }

    }
}
