using System;
using confusion.tictactoe;

namespace confusion.tictactoe
{
	class Program
	{
		static void Main(string[] args)
		{
			Player playerOne;
			Player playerTwo;
			Board gb;
			int turn = 0;
			bool anotherGame = true;
			do
			{
				ui.clearScreen();
				playerOne = new Player(ui.getPlayersName("Player one"), 1);
            	playerTwo = new Player(ui.getPlayersName("Player two"), 2);
            	gb = new Board(3);
            	ui.clearScreen();
            	ui.drawBoard(gb);
				turn++;
				aTurn(turn, gb, playerOne, playerTwo);
				anotherGame = ui.askForAnotherGame();
			}
			while (anotherGame);
			
		}

		static void aTurn(int turn, Board gb, Player playerOne, Player playerTwo)
		{

			bool again = true;
			do
			{
				askPlayerForInput(gb, playerOne);
				gb.play(ui.selectedColumn, ui.selectedRow, 1);
				if ((turn > 2) && (gb.checkForVictory()))
				{
					ui.announceWinner(playerOne);
					again = false;
				}
				else if ((turn > 4) && (!gb.checkForVictory()))
				{
					ui.announceDraw(playerOne, playerTwo);
					again = false;
				}
				askPlayerForInput(gb, playerTwo);
				gb.play(ui.selectedColumn, ui.selectedRow, 2);
				if ((turn > 2) && (gb.checkForVictory()))
				{
					ui.announceWinner(playerTwo);
					again = false;
				}
				turn++;

			}
			while (again);
		}
		static void askPlayerForInput(Board gb, Player pl)
		{
			ConsoleKeyInfo input;
			do
			{
				input = ui.askPlayerForInput(pl);
				if (input.Key == ConsoleKey.UpArrow)
				{
						ui.selectedRow = ui.selectedRow-1;
				}
				if (input.Key == ConsoleKey.DownArrow)
				{
						ui.selectedRow = ui.selectedRow+1;
				}
				if (input.Key == ConsoleKey.LeftArrow)
				{
						ui.selectedColumn = ui.selectedColumn-1;
				}
				if (input.Key == ConsoleKey.RightArrow)
				{
						ui.selectedColumn = ui.selectedColumn+1;
				}
				ui.selectedRow = correctOutOfBounds(ui.selectedRow, gb.boardSize);
				ui.selectedColumn = correctOutOfBounds(ui.selectedColumn, gb.boardSize);
				ui.clearScreen();
				ui.drawBoard(gb);
			}
			while (input.Key != ConsoleKey.Enter);
		}

		static int correctOutOfBounds(int number, int size)
		{
			if (number < 0 )
			{
				return size-1;
			}
			else if (number == size)
			{
				return 0;
			}
			return number;
		}
	}
}

