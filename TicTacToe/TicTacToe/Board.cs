using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    /// <summary>
    /// 
    /// </summary>
    public class Board
    {
        private int[,] gameBoard;
        private int boardSize;
        private int newValue;

        /// <summary>
        /// 
        /// </summary>
        public Board()
        {
            gameBoard = new int[3,3];
            boardSize = 3;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        public Board(int size)
        {
            gameBoard = new int[size, size];
            this.boardSize = size;
        }
        /// <summary>
        /// 
        /// </summary>
        public void initializeBoard()
        {
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    gameBoard[x, y] = 0;
                }
            }
        }

        /// <summary>
        /// Return true if the move was legal.
        /// </summary>
        /// <param name="x">x coordination</param>
        /// <param name="y">y coordination</param>
        /// <param name="value">the value that should be added</param>
        /// <returns></returns>
        public bool newMove(int x, int y, int value)
        {
            // Check for out of bound cases
            if ( x > boardSize ) return false;
            if ( y > boardSize ) return false;
            if ( x-1 < 0 ) return false;
            if ( y-1 < 0 ) return false;
            if ( gameBoard[x-1, y-1] >0 ) return false;

            // The move is legal, make it happen!
            gameBoard[x-1, y-1] = value;
            newValue = value;
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int[,] getArray()
        {
            return gameBoard;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getBoardSize()
        {
            return boardSize;
        }
        /// <summary>
        /// Returns true if there is a winner
        /// </summary>
        /// <returns></returns>
        public bool checkForVictory()
        {

            if (gameBoard[0, 0] == newValue && gameBoard[0, 1] == newValue && gameBoard[0, 2] == newValue)
                return true;
            if (gameBoard[1, 0] == newValue && gameBoard[1, 1] == newValue && gameBoard[1, 2] == newValue)
                return true;
            if (gameBoard[2, 0] == newValue && gameBoard[2, 1] == newValue && gameBoard[2, 2] == newValue)
                return true;
            if (gameBoard[0, 0] == newValue && gameBoard[1, 0] == newValue && gameBoard[2, 0] == newValue)
                return true;
            if (gameBoard[0, 1] == newValue && gameBoard[1, 1] == newValue && gameBoard[2, 1] == newValue)
                return true;
            if (gameBoard[0, 2] == newValue && gameBoard[1, 2] == newValue && gameBoard[2, 2] == newValue)
                return true;
            if (gameBoard[0, 0] == newValue && gameBoard[1, 1] == newValue && gameBoard[2, 2] == newValue)
                return true;
            if (gameBoard[0, 2] == newValue && gameBoard[1, 1] == newValue && gameBoard[2, 0] == newValue)
                return true;

            return false;
        }
    }
}
