using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;
using NUnit.Framework;

namespace TicTacToeTest
{
    [TestFixture]
    class EndToEndTest
    {
        [Test]
        public void TestingWinIn5Moves()
        {

            //Arange
            int[,] WinIn5 = new int[5,2] {{1,1},{3,1},{2,2},{1,3},{3,3}};        
            MockUI ui = new MockUI(WinIn5, 5);
            bool expected = true;

            //Act
            GameLogic Game = new GameLogic(ui);
            Game.StartGame();
            bool actual = ui.GetAnnounceWinner();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestingWinIn9Moves()
        {

            //Arange
            int[,] WinIn9 = new int[9, 2] { { 2, 2 }, { 2, 3 }, { 3, 2 }, { 1, 2 }, { 1, 3 }, { 3, 1 }, { 3, 3 }, { 2, 1 }, { 1, 1 } };
            MockUI ui = new MockUI(WinIn9, 9);
            bool expected = true;

            //Act
            GameLogic Game = new GameLogic(ui);
            Game.StartGame();
            bool actual = ui.GetAnnounceWinner();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestingDraw()
        {
            //Arange
            int[,] draw = new int[9, 2] { { 2, 2 }, { 2, 3 }, { 3, 2 }, { 1, 2 }, { 1, 3 }, { 3, 1 }, { 3, 3 }, { 1, 1 }, { 2, 1 } };
            MockUI ui = new MockUI(draw, 9);
            bool expected = true;

            //Act
            GameLogic Game = new GameLogic(ui);
            Game.StartGame();
            bool actual = ui.GetAnnounceDraw();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestingAnotherGame()
        {
            //Arange
            int[,] anotherGame = new int[9, 2] { { 2, 2 }, { 2, 3 }, { 3, 2 }, { 1, 2 }, { 1, 3 }, { 3, 1 }, { 3, 3 }, { 1, 1 }, { 2, 1 } };
            MockUI ui = new MockUI(anotherGame, 9);
            bool expected = true;

            //Act
            GameLogic Game = new GameLogic(ui);
            Game.StartGame();
            bool actual = ui.GetAnnounceDraw();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
