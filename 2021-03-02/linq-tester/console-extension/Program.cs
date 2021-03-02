using System;
using System.Collections.Generic;
using System.Linq;

namespace console_extension
{
    public static class IntExtension
    {
        public static int Exp2(this int intInput)
        {
            return intInput * intInput;
        }
    }

    public static class StringExtension
    {
        public static string SkipEverySecondDigit(this string stringInput)
        {
            string newString = "";

            for (var i=0; i<stringInput.Length; i++)
            {
                newString += stringInput[i];

                i += 1;
            }

            return newString;
        }

        public static string FirstDigitInVersaille(this string stringInput)
        {
            string newString = "";

            for (var i = 0; i < stringInput.Length; i++)
            {
                if (i == 0)
                    newString += stringInput[i].ToString().ToUpper();
                else
                    newString += stringInput[i].ToString().ToLower();
            }

            return newString;
        }

        public static string GetTwoDigitsInVersaille(this string stringInput)
        {
            var firstTwoDigits = stringInput.Take(2);

            return string.Join(string.Empty, stringInput.Take(2)).ToUpper();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise1("Robert");
            
        }

        static void Exercise1(string input)
        {
            Console.WriteLine(input.SkipEverySecondDigit());
            Console.ReadLine();
        }

        static void Extension1a(string input)
        {
            Console.WriteLine(input.FirstDigitInVersaille());
            Console.ReadLine();
        }

        static void Extension3(int input)
        {
            Console.WriteLine(input.Exp2());
            Console.ReadLine();
        }


        static void Extension4(string input)
        {
            Console.WriteLine(input.GetTwoDigitsInVersaille());
            Console.ReadLine();
        }

        static void Ex2()
        {
            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int x in numbers)
            {
                Console.WriteLine(x - 1);
            }

            Console.WriteLine("----- comma");

            var newList = numbers.Select(x => x - 1);
            //foreach (var x in newList)
            //{
            //    Console.WriteLine(x);
            //}
            Console.Write(string.Join(',', newList));



            Console.Write(string.Join(',', newList.Select(no => no-1)));
            numbers.ForEach(no => Console.Write(String.Join(", ", (no - 1))));


            Console.WriteLine("----- foreach");
            numbers.ForEach(x => Console.WriteLine(x - 1));

            Console.ReadLine();
        }

        static void Ex1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            int summa = 0;
            foreach (int x in numbers)
            {
                summa += x;
            }
            Console.WriteLine(summa);

            Console.WriteLine("-----");
            Console.WriteLine(numbers.Sum());

            Console.ReadLine();
        }
    }
}
