using System;
using System.Collections.Generic;

namespace LotteryGameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            IGameGenerator gameGenerator = new GameGenerator(15, 1, 25);
            List<int> game = gameGenerator.GenerateGame();
            
            IGameLayout gameLayout = new GameLayout(game);
            Console.WriteLine(gameLayout.GetLayoutGame());
        }
    }
}
