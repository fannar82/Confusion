using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;

namespace TicTacToe
{
    public static class Ui
    {

        /// <summary>
        ///  Input is int, returns a char
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static char ValueToSymbol(int value)
        {
            char symbol;
            switch (value)
            {
                case 0:
                    symbol = ' ';
                    break;
                case 1:
                    symbol = 'X';
                    break;
                case 2:
                    symbol = 'O';
                    break;
                default:
                    symbol = '\0';
                    break;
            }
            return symbol;
        }

        public static string SetPlayerName(int player)
        {
            Console.Write("Enter name for  player" + player + " name: ");
            return (Console.ReadLine());
        }

    }
}
