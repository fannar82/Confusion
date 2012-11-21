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
            if ( x >= boardSize ) return false;
            if ( y >= boardSize ) return false;
            if ( x-1 < 0 ) return false;
            if ( y-1 < 0 ) return false;
            if ( gameBoard[x-1, y-1] >0 ) return false;

            // The move is legal, make it happen!
            gameBoard[x-1, y-1] = value;
            return true;
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <returns></returns>
        public bool checkForVictory()
        {
            return false;
        }
        public void dummyFillingArray(int x, int y, int value)
        {
            gameBoard[0, 0] = 0;
            gameBoard[0, 0] = 0;
            gameBoard[0, 0] = 0;
            gameBoard[0, 0] = 0;
            gameBoard[0, 0] = 0;
            gameBoard[0, 0] = 0;
            gameBoard[0, 0] = 0;
            gameBoard[0, 0] = 0;
            gameBoard[0, 0] = 0;
        }
    }
}
