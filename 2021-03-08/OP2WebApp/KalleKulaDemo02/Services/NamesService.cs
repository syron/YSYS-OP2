using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.Services
{
    public class NamesService
    {
        public List<string> GetAllNames()
        {
            return new List<string>() {
                "Robert",
                "Winston",
                "Leonard",
                "Jesko",
                "Paul",
                "Christian"
            };
        }

        public IEnumerable<string> GetServiceBySubstring(string s)
        {
            var myList = new List<string>() {
                "Robert",
                "Winston",
                "Leonard",
                "Jesko",
                "Paul",
                "Christian"
            };

            if (string.IsNullOrWhiteSpace(s))
                return myList;

            return myList.Where(n => n.Contains(s));
        }
    }
}
