using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicOps;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOps.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int h = 144;
        private readonly double i = 2.25;
        private readonly double[] arrayC = { 1.44, 6.25, 38.44 };
        private readonly int[] arrayD = { 9, 6, 16, 4 };

        [TestMethod()]
        public void SqrRootIntTest()
        {
            double c = SquareRoot.Root(h);
            Assert.AreEqual(12, c);
        }

        public void SqrRootDoubleTest()
        {
            double c = SquareRoot.Root(i);
            Assert.AreEqual(1.5, c);
        }

        [TestMethod()]
        public void SqrRootArrayTest()
        {
            double[] x = { 3, 2.45, 4, 2 };
            double[] c = SquareRoot.Root(arrayD);
            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }

        }

        [TestMethod()]
        public void SqrRootDoubleArrayTest()
        {
            double[] x = { 1.2, 2.5, 6.2 };
            double[] c = SquareRoot.Root(arrayC);
            for (int i = 0; i < c.Length; i++)
            {
                Assert.AreEqual(x[i], c[i]);
            }

        }
    }
}