using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            GameLogic Game = new GameLogic();
            Game.StartGame();
            Console.WriteLine("Thank you for playing hope to see again ");
            Console.ReadKey();
          
        }

 
    }

   

}