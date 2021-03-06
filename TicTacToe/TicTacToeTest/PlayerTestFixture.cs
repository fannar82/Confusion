﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TicTacToe;

namespace TicTacToeTest
{
    [TestFixture]
    public class PlayerTestFixture
    {
        [Test]
        public void PlayerName_ValidInputs_CorrectResult()
        {
            //Arrange
            Player expectedName = new Player();
            expectedName.PlayerName = "Player1";
            
            //Act
            string actualPlayerName = "Player1";

            //Assert
            Assert.IsTrue(actualPlayerName == expectedName.PlayerName);
        }

        [Test]
        public void TestSetAndGetPlayerName_ValidInputs_CorrectResult()
        {
            //Arrange
            Player TestPlayer = new Player();
            string expectedPlayerName = "Mr.Big";

            //Act
            TestPlayer.SetPlayerName("Mr.Big",1);
            string actualPlayerName = TestPlayer.GetPlayerName();

            //Assert
            Assert.IsTrue(actualPlayerName == expectedPlayerName);
        }

        [Test]
        public void TestSetPlayerNameWithEmptyString()
        {
            //Arrange
            Player TestPlayer = new Player();
            string expectedPlayerName = "Player 1";

            //Act
            TestPlayer.SetPlayerName("", 1);
            string actualPlayerName = TestPlayer.GetPlayerName();

            //Assert
            Assert.AreEqual(actualPlayerName, expectedPlayerName);
        }



    }
}
