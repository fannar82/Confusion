using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Ui
    {

        /// <summary>
        ///  Input is int, returns a char
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public char valueToSymbol(int value)
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
                    symbol = 'E';
                    break;
            }
            return symbol;

        }
    }
}
