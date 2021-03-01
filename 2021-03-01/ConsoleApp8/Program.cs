using ConsoleApp8.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new Player("Robert");
            var playerTwo = new Player("Winston");
            var playerThree = new Player("Leonard");


            var game = new Game();
            game.AddPlayer(playerOne);
            game.AddPlayer(playerTwo);
            game.AddPlayer(playerThree);

            try
            {
                game.AddPlayer(new Player("Jesko"));
            }
            catch
            {
                // Fråga användaren om hen vill fortsätta med de 3 befintliga spelarna
            }

            game.Run();


            foreach (var player in game.Players)
            {
                var firstDice = player.Dices[0];
                if (firstDice.Result != 6)
                {
                    firstDice.Throw();
                }
            }



            Console.ReadLine();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            // old code....
            // list, array, dictionary

            string name1 = "Robert";
            string name2 = "Winston";
            string name3 = "Leonard";

            var listOfName = new List<string>();
            listOfName.Add(name1);
            listOfName.Add(name2);
            listOfName.Add(name3);

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
