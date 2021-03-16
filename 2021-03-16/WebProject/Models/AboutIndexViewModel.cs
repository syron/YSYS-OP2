using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class AboutIndexViewModel
    {
        public Person Person { get; set; }
        public Dog Dog { get; set; }

        public List<Person> Attendees { get; set; }
    }
}
