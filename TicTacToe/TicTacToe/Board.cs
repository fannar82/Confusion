using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        private char[,] board;

        // Default constructor is of size 3
        public Board()
        {
            board = new char[3,3]; 
        }

        // Custom size
        public Board(int size)
        {
            board = new char[size,size]; 
        }
    }
}
