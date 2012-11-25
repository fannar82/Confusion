using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;
namespace TicTacToe
{
    public class MockUI : IUI
    {
        /// <summary>
        /// MoveCount counts game moves
        /// selectRow initialized
        /// selectColumn initialized
        /// </summary>
        const int COLUMNANDROW = 2;
        private int moveCount = 0;
        private int selectedRow = 2;
        private int selectedColumn = 2;
        public int[,] moves;
        private bool announceWinner = false;
        private bool announceDraw = false;
        private bool anotherGame = false;

        public MockUI() { }

        public bool GetAnotherGame()
        {
            return anotherGame;
        }

        public bool GetAnnounceWinner()
        {
            return announceWinner;
        }

        public bool GetAnnounceDraw()
        {
            return announceDraw;
        }

        public MockUI(int[,] movesFromTest, int arraySize)
        {
            moves = new int[arraySize, COLUMNANDROW];
            for (int i = 0; i < arraySize; i++)
            {
                moves[i, 0] = movesFromTest[i, 0];
                moves[i, 1] = movesFromTest[i, 1];
            }
        }

        /// <summary>
        /// Input is int, returns a char
        /// </summary>
        /// <param name="value">symbol for X, O, or white space</param>
        /// <returns>The symbol X, O or white space</returns>
        public  char ValueToSymbol(int value)
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

        /// <summary>
        /// Gets a string from keyboard
        /// </summary>
        /// <param name="player">an int value for player</param>
        /// <returns>a string</returns>
        public  string GetPlayerName(int playerNr)
        {
            return "";
        }

        /// <summary>
        /// Draws the header of the game to a console window
        /// </summary>
        public  void DrawHeader() {}

        /// <summary>
        /// clears the console window and resets t
        /// </summary>
        public  void ClearScreen()
        {
//            Console.Clear();
        }

        /// <summary>
        /// Draws the status of the gameBoard to a console window
        /// </summary>
        /// <param name="gameVoard">an instance of the gameBoard</param>
        public  void Draw(Board gameBoard)
        {
//            drawBoardbool = false;
        }

        public  void AskForPlayersMove(Player pl, Board gameBoard)
        {
            int gameBoardSize = gameBoard.GetBoardSize();
            selectedColumn = moves[moveCount, 0];
            selectedRow = moves[moveCount, 1];
            moveCount++;
        }

        /// <summary>
        /// takes to int parameters and ensure that return value 
        /// is on the range 0-gbSize, not out of bounds
        /// </summary>
        /// <param name="value">value that must be in range from 0-gbSize</param>
        /// <param name="gbSize">Max value that the function will return</param>
        /// <returns></returns>
        public  int CorrectOutOfBounds(int value, int gbSize)
        {
            if (value > gbSize)
                return 1;
            if (value < 1)
                return gbSize;
            return value;
        }
        public int GetSelectedRow()
        {
            return selectedRow;
        }

        public int GetSelectedColumn()
        {
            return selectedColumn;
        }
        
        public void AnnounceDraw()
        {
            announceDraw = true;
        }

        public void AnnounceTheWinner(Player pl)
        {
            announceWinner = true;
        }
        
        public bool PlayAnotherGame()
        {
            anotherGame = true;
            return false;
        }
    }
}