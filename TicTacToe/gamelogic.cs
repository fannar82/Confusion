using System;
using confusion.tictactoe;

namespace confusion.tictactoe
{
	class Program
	{
		static void Main(string[] args)
		{
			Board gb = new Board(3);
			ui.clearScreen();
			ui.drawBoard(gb);
		}
	}
}
