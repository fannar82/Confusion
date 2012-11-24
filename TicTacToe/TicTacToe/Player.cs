using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{

    public class Player
    {
        private string name;
        private int playerNr;

        public string PlayerName { get; set; }



        public void SetPlayerName(string Pname, int plNr)
        {
            name = Pname;
            playerNr = plNr;
        }

        public string GetPlayerName()
        {
            if (name == null || name == "")
                return ("Player " + playerNr);
            else
                return name;
        }

        public int GetPlayernr()
        {
            return playerNr;
        }
    }
         
}
