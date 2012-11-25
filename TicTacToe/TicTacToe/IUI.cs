using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class IUI
    {
        private static int selectedRow;
        private static int selectedColumn;

        /// <summary>
        ///  Input is int, returns a char
        /// </summary>
        /// <param name="value">symbol for X, O, or white space</param>
        /// <returns>The symbol X, O or white space</returns>
        public static char ValueToSymbol(int value);

        /// <summary>
        ///  Gets a string from keyboard
        /// </summary>
        /// <param name="player">an int value for player</param>
        /// <returns>a string</returns>
        public static string GetPlayerName(int playerNr);

        /// <summary>
        ///  Draws the header of the game to a console window
        /// </summary>

        public static void DrawHeader();

        /// <summary>
        ///  clears the console window and resets t
        /// </summary>
        public static void ClearScreen();

        /// <summary>
        ///  Draws the status of the gameBoard to a console window
        /// </summary>
        /// <param name="gameVoard">an instance of the gameBoard</param>
        public static void DrawBoard(Board gameBoard);

        public static void AskForPlayersMove(Player pl, Board gameBoard);

        /// <summary>
        /// takes to int parameters and ensure that return value 
        /// is on the range 0-gbSize, not out of bounds
        /// </summary>
        /// <param name="value">value that must be in range from 0-gbSize</param>
        /// <param name="gbSize">Max value that the function will return</param>
        /// <returns></returns>
        public static int CorrectOutOfBounds(int value, int gbSize);

        public static int GetSelectedRow();

        public static int GetSelectedColumn();

        public static void AnnounceDraw();

        public static void AnnounceTheWinner(Player Pl);

        public static bool PlayAnotherGame();
    }
}
