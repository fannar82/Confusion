using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public interface IUI
    {

        //private static int selectedRow;
        // bool rawBoardBool;
        //private static int selectedColumn;

//        abstract public bool GetAnnouceWinner();

        /// <summary>
        ///  Input is int, returns a char
        /// </summary>
        /// <param name="value">symbol for X, O, or white space</param>
        /// <returns>The symbol X, O or white space</returns>
         char ValueToSymbol(int value);

        /// <summary>
        ///  Gets a string from keyboard
        /// </summary>
        /// <param name="player">an int value for player</param>
        /// <returns>a string</returns>
         string GetPlayerName(int playerNr);

        /// <summary>
        ///  Draws the header of the game to a console window
        /// </summary>
         void DrawHeader();



        /// <summary>
        ///  clears the console window and resets t
        /// </summary>
         void ClearScreen();

        /// <summary>
        ///  Draws the status of the gameBoard to a console window
        /// </summary>
        /// <param name="gameVoard">an instance of the gameBoard</param>
         void Draw(Board gameBoard);

         void AskForPlayersMove(Player pl, Board gameBoard);

        /// <summary>
        /// takes to int parameters and ensure that return value 
        /// is on the range 0-gbSize, not out of bounds
        /// </summary>
        /// <param name="value">value that must be in range from 0-gbSize</param>
        /// <param name="gbSize">Max value that the function will return</param>
        /// <returns></returns>
         int CorrectOutOfBounds(int value, int gbSize);

         int GetSelectedRow();

         int GetSelectedColumn();

         void AnnounceDraw();

         void AnnounceTheWinner(Player pl);

         bool PlayAnotherGame();
    }
}
