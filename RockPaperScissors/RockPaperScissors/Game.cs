using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace RockPaperScissors
{
   public class Game
    {
        Random rand = new Random(); //Used in the GenerateComputerChoice method to pick the computers choice. 

        private int _computerPoints, _userPoints, _rounds, _userChoice;
        
        
        public Game(int rounds)
        {
            this._rounds = rounds;
        }

        public int getComputerPoints()
        {
            return this._computerPoints;
        }
        
        public void AddComputerPoints()
        {
            this._computerPoints += 1;
        }

        public void AddUserPoints()
        {
            this._userPoints += 1; 
        }

        public string CheckForWinner()
        {
            if(_userPoints > _computerPoints)
            {
               return "User Wins!";
            }
            else
            {
                return "Computer Wins!";
            }
        }

        public void PlayGame()
        {
            Console.WriteLine("1. Rock {} \n2. Paper [] \n3. Scissors Y ");
            for (var round = 0; round < _rounds; round++)
            {  
                Console.WriteLine("\nShoot: ");
                this._userChoice = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine();

                RoundWinner(GenerateComputerChoice(), _userChoice);

                Console.WriteLine("You: " + _userPoints + "\t Computer: " + _computerPoints);
                
            }

        }

        public int GenerateComputerChoice()
        {
            return rand.Next(1, 4);
        }

        public void RoundWinner(int computerChoice, int userChoice)
        {
           
            if (_userChoice == 1 && computerChoice == 3)  //Rock vs Scissors = Win
            {
                UserWins(); 
            }
            else if(_userChoice == 1 && computerChoice == 2)  //Rock vs Paper = Lose
            {
                ComputerWins();
            }
            else if (_userChoice == 2 && computerChoice == 3) // Paper vs Scissors = Lose
            {
                ComputerWins();
            }
            else if (_userChoice == 2 && computerChoice == 1)// Paper vs Rock = Win
            {
                UserWins();
            }
            else if (_userChoice == 3 && computerChoice == 1)// Scissors vs Rock = Lose
            {
                ComputerWins();
            }
            else if (_userChoice == 3 && computerChoice == 2) // Scissors vs Paper = Win
            {
                UserWins();
            }
            else if(_userChoice == 1 && computerChoice == 1) // Tie Game
            {
                TieGame();
            }
            else if (_userChoice == 2 && computerChoice == 2)// Tie Game
            {
                TieGame();
            }
            else if (_userChoice == 3 && computerChoice == 3)//Tie Game
            {
                TieGame();
            }
        }

        public void UserWins()
        { 
            Console.WriteLine("You won that round!");
            _userPoints++; 
        }
        public void ComputerWins()
        {
            Console.WriteLine("Computer won that round. :( ");
            _computerPoints++;
        }
        public void TieGame()
        {
            Console.WriteLine("Tie Game!");
            _rounds++;
        }
    }
}
