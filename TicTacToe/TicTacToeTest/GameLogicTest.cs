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
        public void TestingCreatePlayers()
        {
            //Arrange
            GameLogic GLnewgame = new GameLogic();
            GLnewgame.createPlayers();
                       
            //Act
            Player ActualPlayer1, ActualPlayer2;
            ActualPlayer1 = GLnewgame.player1;
            ActualPlayer2 = GLnewgame.player2;

            //Assert
            Assert.IsInstanceOf<Player>(ActualPlayer1 );
            Assert.IsInstanceOf<Player>(ActualPlayer2);
        }

        [Test]
        public void TestingNewBoard()
        {
            //Arrange
            GameLogic GLnewgame = new GameLogic();
            GLnewgame.newBoard();

            //Act
            Board ActualBoard;
            ActualBoard = GLnewgame.gameBoard;
            
            //Assert
            Assert.IsInstanceOf<Board>(ActualBoard);

        }

        [Test]
        public void TestingnewBoard_moveCountToZero()
        {
            //Arrange
            GameLogic GLnewgame = new GameLogic();
            GLnewgame.createPlayers();
            int expectedMoveCount = 0;


            //Act
            int actualMoveCount;
            actualMoveCount = GLnewgame.getMoveCount();

            //Assert
            Assert.AreEqual (expectedMoveCount, actualMoveCount);

        }

        [Test]
        public void TestingCreatePlayers_GameCountToZero()
        {
            //Arrange
            GameLogic GLnewgame = new GameLogic();
            GLnewgame.createPlayers();
            int expectedGameCount = 0;

            //Act
            int actualGameCount;
            actualGameCount = GLnewgame.getGameCount();

            //Assert
            Assert.AreEqual(expectedGameCount, actualGameCount);
        }
// svolítið asnalegt próf þar sem við viljum hafa moveCount private en verðum þá að setja get og set fyrir hana til að geta testað 
// og hver er þá tilgangurinn að vera með hana private, ATH breytti henni í public.
        [Test]
        public void TestingDesedePlayersTurn()
        {
         //Arrange - test 0
            GameLogic GLnewgame = new GameLogic();
            GLnewgame.moveCount = 0;
            int expectedReturn = 1;
          //Act
            int actualReturn;
            actualReturn = GLnewgame.desidePlayersTurn();
           //Assert
            Assert.AreEqual(expectedReturn, actualReturn);
        //Arrange - test 5
            GLnewgame.moveCount = 5;
            expectedReturn = 2;
          //Act
            actualReturn = GLnewgame.desidePlayersTurn();
          //Assert
            Assert.AreEqual(expectedReturn, actualReturn);

        }



        }
}
