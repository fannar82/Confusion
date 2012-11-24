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
            Ui.ClearScreen();
            Ui.DrawHeader();
                CreatePlayers();
                do
                {
                PlayNewGame();
            } while (Ui.PlayAnothergame());
        }


        /// <summary>
        /// This function is called to play a new game aftar createPlayers has been called.
        /// </summary>
        private void PlayNewGame()
        {
            NewBoard();
            while (true) 
            {
                Ui.DrawBoard(gameBoard);
                do{
                Ui.AskForPlayersMove(DecidePlayersTurn(), gameBoard);
                } while(!gameBoard.NewMove(Ui.getSelectedColumn() , Ui.getSelectedRow() ,DecidePlayersTurn().GetPlayernr()));
                //while - kallar aftur í AskForPlayersMove fallið í Ui ef leikur var ólöglegur (gameboards skilaði false)       
                Ui.DrawBoard(gameBoard);
               
                // check if we have played enaugh moves to
                // have a possible win 
                if (moveCount >= gameBoard.GetBoardSize() * 2 - 2)
                {
                    if (gameBoard.CheckForVictory())
                    {
                        //the current player is the winner
                        Ui.AnnounceTheWinner(DecidePlayersTurn());
                        break;
                    }
                }

                if (moveCount >= (gameBoard.GetBoardSize() * gameBoard.GetBoardSize() - 1))
                {
                    // There is a draw - break loop
                    Ui.AnnounceDraw();
                    break;
                }

                moveCount++;
            }
        }

        /// <sumary>
        /// This funciton desieds witch players turn it is.
        /// </sumary>
        public Player DecidePlayersTurn()
        {
            if (moveCount % 2 == 0)
                return player1;
            else
                return player2;
        }

        /// <summary>
        /// Creates two players and and sets gameCounts to zero.
        /// </summary>
        public void CreatePlayers ()
        {
            player1 = new Player();
            player1.SetPlayerName(Ui.GetPlayerName(1), 1);
            player2 = new Player();
            player2.SetPlayerName(Ui.GetPlayerName(2), 2);
            gameCount = 0;    
        }

        /// <summary>
        /// Creates a new gameBoard and sets moveCount to zero.
        /// </summary>
        public void NewBoard()
        {
            gameBoard = new Board();
            gameBoard.InitializeBoard();
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
