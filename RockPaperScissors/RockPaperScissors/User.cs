using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RockPaperScissors
{
    public class User
    {
        private string _userName;
        private int _points;

        public User(string name, int points = 0)
        {
            this._userName = name;
            this._points = points;
        }

        public string GetUserName()
        {
            return this._userName;
        }

        public void SetUserName(string userName)
        {
            this._userName = userName;
        }


        public string GetPoints()
        {
            return "" + this._points;
        }
        public void SetPoints(int points)
        {
            this._points = points; 
        }
        public void AddPoint()
        {
            this._points += 1; 
        }

       

    }
}
