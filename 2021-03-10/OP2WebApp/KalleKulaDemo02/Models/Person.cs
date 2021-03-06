﻿using System;
using System.Collections.Generic;

#nullable disable

namespace KalleKulaDemo02.Models
{
    public partial class Person
    {
        public Person()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
