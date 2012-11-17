using System;
using confusion.tictactoe;

namespace confusion.tictactoe
{
	class Program
	{
		static void Main(string[] args)
		{
			ui.clearScreen();
			Player playerOne = new Player(ui.getPlayersName("Player one"), 1);
			Player playerTwo = new Player(ui.getPlayersName("Player two"), 2);
			Board gb = new Board(3);
			ui.clearScreen();
			ui.drawBoard(gb);
		}
	}
}
