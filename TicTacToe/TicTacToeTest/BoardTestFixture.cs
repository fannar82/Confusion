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
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingArray_SendingCoord_OutofRange_ToLow()
        {
            //Arrange
            Board br = new Board();
            var expected = false;

            //Act
            var actual = br.newMove(0, 0, 1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingArray_SendigCoord_OutofRange_ToHigh()
        {
            //Arrange
            Board br = new Board();
            var expected = false;

            //Act
            var actual = br.newMove(5, 5, 2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingArray_SendigCoord_InRange()
        {
            //Arrange
            Board br = new Board();
            var expected = true;

            //Act
            var actual = br.newMove(2, 2, 1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingEmptyArray_Low()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.initializeBoard();
            var Empty_Arrey = br.getArray();
            var actual = Empty_Arrey[0, 0];
   

            //Assert
            Assert.AreEqual(expected,actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingEmptyArray_High()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.initializeBoard();
            var Empty_Arrey = br.getArray();
            var actual = Empty_Arrey[2, 2];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingEmptyArray_Mid()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.initializeBoard();
            var Empty_Arrey = br.getArray();
            var actual = Empty_Arrey[1, 1];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingArrayInput_SendingIn_GettingOut()
        {
            //Arrange
            Board br = new Board();
            var expected = 2;

            //Act
            br.newMove(2, 2, 2); //Array grid 1,1
            var Array = br.getArray();
            var actual = Array[1, 1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingGetBoardSize_SendingIn3_ExpectingBoardSize()
        {
            //Arrange
            Board br = new Board(3);
            var expected = 3;

            //Act
            var actual = br.getBoardSize();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingBoardConstructor()
        {
            //Arrange
            Board br = new Board();
            var expected = 3;

            //Act
            var actual = br.getBoardSize();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingCheckForVictory_True()
        {
            //Arrange
            Board br = new Board(3);
            bool expected = true;

            //Act
            br.initializeBoard();
            br.newMove(3, 1, 2);
            br.newMove(1, 1, 1);
            br.newMove(2, 2, 2);
            br.newMove(3, 3, 1);
            br.newMove(1, 3, 2);
            bool actual = br.checkForVictory();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestingCheckForVictory_False()
        {
            //Arrange
            Board br = new Board(3);
            bool expected = false;

            //Act
            br.initializeBoard();
            br.newMove(3, 1, 2);
            br.newMove(1, 1, 1);
            br.newMove(2, 2, 2);
            br.newMove(3, 3, 1);
            br.newMove(2, 3, 2);
            bool actual = br.checkForVictory();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}