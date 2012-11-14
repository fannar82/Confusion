using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TicTacToe;

namespace TicTacToeTest
{
    [TestFixture]
    public class TestFixture1
    {

        // This test fail for example, replace result or delete this test to see all tests pass
        [Test]
        public void TestFault()
        {
            FannarClass fannar = new FannarClass();

            Assert.IsFalse(fannar.fannar());
           
        }
    }
}
