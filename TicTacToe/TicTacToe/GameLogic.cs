using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class GameLogic
    {
        private int moveCount, gameCount;
        public Player player1;
        public Player player2;
        public Board gameBoard;


        /// <summary>
        /// You have to call this function to start the game, have fun :)
        /// </summary>
        public void startGame()
        {
            createGame();

        }



        /// <summary>
        /// Creates two players and a board all you need for a fun game.
        /// </summary>
        public void createGame ()
        {
            player1 = new Player();
            player2 = new Player();
            gameBoard = new Board();

        }
    }
}
