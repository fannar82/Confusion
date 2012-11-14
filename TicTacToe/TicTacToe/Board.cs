using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        private char[] board;

        // Default constructor is of size 3
        Board()
        {
            board = char[3,3]; 
        }

        // Custom size
        Board(int size)
        {
            board = char[size,size]; 
        }
    }
}
