using System;
using System.Collections.Generic;

#nullable disable

namespace KalleKulaDemo02.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
