using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    /// <summary>
    /// This class will handle gameboard information:
    /// It will construct the gameboard,
    /// fill the array with 0 at the beginning,
    /// test game input, if input is ok then adding value to array,
    /// searching array for winner,
    /// can return current array and board size
    /// </summary>
    public class Board
    {
        private int[,] gameBoard; // Array storing played games
        private int boardSize; // Storing the size of the game board
        private int newValue; // Keeping track of last registered value to array

        /// <summary>
        ///  Constructor without parameters,
        ///  setting game board size to 3
        /// </summary>
        public Board()
        {
            gameBoard = new int[3,3];
            boardSize = 3;
        }

        /// <summary>
        /// Constuctor taking in a parameter for board size
        /// </summary>
        /// <param name="size">Size of game board</param>
        public Board(int size)
        {
            gameBoard = new int[size, size];
            this.boardSize = size;
        }
        /// <summary>
        /// Function initialising the game board by filling it with 0
        /// </summary>
        public void InitializeBoard()
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
        /// Function testing and adding to array new games from players.
        /// </summary>
        /// <param name="x">x coordination of the array</param>
        /// <param name="y">y coordination of the array</param>
        /// <param name="value">the value that should be added representing the player</param>
        /// <returns>Returning true if the move is legal but false if not legal</returns>
        public bool NewMove(int x, int y, int value)
        {
            // Check for out of bound cases
            if ( x > boardSize ) return false;
            if ( y > boardSize ) return false;
            if ( x-1 < 0 ) return false;
            if ( y-1 < 0 ) return false;
            if (gameBoard[x - 1, y - 1] > 0 && gameBoard[x - 1, y - 1] < 3) return false;

            // The move is legal, adding to the array!
            gameBoard[x-1, y-1] = value;
            newValue = value; // Storing the current value for the function CheckForVictory
            return true;
        }
        /// <summary>
        /// Function checking the array for a winner (3 of the same values in a row)
        /// </summary>
        /// <returns>Returns true if game is won and false if not</returns>
        public bool CheckForVictory()
        {
            // Testing 8 possibilities of winning the game
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
        
        /// <summary>
        /// Function checking the array for a winner (3 of the same values in a row)
        /// </summary>
        /// <returns>Returns true if game is won and false if not</returns>
        // The followin function is not tested yet and therefore
        // not reliable and not used.
        public bool CheckForVictory(int x, int y)
        {
            if (CheckWinHorizontal(x, y)) return true;

            if (CheckWinVertical(x, y)) return true;

            if ( x == y )
                if (CheckWinULLR(0, 0)) return true;

            if ( (x+boardSize-1 == y) || (y+boardSize-1 == x) )
                if (CheckWinURLL(0, boardSize-1)) return true;

            return false;
        }
        /// <summary>
        /// Function with information of array content
        /// </summary>
        /// <returns>Returns the gameboard array with current input</returns>
        public int[,] GetArray()
        {
            return gameBoard;
        }
        /// <summary>
        /// Function with information of game board size
        /// </summary>
        /// <returns>Returns the size of the game board</returns>
        public int GetBoardSize()
        {
            return boardSize;
        }

        /// <summary>
        /// Checks for a win in the selected X row. It can take in
        /// the last move and check if there is a win from that position.
        /// </summary>
        /// <param name="x">The X position of the last move.</param>
        /// <param name="y">The Y position of the last move.</param>
        /// <returns>True if there is a win in the Y row</returns>
        private bool CheckWinHorizontal(int x, int y)
        {
            for (int i = 0; i < boardSize; i++)
                if (gameBoard[x, i] != gameBoard[x, y])
                    return false;

            return true;
        }

        /// <summary>
        /// Checks for a win in the selected Y column. It can take in
        /// the last move and check if there is a win from that position.
        /// </summary>
        /// <param name="x">The X position of the last move.</param>
        /// <param name="y">The Y position of the last move.</param>
        /// <returns>True if there is a win in the Y row</returns>
        private bool CheckWinVertical(int x, int y)
        {
            for (int i = 0; i < boardSize; i++)
                if (gameBoard[i, x] != gameBoard[x, y])
                    return false;

            return true;
        }

        /// <summary>
        /// Checks for a win in the upper left to lower right line. It can take
        /// in the last move and check if there is a win from that position.
        /// </summary>
        /// <param name="x">The X position of the last move.</param>
        /// <param name="y">The Y position of the last move.</param>
        /// <returns>True if there is a win in the upper left to the lower right line.</returns>
        private bool CheckWinULLR(int x, int y)
        {
            for (int i = 0; i < boardSize; i++)
                if (gameBoard[i, i] != gameBoard[x, y])
                    return false;

            return true;
        }

        /// <summary>
        /// Checks for a win in the upper right to lower left line. It can take
        /// in the last move and check if there is a win from that position.
        /// </summary>
        /// <param name="x">The X position of the last move.</param>
        /// <param name="y">The Y position of the last move.</param>
        /// <returns>True if there is a win in the upper right to lower left line.</returns>
        private bool CheckWinURLL(int x, int y)
        {
            for (int i = 0; i < boardSize; i++)
                if (gameBoard[i, (boardSize-1 - i)] != gameBoard[x, y])
                    return false;

            return true;
        }
    }
}
