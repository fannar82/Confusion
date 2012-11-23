using System;

namespace confusion.tictactoe
{
	public class Player
	{
		public string name { get; private set;}
		public int symbol { get; private set;}
		public Player(string desiredname, int sym)
		{
			name = desiredname;
			symbol = sym;
		}

	}
}
