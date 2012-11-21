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
            var actual = br.newMove(0, 0, 1);

            //Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [Test]
        public void TestingArray_SendigCoord_OutofRange_ToHigh()
        {
            //Arrange
            Board br = new Board();
            var expected = false;

            //Act
            var actual = br.newMove(5, 5, 2);

            //Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [Test]
        public void TestingArray_SendigCoord_InRange()
        {
            //Arrange
            Board br = new Board();
            var expected = true;

            //Act
            var actual = br.newMove(2, 2, 1);

            //Assert
            Assert.IsTrue(actual.Equals(expected));
        }
        [Test]
        public void TestEmptyArray_Low()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.initializeBoard();
            var Empty_Arrey = br.sendArray();
            var actual = Empty_Arrey[0, 0];
   

            //Assert
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void TestEmptyArray_High()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.initializeBoard();
            var Empty_Arrey = br.sendArray();
            var actual = Empty_Arrey[2, 2];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestEmptyArray_Mid()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.initializeBoard();
            var Empty_Arrey = br.sendArray();
            var actual = Empty_Arrey[1, 1];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestArrayInput_SendingIn_GettingOut()
        {
            //Arrange
            Board br = new Board();
            var expected = 2;

            //Act
            br.newMove(2, 2, 2); //Array grid 1,1
            var Array = br.sendArray();
            var actual = Array[1, 1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingValueToSymbol_SeningIn0_ExpectingSpace()
        {
            //Arrange
            Board br = new Board();
            var expected = ' ';

            //Act
            var actual = br.valueToSymbol(0);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingValueToSymbol_SeningIn1_ExpectingX()
        {
            //Arrange
            Board br = new Board();
            var expected = 'X';

            //Act
            var actual = br.valueToSymbol(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingValueToSymbol_SeningIn2_ExpectingO()
        {
            //Arrange
            Board br = new Board();
            var expected = 'O';

            //Act
            var actual = br.valueToSymbol(2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingValueToSymbol_SeningHIn_ExpectingE()
        {
            //Arrange
            Board br = new Board();
            var expected = 'E';

            //Act
            var actual = br.valueToSymbol('H');

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}