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

            IUI ui = new ConsoleUI();
            GameLogic Game = new GameLogic(ui);
            Game.StartGame();
            Console.WriteLine("Thank you for playing hope to see again ");
            Console.ReadKey();
          
        }

 
    }

   

}