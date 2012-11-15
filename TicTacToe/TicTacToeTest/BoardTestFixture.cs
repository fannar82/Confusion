using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;
using NUnit.Framework;

namespace TicTacToeTest
{
    [TestFixture]
    public class BoardTestFixture
    {


        [Test]
        public void TestingArray_SendingCoord_OutofRange_ToLow()
        {
            //Arrange
            Board br = new Board();
            var expected = false;

            //Act
            var actioal = br.newMove(0, 0, "X");

            //Assert
            Assert.IsTrue(actioal.Equals(expected));

        }

        [Test]
        public void TestingArrey_SendigCoord_OutofRange_ToHigh()
        {
            //Arrange
            Board br = new Board();
            var expected = false;

            //Act
            var actioal = br.newMove(5, 5, "X");

            //Assert
            Assert.IsTrue(actioal.Equals(expected));

        }

    }
}