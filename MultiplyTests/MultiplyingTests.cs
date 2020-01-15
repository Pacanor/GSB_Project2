using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiply;
using System;
using System.Collections.Generic;
using System.Text;

namespace Multiply.Tests
{
    [TestClass()]
    public class MultiplyingTests
    {
        private readonly dynamic b = 2.2;
        private readonly dynamic a = 10;
        private readonly dynamic[] array = { 3, 12.5, 6.0, 4 };
        [TestMethod()]
        public void TimeTest()
        {
            Assert.AreEqual(18.92, BasicOps.Multiplication.Multiply(a, b));
        }

        [TestMethod()]
        public void TimeTest1()
        {
            //Assert.AreEqual(18.92, Multiply(array));
        }
    }
}

namespace MultiplyTests
{
    class MultiplyingTests
    {
    }
}
