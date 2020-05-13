using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DimitarYanakev_S00189753;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            Phone p1 = new Phone();
            p1.Price = 700;

            int Percentage = 10;

            int Result = 770;

            //ACT
            p1.IncreasedPrice(Percentage);

            //ASSERT
            Assert.AreEqual(Result, p1.Price);
        }
    }
}
