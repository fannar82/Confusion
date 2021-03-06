﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;

namespace TicTacToe
{
    public class ConsoleUI : IUI
    {
        private static int selectedRow = 2;
        private static int selectedColumn= 2;

        /// <summary>
        ///  Input is int, returns a char
        /// </summary>
        /// <param name="value">symbol for X, O, or white space</param>
        /// <returns>The symbol X, O or white space</returns>
        public char ValueToSymbol(int value)
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
        ///  Gets a string from keyboard
        /// </summary>
        /// <param name="player">an int value for player</param>
        /// <returns>a string</returns>
        public  string GetPlayerName(int playerNr)
        {
            Console.Write("Player" + playerNr + " name: ");
            return (Console.ReadLine());
        }

        /// <summary>
        ///  Draws the header of the game to a console window
        /// </summary>

        public  void DrawHeader()
        {
            Console.WriteLine("      #     #     ");
            Console.WriteLine("      #     #     ");
            Console.WriteLine(" #################");
            Console.WriteLine("  Tic # Tac # Toe ");
            Console.WriteLine(" #################");
            Console.WriteLine("      #     #     ");
            Console.WriteLine("      #     #     \n");
        }

        /// <summary>
        ///  clears the console window and resets t
        /// </summary>
        public  void ClearScreen()
        {
            Console.Clear();
        }

        /// <summary>
        ///  Draws the status of the gameBoard to a console window
        /// </summary>
        /// <param name="gameVoard">an instance of the gameBoard</param>
        public  void Draw(Board gameBoard)
        {
            ClearScreen();
            DrawHeader();
            int gameBoardSize = gameBoard.GetBoardSize();
            int[,] gameBoardArray = new int[gameBoardSize, gameBoardSize];

            gameBoardArray = gameBoard.GetArray();
            for (int y = 1; y <= gameBoardSize; y++)

            {
                for (int x = 1; x <= gameBoardSize; x++)
                {
                    if (x == 1)
                        Console.Write(" " + ValueToSymbol(gameBoardArray[x-1, y-1]) + " |");
                    else if (x == gameBoardSize)
                        Console.Write("| " + ValueToSymbol(gameBoardArray[x-1, y-1]) + " ");
                    else
                        Console.Write(" " + ValueToSymbol(gameBoardArray[x-1, y-1]) + " ");
                }
                if (y == selectedRow)
                {
                    Console.Write("<");
                }
                Console.WriteLine();
                if (y != gameBoardSize)
                    Console.WriteLine("-----------");
            }
            Console.WriteLine();
            for (int x=1; x <= gameBoardSize; x++)
            {
                if (x == selectedColumn)
                    Console.WriteLine(" ^ ");
                else
                    Console.Write("    ");
            }
            Console.WriteLine();
            }


        public  void AskForPlayersMove(Player pl, Board gameBoard)
        {
            int gameBoardSize = gameBoard.GetBoardSize();
            ConsoleKeyInfo input ;
            do
            {
                Console.WriteLine(pl.GetPlayerName() + " it is your turn.  ");
                Console.Write("Move the cursor with the arrow keys \nand confirm the selection with spacebar");
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.UpArrow)
                {
                    selectedRow = selectedRow - 1;
                }
                if (input.Key == ConsoleKey.DownArrow)
                {
                    selectedRow = selectedRow + 1;
                }
                if (input.Key == ConsoleKey.LeftArrow)
                {
                    selectedColumn = selectedColumn - 1;
                }
                if (input.Key == ConsoleKey.RightArrow)
                {
                    selectedColumn = selectedColumn + 1;
                }
                selectedRow = CorrectOutOfBounds(selectedRow, gameBoardSize);
                selectedColumn = CorrectOutOfBounds(selectedColumn, gameBoardSize);
                ClearScreen();
                Draw(gameBoard);
            } while (input.Key != ConsoleKey.Spacebar);
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

        public  int GetSelectedRow()
        {
            return selectedRow;
        }
  
        public  int GetSelectedColumn()
        {
            return selectedColumn;
        }

        public  void AnnounceDraw()
        {
            Console.WriteLine("Ohh, what a pity, it is a draw.  You have to try again /n");
        }

        public  void AnnounceTheWinner(Player pl)
        {
            Console.WriteLine(pl.GetPlayerName() + " is the WINNER");
        }

        public  bool PlayAnotherGame()
        {
            Console.WriteLine("Do you whant to play again Y / N:");
            ConsoleKeyInfo input = Console.ReadKey();
            Console.WriteLine("");
            
            int TryAgain = 0;
            do
            {
                if (input.Key == ConsoleKey.Y)
                    return true;
                if (input.Key == ConsoleKey.N)
                    TryAgain = 1;
                else
                {
                    Console.WriteLine("Not a valid choice. Press Y to play again or N to quit.");
                    input = Console.ReadKey();
                    Console.WriteLine("");
                }
            } while (TryAgain != 1);
            
            return false;
        }
    }
}

