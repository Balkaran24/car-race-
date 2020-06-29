using System;
using Car_Race_Balkaran;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectBalkaran
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BalkaranGreyhound truck = new BalkaranGreyhound();
            Assert.AreEqual(23, truck.truckStartingPos);
        }
    }
}
