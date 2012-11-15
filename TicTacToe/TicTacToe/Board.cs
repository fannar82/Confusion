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

        /// <summary>
        /// Return true if the move was legal
        /// </summary>
        /// <param name="x">x coordination</param>
        /// <param name="y">y coordination</param>
        /// <returns></returns>
        public bool newMove(int x, int y, char value)
        {
            if (board[x, y] != null)
                return false;

            board[x, y] = value;
            return true;
        }
    }
}
