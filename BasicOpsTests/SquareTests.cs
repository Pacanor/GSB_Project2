using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOps;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOps.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly double c = 2.5;
        private readonly int a = 4;
        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(6.25, BasicOps.Square.Squared(c));
        }

        [TestMethod()]
        public void SquaredTest1()
        {
            Assert.AreEqual(16, BasicOps.Square.Squared(a));
        }
    }
}