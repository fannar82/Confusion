using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class GameLogic
    {
  // ath breyti moveCount og gameCount í public til að geta gert fleiri próf (sleppti því að búa til get og set á þær).
        public int moveCount, gameCount;
        public Player player1;
        public Player player2;
        public Board gameBoard;


        /// <summary>
        /// You have to call this function to start the game, have fun :)
        /// </summary>
        public void startGame()
        {
            createPlayers();
            playNewGame();
            

        }


        /// <summary>
        /// This function is called to play a new game aftar createPlayers has been called.
        /// </summary>
        public void playNewGame()
        {
            newBoard();
//            if (desidePlayersTurn() == 1)

        
        }

        /// <sumary>
        /// This funciton desieds witch players turn it is.
        /// </sumary>
        public int desidePlayersTurn()
        {
            if (moveCount % 2 == 0)
            { return 1; }
            else
            { return 2; }
        }

        /// <summary>
        /// Creates two players and and sets gameCounts to zero.
        /// </summary>
        public void createPlayers ()
        {
            player1 = new Player();
            player2 = new Player();
            gameCount = 0;
            
        }

        /// <summary>
        /// Creates a new gameBoard and sets moveCount to zero.
        /// </summary>
        public void newBoard()
        {
            gameBoard = new Board();
            moveCount = 0;

        }


        /// <summary>   
        /// Returns the value of moveCount
        /// </summary>
        public int getMoveCount()
        {
            return moveCount;
        }

        /// <summary>   
        /// Returns the value of gameCount
        /// </summary>
        public int getGameCount()
        {
            return gameCount;
        }


    }
}
