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
            int value = 0;
            char expected = ' ';

            //Act
            char actual = Ui.ValueToSymbol(value);

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
            int value=1;
            var expected = 'X';

            //Act
            var actual = Ui.ValueToSymbol(value);

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
            var actual = Ui.ValueToSymbol(value);

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
                var actual = Ui.ValueToSymbol(value);

                //Assert
                Assert.AreEqual(expected, actual);
            }


    }
    /* Það þarf að laga testin þannig að þau dependi ekki á aðra klasa. Smá mis í gangi.
            
            /// <summary>
            /// Tests input from keyboard and and returns string (shound not be a TDD)
            /// </summary>
            [Test]
            public void TestingInputFromfakeKeyboard()
            {
                //Arrange
                string expected = "Player1";
                

                //Act
                string actual = Ui.SetPlayerName(1);
                

                //Assert
                Assert.AreEqual(expected, actual);
            }

    

                [Test]
                public void TestingDisplayPlayerName_ExpectingString_Returning_PlayerName()
                {
                    //Arrange

            
                    Player expectedName = new Player();
                    expectedName.PlayerName = "Player1";

                    //Act
                    string actualPlayerName = "Pla";

                    //Assert
                    Assert.IsTrue(actualPlayerName == expectedName.PlayerName);

                    return actualPlayerName;
                }

                   [Test]
                       public void TestNewBoard

            } */
}
