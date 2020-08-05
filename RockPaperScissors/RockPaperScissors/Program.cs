using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tRock, Paper, Scissors");
            Console.WriteLine("\t\t {}    []      Y");

            //Initialize GameDriver
            GameDriver gameDriver = new GameDriver();

            //Run the game instance
            gameDriver.RunGame();
        }
    }
}
