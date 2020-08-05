using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RockPaperScissors
{
    public class User
    {
        private string userName;

        private int points;

        public User(string name = "NoName", int points = 0) 
        {
            this.userName = name;
            this.points = points; 
        }

    }
}
