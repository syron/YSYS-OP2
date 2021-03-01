using ConsoleApp8.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //var playerOne = new Player("Robert");
            //var playerTwo = new Player("Winston");
            //var playerThree = new Player("Leonard");

            //var game = new Game();
            //game.AddPlayer(playerOne);
            //game.AddPlayer(playerTwo);
            //game.AddPlayer(playerThree);

            //try
            //{
            //    game.AddPlayer(new Player("Jesko"));
            //}
            //catch
            //{
            //    // Fråga användaren om hen vill fortsätta med de 3 befintliga spelarna
            //}

            //game.Run();

            //foreach (var currentPlayer in game.Players)
            //{
            //    Console.WriteLine(currentPlayer.Name);
            //    currentPlayer.Dices.ForEach(d => Console.WriteLine(d.Result));
            //}

            //var player = game.GetWinner();
            //Console.WriteLine(player.Name);



            //Console.ReadLine();



            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();



            // old code....
            // list, array, dictionary

            string name1 = "Robert";
            string name2 = "Winston";
            string name3 = "Leonard";

            var listOfName = new List<string>();
            listOfName.Add(name1);
            listOfName.Add(name2);
            listOfName.Add(name3);


            listOfName = new List<string>()
            {
                "Robert"
                , "Winston"
                , "Leonard"
                , "Jesko"
                , "Paul"
                , "Christian"
                , "Jessica"
                , "Marie", "Emilio", "Leonell", "Ellie", "Solveig", "Stina"
            };

            var firstItemINList = listOfName.First() ;
            var lastItem = listOfName.Last();

            List<string> nNames = new List<string>();
            foreach (var name in listOfName)
            {
                if (name.Contains("n")) nNames.Add(name);
            }

            nNames = listOfName.Where(n => n.Contains("n")).ToList();

            var newListWithNamesGt5 = listOfName.Where(n => n.Length > 5).ToList();


            List<int> listOfInt = new List<int>() { 1, 2, 3, 5, 5, 1, 2, 3, 12, 125, 25, 25 };

            listOfInt.ForEach(i => Console.WriteLine(i));

            var sortedList = listOfInt.OrderByDescending(i => i);
            Console.WriteLine(sortedList.First());

            Console.WriteLine("Sum: " + listOfInt.Sum());
            Console.WriteLine("Max: " + listOfInt.Max());
            Console.ReadLine();




            listOfName.ToArray();



            var listOfPlayers = new List<Tuple<string, List<int>>>();

            listOfPlayers.Add(new Tuple<string, List<int>>(name1, new List<int> { 1, 1, 3 }));
            listOfPlayers.Add(new Tuple<string, List<int>>(name2, new List<int> { 4, 1, 3 }));
            listOfPlayers.Add(new Tuple<string, List<int>>(name3, new List<int> { 5, 1, 3 }));



            var arrayOfName = new string[3];
            arrayOfName[0] = name1;
            arrayOfName[1] = name2;
            arrayOfName[2] = name3;

            var arrayOfName2 = new string[] { name1, name2, name3 };


            string[] arrayOfName3 = { name1, name2, name3 };



            var player1 = 3; // position - 0
            var player2 = 6; // position - 1 
            var player3 = 9; // position - 2


            int[] player1Score = { 3, 3, 1 };
            int[] player2Score = { 6, 6, 2 };
            int[] player3Score = { 1, 1, 6 };

            // multidimensional
            int[,] playerScores = { { 3, 3, 1 }, { 6, 6, 2 }, { 1, 1, 6 } };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Player " + i);
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(playerScores[i, j]);
                }
            }

            Console.WriteLine(" ----- ");
            // jagged
            int[][] playerScores2 = new int[3][];
            playerScores2[0] = new int[3] { 3, 3, 1 };
            playerScores2[1] = new int[6] { 6, 6, 2, 6, 6, 2 };
            playerScores2[2] = new int[4] { 1, 2, 3, 4 };

            for (int i = 0; i < 3; i++)
            {
                var currentItem = playerScores2[i];
                Console.WriteLine("Player " + (i + 1));
                for (var j = 0; j < currentItem.Length; j++)
                {
                    Console.Write(currentItem[j]);
                }
                Console.WriteLine();
            }



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(listOfName[i]);
            }

            foreach (var name in listOfName)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
