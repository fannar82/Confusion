using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;

namespace TicTacToe
{   
    /// <summary>
    /// This class is the main function in the game.
    /// </summary>
    public class GameLogic
    {
        private int moveCount, gameCount;
        private Player player1;
        private Player player2;
        private Board gameBoard;

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

                // do-while breaks if players move is legal
                do
                {
                    Ui.AskForPlayersMove(DecidePlayersTurn(), gameBoard);
                } while
                    (
                        !gameBoard.NewMove(Ui.getSelectedColumn(),
                        Ui.getSelectedRow(),
                        DecidePlayersTurn().GetPlayernr())
                    );
                Ui.DrawBoard(gameBoard);
                if (MinimumWinningMoves())  
                {
                    if (gameBoard.CheckForVictory())
                    {
                        Ui.AnnounceTheWinner(DecidePlayersTurn());
                        break;
                    }
                }

               if (AllMovesPlayed())
                {
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
        
        /// <summary>
        /// Check if minimum moves have been played to get a 
        /// possible win
        /// </summary>
        /// <returns>true if a win is possible</returns>
        private bool MinimumWinningMoves()
        {
            return (moveCount >= gameBoard.GetBoardSize() * 2 - 2);
        }

        /// <summary>
        /// Check if all moves have been played
        /// </summary>
        /// <returns>True if a all moves have been played</returns>
        private bool AllMovesPlayed()
        {
            return (moveCount >= (gameBoard.GetBoardSize() * gameBoard.GetBoardSize() - 1));
        }
        

    }
                
}
