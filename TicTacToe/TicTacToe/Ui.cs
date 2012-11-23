using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;

namespace TicTacToe
{
    public static class Ui
    {
        public static int selectedRow;
        public static int selectedColumn;


        /// <summary>
        ///  Input is int, returns a char
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static char ValueToSymbol(int value)
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

        public static string GetPlayerName(int player)
        {
            DrawHeader();
            Console.Write("Player" + player + " name: ");
            return (Console.ReadLine());
        }

        public static void DrawHeader()
        {
            Console.WriteLine("###############");
            Console.WriteLine("## TicTacToe ##");
            Console.WriteLine("###############\n");
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void DrawBoard(Board gameBoard)
        {
            DrawHeader();
            int gameBoardSize = gameBoard.getBoardSize();
            int[,] gameBoardArray = new int[gameBoardSize, gameBoardSize];
            gameBoardArray = gameBoard.getArray();
            for (int y = 0; y < gameBoardSize; y++)
            {
                for (int x = 0; x < gameBoardSize; x++)
                {
                    if (x == 0)
                        Console.Write(" " + ValueToSymbol(gameBoardArray[x, y]) + " |");
                    else if (x == gameBoardSize - 1)
                        Console.Write("| " + ValueToSymbol(gameBoardArray[x, y]) + " ");
                    else
                        Console.Write(" " + ValueToSymbol(gameBoardArray[x, y]) + " ");
                }
                if (y == selectedRow)
                {
                    Console.Write("<");
                }
                Console.WriteLine();
                if (y != gameBoardSize - 1)
                    Console.WriteLine("-----------");
            }
            Console.WriteLine();
            for (int x=0; x < gameBoardSize; x++)
            {
                if (x == selectedColumn)
                    Console.WriteLine(" ^ ");
                else
                    Console.Write("    ");
            }
            Console.WriteLine();
            }
        }

    }

