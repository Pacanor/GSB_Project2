using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatMean;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatMean.Tests
{
    [TestClass()]
    public class FindMeanTests
    {
        public static FindMean fmean = new FindMean();

        [TestMethod()]
        public void MeanTest()
        {
            
            int[] values = { 1, 2, 3, 4, 5 };
            double mean = fmean.Mean(values);
            Assert.AreEqual(3, mean);
        }
    }
}