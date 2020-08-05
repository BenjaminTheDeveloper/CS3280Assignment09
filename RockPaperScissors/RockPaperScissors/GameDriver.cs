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
        PlayerRecords playerRecords;
        User user;
        Leaderboard leaderboard;
        Game game;

        public GameDriver() 
        {
            this.playerRecords = new PlayerRecords();
            this.user = new User();
            this.leaderboard = new Leaderboard();
            this.game = new Game();
        } 
        public void RunGame()
        {
            Console.WriteLine("Running GameDriver");

            //this.playerRecords.Run();
            //this.leaderboard.Run();
            //this.user.Run();
            //this.game.Run(); 
        }

    }
}
