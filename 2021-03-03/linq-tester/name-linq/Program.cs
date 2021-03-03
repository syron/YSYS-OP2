using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace name_linq
{

    public class Human
    {
        public DateTime DateOfBirth { get; set; }
    }

    public class NewHuman : Human
    {
        public int CalculateAge()
        {

            return 1;
            // beräkna utifrån datum...
        }
    }

    public static class HumanExtensions
    {
        public static int CalculateAge(this Human human)
        {
            return 2;
        }
    }

    public static class StringExtensions
    {
        public static string HelloWorld(this string str)
        {
            return "Hello World";
        }
        public static string Kallekula(this string str)
        {
            return "Hello World";
        }
    }

    class Program
    {
        private static async Task Egg()
        {
            await Task.Delay(500);
            Console.WriteLine("egg");
        }

        private static async Task tea()
        {
            await Task.Delay(500);
            Console.WriteLine("tea");
        }

        private static async Task meat()
        {
            await Task.Delay(500);
            Console.WriteLine("meat");
        }

        static void Main(string[] args)
        {

            var eggTask = Egg();
            var teaTask = tea();
            var meatTask = meat();




            Console.ReadLine();

            //List<string> names = new List<string>() { "Robert", "Mayer" };

            //Human human = new Human();

            //string name = "Robert";
            //name.HelloWorld();

            //name.Kallekula();


            //Console.ReadLine();





            //List<string> names = new List<string>()
            //{
            //    "Robert",
            //    "Winston",
            //    "Leonard",
            //    "Jesko",
            //    "Paul",
            //    "Christian",
            //    "Ellie",
            //    "Solveig",
            //    "Stina",
            //    "Emilio"
            //};


            //foreach (var name in names)
            //{
            //    var reversedName = name.Reverse();
            //    reversedName = string.Join(string.Empty, reversedName);
            //    Console.WriteLine(reversedName);
            //}


            //names.ForEach(name => Console.WriteLine(string.Join(string.Empty, name.Reverse())));


            //names.ForEach(n => new string(n.Reverse().ToArray()));


            //foreach (var name in names)
            //{
            //    var firstDigit = name[0];
            //    Console.WriteLine(firstDigit);
            //}

            //Console.WriteLine("---------");

            //foreach (var name in names)
            //{
            //    var firstDigit = name.First();
            //    Console.WriteLine(firstDigit);
            //}

            //Console.WriteLine("---------");

            //names.ForEach(name => Console.WriteLine(name.First()));

            //Console.WriteLine("--------- Select");


            //var firstDigitList = names.Select(name => name.First());

            //foreach(var digit in firstDigitList)
            //{
            //    Console.WriteLine(digit);
            //}

            //Console.WriteLine("--------- Select + Foreach");

            //names.Select(name => name.First())
            //     .ToList()
            //     .ForEach(digit => Console.WriteLine(digit));


            //Console.ReadLine();

        }
    }
}
