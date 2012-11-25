using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    abstract public class IUI
    {
        //private static int selectedRow;

        //private static int selectedColumn;

        /// <summary>
        ///  Input is int, returns a char
        /// </summary>
        /// <param name="value">symbol for X, O, or white space</param>
        /// <returns>The symbol X, O or white space</returns>
        abstract public char ValueToSymbol(int value);

        /// <summary>
        ///  Gets a string from keyboard
        /// </summary>
        /// <param name="player">an int value for player</param>
        /// <returns>a string</returns>
        abstract public string GetPlayerName(int playerNr);

        /// <summary>
        ///  Draws the header of the game to a console window
        /// </summary>
        abstract public void DrawHeader();

        /// <summary>
        ///  clears the console window and resets t
        /// </summary>
        abstract public void ClearScreen();

        /// <summary>
        ///  Draws the status of the gameBoard to a console window
        /// </summary>
        /// <param name="gameVoard">an instance of the gameBoard</param>
        abstract public void DrawBoard(Board gameBoard);

        abstract public void AskForPlayersMove(Player pl, Board gameBoard);

        /// <summary>
        /// takes to int parameters and ensure that return value 
        /// is on the range 0-gbSize, not out of bounds
        /// </summary>
        /// <param name="value">value that must be in range from 0-gbSize</param>
        /// <param name="gbSize">Max value that the function will return</param>
        /// <returns></returns>
        abstract public int CorrectOutOfBounds(int value, int gbSize);

        abstract public int GetSelectedRow();

        abstract public int GetSelectedColumn();

        abstract public void AnnounceDraw();

        abstract public void AnnounceTheWinner(Player Pl);

        abstract public bool PlayAnotherGame();
    }
}
