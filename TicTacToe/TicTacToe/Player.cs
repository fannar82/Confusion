using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{

    public class Player
    {
        private string name;

        public string PlayerName { get; set; }



        public void SetPlayerName(string Pname)
        {
            name = Pname;
        }

        public string GetPlayerName()
        {
            return name;
        }
    }
         
}
