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
            string actualPlayerName = "Player12";

            //Assert
            Assert.That(expectedName, Is.EqualTo(actualPlayerName);           
        }
    }
}