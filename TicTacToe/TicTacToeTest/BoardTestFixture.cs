using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;
using NUnit.Framework;

namespace TicTacToeTest
{
    /// <summary>
    /// This is a test class used to test functions and variables
    /// in the board class
    /// </summary>
    [TestFixture]
    public class BoardTestFixture
    {
        /// <summary>
        /// Testing default board constructor
        /// board size should be 3
        /// </summary>
        [Test]
        public void TestingDefaultConstructor()
        {
            //Arrange
            Board br = new Board();
            var expected = 3;

            //Act
            var actual = br.GetBoardSize();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing board cunstructior with parmeter
        /// board size should be 4
        /// </summary>
        [Test]
        public void TestingParameterConstructor()
        {
            //Arrange
            Board br = new Board(4);
            var expected = 4;

            //Act
            var actual = br.GetBoardSize();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function InitializeBoard
        /// All array coords should have 0
        /// </summary>
        [Test]
        public void TestingEmptyArray_Low()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.InitializeBoard();
            var Empty_Arrey = br.GetArray();
            var actual = Empty_Arrey[0, 0];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function InitializeBoard
        /// All array coords should have 0
        /// </summary>
        [Test]
        public void TestingEmptyArray_High()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.InitializeBoard();
            var Empty_Arrey = br.GetArray();
            var actual = Empty_Arrey[2, 2];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function InitializeBoard
        /// All array coords should have 0
        /// </summary>
        [Test]
        public void TestingEmptyArray_Mid()
        {
            //Arrange
            Board br = new Board();
            var expected = 0;

            //Act
            br.InitializeBoard();
            var Empty_Arrey = br.GetArray();
            var actual = Empty_Arrey[1, 1];


            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function NewMove if coords are out of range
        /// NewMove function coord parameter is array coord +1
        /// </summary>
        [Test]
        public void TestingNewMoveInput_SendingCoord_OutofRange_ToLow()
        {
            //Arrange
            Board br = new Board();
            var expected = true;

            //Act
            var actual = br.NewMove(0, 0, 1);//Array cords -1,-1

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function NewMove if coords are out of range
        /// NewMove function coord parameter is array coord +1
        /// </summary>
        [Test]
        public void TestingNewMoveInput_SendigCoord_OutofRange_ToHigh()
        {
            //Arrange
            Board br = new Board();
            var expected = false;

            //Act
            var actual = br.NewMove(4, 5, 2); //Array coords 3,5

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function NewMove if coords are in range
        /// NewMove function coord parameter is array coord +1
        /// </summary>
        [Test]
        public void TestingNewMoveInput_SendigCoord_InRange()
        {
            //Arrange
            Board br = new Board();
            var expected = true;

            //Act
            var actual = br.NewMove(2, 2, 1); //Array coords 1,1

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function NewMove if value is legal
        /// value should be 1 or 2
        /// </summary>
        [Test]
        public void TestingNewMoveInput_SendingValueToLow()
        {
            //Arrange
            Board br = new Board();
            var expected = false;

            //Act
            var actual = br.NewMove(0, 0, 0); // Sending in 0, not legal

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function NewMove if value is legal
        /// value should be 1 or 2 
        /// </summary>
        [Test]
        public void TestingNewMoveInput_SendingValueToHigh()
        {
            //Arrange
            Board br = new Board();
            var expected = false;

            //Act
            var actual = br.NewMove(0, 0, 3); // Sending in 3, not legal

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing if legal value from function NewMove in in array
        /// Testing function GetArray
        /// </summary>
        [Test]
        public void TestingCurrentArrayValue_SendingInLegalValue()
        {
            //Arrange
            Board br = new Board();
            var expected = 2;

            //Act
            br.NewMove(2, 2, 2); //Legal array coord 1,1 with legal with legal value 
            var Array = br.GetArray();
            var actual = Array[1, 1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function CheckForVictory
        /// Sending in moves that lead to victory
        /// </summary>
        [Test]
        public void TestingCheckForVictory_True()
        {
            //Arrange
            Board br = new Board(3);
            bool expected = true;

            //Act
            br.InitializeBoard();
            br.NewMove(3, 1, 2);
            br.NewMove(1, 1, 1);
            br.NewMove(2, 2, 2);
            br.NewMove(3, 3, 1);
            br.NewMove(1, 3, 2);
            bool actual = br.CheckForVictory(1, 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function CheckForVictory
        /// Sending in moves that do not lead to victory 
        /// </summary>
        [Test]
        public void TestingCheckForVictory_TrueIn9Games()
        {
            //Arrange
            Board br = new Board(3);
            bool expected = true;

            //Act
            br.InitializeBoard();
            br.NewMove(2, 2, 2);
            br.NewMove(1, 1, 1);
            br.NewMove(3, 3, 2);
            br.NewMove(3, 2, 1);
            br.NewMove(1, 2, 2);
            br.NewMove(2, 1, 1);
            br.NewMove(3, 1, 2);
            br.NewMove(2, 3, 1);
            br.NewMove(1, 3, 2);
            bool actual = br.CheckForVictory(1, 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testing function CheckForVictory
        /// Sending in moves that do not lead to victory 
        /// </summary>
        [Test]
        public void TestingCheckForVictory_FalseIn9Games()
        {
            //Arrange
            Board br = new Board(3);
            bool expected = false;

            //Act
            br.InitializeBoard();
            br.NewMove(2, 2, 2);
            br.NewMove(1, 1, 1);
            br.NewMove(3, 3, 2);
            br.NewMove(3, 2, 1);
            br.NewMove(1, 2, 2);
            br.NewMove(2, 1, 1);
            br.NewMove(3, 1, 2);
            br.NewMove(1, 3, 1);
            br.NewMove(2, 3, 2);
            bool actual = br.CheckForVictory(2, 3);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}