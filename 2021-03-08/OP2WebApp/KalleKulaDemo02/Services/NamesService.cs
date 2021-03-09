using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.Services
{
    public class NamesService
    {
        public List<string> Names { get; set; }

        public NamesService()
        {
            Names = new List<string>() {
                "Robert",
                "Winston",
                "Leonard",
                "Jesko",
                "Paul",
                "Christian"
            };
        }

        public List<string> GetAllNames()
        {
            return Names;
        }

        public IEnumerable<string> GetServiceBySubstring(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return Names;

            return Names.Where(n => n.Contains(s));
        }

        public void Add(string name)
        {
            Names.Add(name);
        }
    }
}
