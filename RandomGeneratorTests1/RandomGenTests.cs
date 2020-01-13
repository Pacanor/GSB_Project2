using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator.Tests
{
    [TestClass()]
    public class RandomGenTests
    {
        [TestMethod()]
        public void RandomIntTest()
        {
            int a = RandomGen.RandomInt();
            Assert.AreEqual(a, 2);
        }

        [TestMethod()]
        public void RandomDoubleTest()
        {
            double a = RandomGen.RandomDouble();
            Assert.AreEqual(a, 2);
        }
        
        [TestMethod()]
        public void RandomNumberIntTest()
        {
            int a = RandomGen.RandomNumber(2, 68);
            Assert.AreEqual(a, 2);
        }
        
        [TestMethod()]
        public void RandomNumberDoubleTest()
        {
            double a = RandomGen.RandomNumber(2.4, 68.4);
            Assert.AreEqual(a, 2);
        }
        /*
                        [TestMethod()]
                        public void RandomDoublesTest()
                        {
                            Assert.Fail();
                        }

                        [TestMethod()]
                        public void RandomIntsTest()
                        {
                            Assert.Fail();
                        }

                        [TestMethod()]
                        public void RandomDoublesTest1()
                        {
                            Assert.Fail();
                        }

                        [TestMethod()]
                        public void RandomIntsTest1()
                        {
                            Assert.Fail();
                        }
                        */
    }
}