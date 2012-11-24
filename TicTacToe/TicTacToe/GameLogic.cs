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
        /// This funciton decides which players turn it is.
        /// </sumary>
        /// <returns>The Player object</returns>
        private Player DecidePlayersTurn()
        {
            if (moveCount % 2 == 0)
                return player1;
            else
                return player2;
        }

        /// <summary>
        /// Creates two players and and sets gameCounts to zero.
        /// </summary>
        private void CreatePlayers()
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
        private void NewBoard()
        {
            gameBoard = new Board();
            gameBoard.InitializeBoard();
            moveCount = 0;
        }

        /// <summary>   
        /// Checks how many moves have been played
        /// </summary>
        /// <returns>The value of gameCount</returns>
        public int GetGameCount()
        {
            return gameCount;
        }

        /// <summary>   
        /// Checks to see how many moves have been played
        /// </summary>
        /// <returns>The value of moveCount</returns>
        public int GetMoveCount()
        {
            return moveCount;
        }

        /// <summary>   
        /// Sets the moveCount to an integer.
        /// </summary>
        public void SetMoveCount(int i)
        {
            moveCount = i;
        }
        
        /// <summary>
        /// Check if minimum moves have been played to get a 
        /// possible win.
        /// Minimum moves to get a winning position is always one move less
        /// than double-the-boardSize.
        /// Note that the moveCount is not updated until after this function
        /// will be used so the function assumes one less than that.
        /// </summary>
        /// <returns>true if a win is possible</returns>
        private bool MinimumWinningMoves()
        {
            return (moveCount >= gameBoard.GetBoardSize() * 2 - 2);
        }

        /// <summary>
        /// Check if all moves have been played.
        /// The maximum possible number of moves is the boardsize raised
        /// to the power of two.
        /// </summary>
        /// <returns>True if a all moves have been played</returns>
        private bool AllMovesPlayed()
        {
            return (
                    moveCount
                    >=
                    (gameBoard.GetBoardSize() * gameBoard.GetBoardSize() - 1)
                );
        }
    } // End of class       
} // End of namespace
