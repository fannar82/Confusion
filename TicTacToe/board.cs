using System;

namespace confusion.tictactoe
{
	public class Board
	{
		int[,] gameBoard;
		public int boardSize;
		public Board()
		{
			gameBoard = new int[3,3];
			boardSize = 3;
		}
		public Board(int size)
		{
			gameBoard = new int[size, size];
			boardSize = 3;
		}
		public void initializeBoard()
		{
			for (int x = 0; x < boardSize; x++)
			{
				for (int y = 0; y < boardSize; y++)
				{
					gameBoard[x,y] = 0;
				}
			}
		}
		public bool canPlay(int x, int y)
		{
			if (coordsAreLegal(x,y))
			{
				if (gameBoard[x,y] == 0)
				{
					return true;
				}
			}
			return false;
		}
		public bool coordsAreLegal(int x, int y)
		{
			if ((x > 0 && x < boardSize) && (y > 0 && y < boardSize))
			{
				return true;
			}
			return false;
		}
		public void play(int x, int y, int value)
		{
			gameBoard[x,y] = value;
		}

		public char getSquare(int x, int y)
		{
			int value = gameBoard[x,y];
			char symbol = valueToSymbol(value);
			return symbol;
		}
		
		public char valueToSymbol(int value)
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
					symbol = 'E';
					break;
            }
			return symbol;

		}
	}
}
