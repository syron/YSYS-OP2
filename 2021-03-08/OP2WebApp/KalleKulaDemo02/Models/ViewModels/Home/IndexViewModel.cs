using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.Models.ViewModels.Home
{
    public class IndexViewModel
    {
        public double KarlstadTemp { get; set; }
        public double StockholmTemp { get; set; }
        public double LundTemp { get; set; }
        public double BuxtehudeTemp { get; set; }


        public bool HasCustomTemp { get; set; }
        public string CustomTempName { get; set; }
        public double CustomTemp { get; set; }
    }
}
