using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using NUnit;
using TicTacToe;

namespace TicTacToeTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            //            int[,] WinIn5 = new int[5,2] {{1,1},{3,1},{2,2},{1,3},{3,3}};

            //            IUI ui = new MockUI(WinIn5, 5);
            //            IUI ui = new MockUI();
            //           IUI ui = new ConsoleUI();
            //            GameLogic Game = new GameLogic(ui);
            //            Game.StartGame();  
            
            string[] my_args = { Assembly.GetExecutingAssembly().Location };

            int returnCode = NUnit.ConsoleRunner.Runner.Main(my_args);

            if (returnCode != 0)
                Console.Beep();

            Console.ReadLine();
        }
    }
}
