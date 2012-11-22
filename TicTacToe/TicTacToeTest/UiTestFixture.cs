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
        /// <summary>
        ///  Tests if input 0 return ' ' space
        /// </summary>
        [Test]
        public void TestingValueToSymbol_SendingIn0_ExpectingSpace()
        {
            //Arrange
            Board br = new Board();
            var expected = ' ';

            //Act
            var actual = br.valueToSymbol(0);

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
            Board br = new Board();
            var expected = 'X';

            //Act
            var actual = br.valueToSymbol(1);

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
            Board br = new Board();
            var expected = 'O';

            //Act
            var actual = br.valueToSymbol(2);

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
            Board br = new Board();
            var expected = 'E';

            //Act
            var actual = br.valueToSymbol('E');

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /*        [Test]
              public void TestingKeyinput_SendingIn_UpKey_Expecting_ArrowUp()
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
               public void TestNewBoard
         */
    }
}
