using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace RockPaperScissors
{

    /// <summary >
    /// GameDriver creates an instance of the game, a new user, and a leaderboard.
    /// This will include an instance of the PlayerRecords class that reads the files in. 
    /// </summary>
    class GameDriver
    {
        User user;

        Leaderboard leaderboard;

        Game game;

        int roundsToPlay;

        string name = "";
        string userWins = "User Wins!";
        string computerWins = "Computer Wins!";

        int menuNavigation;
        public GameDriver()
        {
            this.leaderboard = new Leaderboard(new List<User> { new User("Jake", 23), new User("Ben", 10), new User("Jerry", 5) });
            GetUserName();
            this.user = new User(name);
            leaderboard.AddPlayer(this.user);
        }


        public void GetUserName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            if(leaderboard.UserExists(name))
            {
                Console.WriteLine("Welcome back " + name + "!");
            }
            else
            {
                Console.WriteLine("Welcome " + name + "!");
            }
        }

        public void RunMenu()
        {
            while (menuNavigation != 4)
            {
                Console.WriteLine("Menu:");
            Console.WriteLine("1. Play New Game\n2. High Scores\n3. Clear Scores \n4. Exit");

            menuNavigation = Convert.ToInt32(Console.ReadLine());
            /* 
             * Add an error check if user does not enter a number
               If menuNav is not an int
               reload Menu
             */

            Console.WriteLine("-----------------------------------------------------------");

            //User wants to play a new game 
          
                if (menuNavigation == 1)
                {
                    //Initialize a new game
                    Console.WriteLine("How many rounds?");
                    while (roundsToPlay < 1 || roundsToPlay > 10)
                    {
                        Console.WriteLine("\nSudden Death (1)\nBest of 3 (3)\nBest of 5 (5)\nBest of 10 (10)");
                        roundsToPlay = Convert.ToInt32(Console.ReadLine());
                    }

                    this.game = new Game(roundsToPlay);

                    //Play a new game
                    Console.WriteLine();
                    this.game.PlayGame();

                    if (game.CheckForWinner().Equals(userWins))
                    {
                        Console.WriteLine(userWins);
                        this.user.AddPoint();
                    }
                    else
                    {
                        Console.WriteLine(computerWins);
                    }


                }
                else if (menuNavigation == 2) // Show the high scores
                {
                    //RunHighScoreFunction
                    this.leaderboard.GenerateLeaderboard();
                }
                else if (menuNavigation == 3) // Clear all scores
                {
                    //RunClearHighScoreFunction
                    this.leaderboard.clearAllRecords();
                }
                else if (menuNavigation == 4) // Exit the game
                {
                    Console.WriteLine("Thank you for playing! See you again soon");
                }
                else //If nothing was correctly entered
                {
                    Console.WriteLine("Please try again.");
                    RunMenu();
                }

            }
        }
    }
}

