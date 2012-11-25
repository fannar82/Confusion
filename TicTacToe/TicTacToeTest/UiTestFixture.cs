using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToe;
using NUnit.Framework;

namespace TicTacToeTest
{
    [TestFixture]
    public class UiTestFixture
    {
//    Nýtt nafn ConsoleUITest
        
  
        const int MAX_BOARDSIZE = 3;
        IUI TestConsoleUI = new ConsoleUI();

        /// <summary>
        ///  Tests if input 0 return ' ' space
        /// </summary>
        [Test]
        public void TestingValueToSymbol_SendingIn0_ExpectingSpace()
        {
            //Arrange
            int value = 0;
            char expected = ' ';

            //Act
            char actual = TestConsoleUI.ValueToSymbol(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        /// <summary>
        /// Tests if input 1 return X
        /// </summary>
        [Test]
        public void TestingValueToSymbol_SendingIn1_ExpectingX()
        {
            //Arrange
            int value = 1;
            var expected = 'X';

            //Act
            var actual = TestConsoleUI.ValueToSymbol(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        /// <summary>
        /// Tests if input 2 return O
        /// </summary>
        [Test]
        public void TestingValueToSymbol_SendingIn2_ExpectingO()
        {
            //Arrange
            int value = 2;
            var expected = 'O';

            //Act
            var actual = TestConsoleUI.ValueToSymbol(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        /// <summary>
        /// Tests if input H, returns E (Error)
        /// </summary>
        [Test]
        public void TestingValueToSymbol_SendingInH_ExpectingE()
        {
            //Arrange
            int value = 3;
            var expected = '\0';

            //Act
            var actual = TestConsoleUI.ValueToSymbol(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests CorrectOutOfBounds if more than boardSize then returns 0
        /// </summary>
        [Test]
        public void TestingCorrectionOutOfBoundOver()
        {
            //Arrange
            int value = MAX_BOARDSIZE+1, boardSize = MAX_BOARDSIZE;
            var expected = 1;

            //Act
            var actual = TestConsoleUI.CorrectOutOfBounds(value, boardSize);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        /// Tests CorrectOutOfBounds if less than 0 then returns MAX_BOARDSIZE
        /// </summary>
        [Test]
        public void TestingCorrectionOutOfBoundUnder()
        {
            //Arrange
            int value = -1, boardSize = MAX_BOARDSIZE;
            var expected = MAX_BOARDSIZE;

            //Act
            var actual = TestConsoleUI.CorrectOutOfBounds(value, boardSize);

            //Assert
            Assert.AreEqual(expected, actual);
        }
                
/* til að testa þetta fall þarf að yfirskrifa Console.ReadKey() - ToDo

        /// <summary>
        /// Tests bool play another game
        /// </summary>
        [Test]
        public void TestingPlayAnotherGame()
        {
            //Arrange
            bool expected = false;

            //Act
            bool actual = TestConsoleUI.PlayAnotherGame();

            //Assert
            Assert.AreEqual(expected, actual);
        }

*/
        /* Þetta er ekki vegna þess að þetta test er í viðmótstesti - 
        * 
 
        /// <summary>
        /// PrintOutTest not part of unitTest
        /// </summary>
        [Test]
        public void TestingDrawBoard()
        {
            //Þetta er ekki vegna þess að þetta
            //test er í viðmótstesti
        }

        */
    }
}
