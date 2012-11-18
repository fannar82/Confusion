using System;

namespace confusion.tictactoe
{
	public class Board
	{
		int[,] gameBoard;
		public int boardSize;
		public int playerPlaying = 1;
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

		public bool checkForVictory()
		{
			for (int y = 0; y < boardSize; y++)
			{
				int rowValue = gameBoard[0,y];
				int columnValue = gameBoard[y,0];
				int crossValue = gameBoard[y,y];
                int invCrossValue = gameBoard[y, boardSize-y];

				if (rowValue == 0  || columnValue == 0)
					return false;
				for (int x = 1; x < boardSize; x++)
				{
					if ((x == y) && (crossValue == gameBoard[y,y]))
						continue;
					if ((x == boardSize - y) && (invCrossValue == gameBoard[y, boardSize - y]))
						continue;
					if (rowValue == gameBoard[x,y])
						continue;
					if (columnValue == gameBoard[y,x])
						continue;
					else
						return false;
				}
			}
			return true;
		}
	}
}
