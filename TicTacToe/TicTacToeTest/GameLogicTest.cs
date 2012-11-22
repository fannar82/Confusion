using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;
using NUnit.Framework;

namespace TicTacToeTest
{
    [TestFixture]
    class GameLogicTest
    {
        [Test]
        public void TestingCreateGame_Player()
        {
            //Arrange
            GameLogic GLnewgame = new GameLogic();
            GLnewgame.createGame();
                       
            //Act
            Player ActualPlayer1, ActualPlayer2;
            ActualPlayer1 = GLnewgame.player1;
            ActualPlayer2 = GLnewgame.player2;

            //Assert
            Assert.IsInstanceOf<Player>(ActualPlayer1 );
            Assert.IsInstanceOf<Player>(ActualPlayer2);
        }

        [Test]
        public void TestingCreateGame_Board()
        {
            //Arrange
            GameLogic GLnewgame = new GameLogic();
            GLnewgame.createGame();

            //Act
            Board ActualBoard;
            ActualBoard = GLnewgame.gameBoard;
            
            //Assert
            Assert.IsInstanceOf<Board>(ActualBoard);

        }

        }
}
