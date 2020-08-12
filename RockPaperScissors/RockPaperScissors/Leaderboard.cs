using System;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;

namespace RockPaperScissors
{
    public class Leaderboard
    {
        private List<User> players;
        public Leaderboard(List<User> players)
        {
            this.players = players;
        }

        public void AddPlayer(User player)
        {
            players.Add(player);
        }

        public void RemovePlayer(User player)
        {
            this.players.Remove(player);
        }

        public bool UserExists(string name)
        {
            for(int i = 0; i < players.Count; i++)
            {
                if(name.Equals(players[i].GetUserName()))
                {
                    return true;
                }
            }
            return false; 
        }
        public List<User> LoadUserDetails()
        {
            return null; 
        }
        public void UpdateUserInfo(User user)
        {

        }

        public void GenerateLeaderboard()
        {
            if(players.Count == 0)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("    Leaderboard    ");
                Console.WriteLine("-------------------");
                Console.WriteLine("No Current Scores");
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("    Leaderboard    ");
            for (int i = 0; i < players.Count; i++)
            {
                Console.Write(players[i].GetUserName() + ": ");
                Console.WriteLine(players[i].GetPoints());
                Console.WriteLine();
            }
        }
        public void clearAllRecords()
        {
            this.players = new List<User>();
        }
    }

   
}
