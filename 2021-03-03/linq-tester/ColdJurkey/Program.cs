using System;
using System.Linq;
using System.Collections.Generic;

namespace ColdJurkey
{
    public class LimitedList<T> 
    {
        private List<T> Elements { get; set; }

        public LimitedList()
        {
            Elements = new List<T>();
        }
        
        public bool TryAdd(T element)
        {
            if (Elements.Count == 3)
                return false;

            Elements.Add(element);

            return true;
        }

        public override string ToString()
        {
            return string.Join(", ", Elements);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            LimitedList<string> deltagare = new LimitedList<string>();

            deltagare.TryAdd("Robert");
            deltagare.TryAdd("Winston");
            deltagare.TryAdd("Leonard");
            deltagare.TryAdd("Jesko");


            Console.WriteLine(deltagare.ToString());

            Console.ReadLine();
        }
    }


}
