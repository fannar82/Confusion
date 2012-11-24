using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;

namespace TicTacToe
{
    public class GameLogic
    {
  // ath breyti moveCount og gameCount í public til að geta gert fleiri próf (sleppti því að búa til get og set á þær).
        private int moveCount, gameCount;
        public Player player1;
        public Player player2;
        public Board gameBoard;


        /// <summary>
        /// You have to call this function to start the game, have fun :)
        /// </summary>
        public void StartGame()
        {
//            do
//            {
                CreatePlayers();
                PlayNewGame();
//            } while (Ui.PlayAnothergame());
        }


        /// <summary>
        /// This function is called to play a new game aftar createPlayers has been called.
        /// </summary>
        private void PlayNewGame()
        {
            NewBoard();
            do
            {
                //          while(!gameBoard.newMove(Ui.getMove()[0], Ui.getMove()[1],desidePlayersTurn());)
                //while - kallar aftur í newMove fallið í gameboard ef leikur var ólöglegur (gameboards skilaði false)       
                
                if (moveCount >= (gameBoard.GetBoardSize() * gameBoard.GetBoardSize()))
                {
                    // There is a draw - break loop
//                    Ui.PresentDraw(decidePlayersTurn());
                    break;
                }

                // check if we have played enaugh moves to
                // have a possible win 
                if (moveCount >= gameBoard.GetBoardSize() * 2 - 1)
                {
                    if (gameBoard.CheckForVictory())
                    {
                        //the current player is the winner
                        //ui.presentTheWinner(decidePlayersTurn());
                        break;
                    }
                }
                moveCount++;
            } while (true);
        }

        /// <sumary>
        /// This funciton desieds witch players turn it is.
        /// </sumary>
        public int DecidePlayersTurn()
        {
            return (moveCount % 2 + 1);
        }

        /// <summary>
        /// Creates two players and and sets gameCounts to zero.
        /// </summary>
        public void CreatePlayers ()
        {
            player1 = new Player();
            player2 = new Player();
            gameCount = 0;    
        }

        /// <summary>
        /// Creates a new gameBoard and sets moveCount to zero.
        /// </summary>
        public void NewBoard()
        {
            gameBoard = new Board();
            moveCount = 0;
        }


        /// <summary>   
        /// Returns the value of moveCount
        /// </summary>
        public int GetMoveCount()
        {
            return moveCount;
        }

        /// <summary>   
        /// Returns the value of gameCount
        /// </summary>
        public int GetGameCount()
        {
            return gameCount;
        }

        public void setMoveCount(int i)
        {
            moveCount = i;
        }
    }
}
