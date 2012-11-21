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
					Console.Write("    ");
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

		public static bool askForAnotherGame()
		{
			Console.WriteLine("Do you want another game? (y/n)");
			ConsoleKeyInfo key = Console.ReadKey();
			if (key.Key == ConsoleKey.Y)
			{
				return true;
			}
			return false;

		}

		public static void announceWinner(Player pl)
		{
			Console.Write("Yay, player ");
			Console.Write(pl.name);
			Console.Write(" just won the game !!!");
			Console.WriteLine();
		}

		public static void announceDraw(Player pl1, Player pl2)
		{
			Console.Write("Ohh, what a pity, neither ");
			Console.Write(pl1.name);
			Console.Write(" nor ");
			Console.Write(pl2.name);
			Console.Write(" won the game.");
			Console.WriteLine();
		}

		public static ConsoleKeyInfo askPlayerForInput(Player pl)
		{
			ConsoleKeyInfo input;
			Console.Write(pl.name);
			Console.Write(" please move your cursor with the arrow keys");
			input = Console.ReadKey();
			return input;

		}
	}
}
