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
			for (int y = 0; y < gameboard.boardSize; y++)
			{
				for (int x = 0; x < gameboard.boardSize; x++)
				{
					Console.Write(" " + gameboard.getSquare(x,y).ToString() + " ");
				}
				if (y == selectedRow)
				{
					Console.Write( " < " );
				}
				Console.WriteLine( );
			}
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
	}
}
