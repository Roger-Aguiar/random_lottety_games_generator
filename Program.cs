using System;
using System.Collections.Generic;

namespace LotteryGameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateGames();
        }

        static void GenerateGames()
        {
            Console.Write("Enter the number of games that you want to generate: ");
            var quantityOfGames = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the quantity of numbers by game: ");
            var quantityOfNumbers = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the first number: ");
            var firstNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the last number: ");
            var lastNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nYour games. Good luck!\n");
            
            for(var quantity = 0; quantity < quantityOfGames; quantity++)
            {
                IGameGenerator gameGenerator = new GameGenerator(quantityOfNumbers, firstNumber, lastNumber);
                List<int> game = gameGenerator.GenerateGame();

                IGameLayout gameLayout = new GameLayout(game);
                Console.WriteLine(gameLayout.GetLayoutGame());
            }
        }
    }
}
