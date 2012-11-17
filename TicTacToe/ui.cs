using System;
using confusion.tictactoe;

namespace confusion.tictactoe
{
	public static class ui
	{
		public static int selectedColumn;
		public static int selectedRow;

		public static void drawBoard(Board gameboard)
		{
			drawHeader();
			for (int y = 0; y < gameboard.boardSize; y++)
			{
				for (int x = 0; x < gameboard.boardSize; x++)
				{
					char symbol = gameboard.getSquare(x,y);
					if (x == 0)
						Console.Write(" " + symbol.ToString() + " |");
					else if (x == gameboard.boardSize -1)
						Console.Write("| " + symbol.ToString() + " ");
					else
						Console.Write(" " + symbol.ToString() + " ");
				}
				if (y == selectedRow)
				{
					Console.Write( " < " );
				}
				Console.WriteLine( );
				if (y != gameboard.boardSize - 1)
					Console.WriteLine("-----------");
			}
			Console.WriteLine();
			for (int x = 0; x < gameboard.boardSize; x++)
			{
				if (x == selectedColumn)
				{
					Console.Write(" ^ ");
				}
				else
				{
					Console.Write("   ");
				}
			}
			Console.WriteLine();
		}

		public static void clearScreen()
		{
			Console.Clear();
		}

		public static string getPlayersName(string player)
		{
			Console.Write("Please enter your name ");
			Console.Write(player);
			Console.Write(": ");
			return Console.ReadLine();
		}

		public static void drawHeader()
		{
			Console.WriteLine("#################");
			Console.WriteLine("## Tic Tac Toe ##");
			Console.WriteLine("#################");
			Console.WriteLine();
		}
	}
}
