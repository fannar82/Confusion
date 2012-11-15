using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        private string[,] board;
        private int size;

        // Default constructor is of size 3
        public Board()
        {
            board = new string[3,3]; 
        }

        // Custom size
        public Board(int size)
        {
            board = new string[size, size];
            //clearBoard();
        }

        /*private void clearBoard()
        {
            foreach (string coord in board)
            {
                coord = null;
            }
        }*/

        /// <summary>
        /// Return true if the move was legal
        /// </summary>
        /// <param name="x">x coordination</param>
        /// <param name="y">y coordination</param>
        /// <param name="value">the value that should be added</param>
        /// <returns></returns>
        public bool newMove(int x, int y, string value)
        {
            if (x >= size || y >= size)
                return false;

            if (board[x-1, y-1] != null)
                return false;

            board[x-1, y-1] = value;
            return true;
        }
    }
}
