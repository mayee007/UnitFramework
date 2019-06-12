using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitFramework.TestCases
{
    [TestClass]
    [Category("model")]
    public class VehicleModelTest
    {
        model.Vehicle vehicle;

        [TestInitialize] 
        public void init()
        {
            vehicle = new model.Vehicle("pink", 4); 
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, vehicle.wheels);
            Assert.AreEqual("pink", vehicle.color);
        }
    }
}
