using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticOps;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticOps.Tests
{
    [TestClass()]
    public class StatVarianceTests
    {
        private readonly double[] arrayA = { 8, 10, 14, 9, 12, 7 };

        [TestMethod()]
        public void Variance_Test()
        {
            var finalVariance = StatVariance.Variance(arrayA);

            Assert.AreEqual(6.8, finalVariance);
        }
    }
}
