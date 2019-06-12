﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitFramework
{
    [TestClass]
    public class CalcTestSimple
    {
        model.MyCalculator calc = new model.MyCalculator(50,5);
        Dictionary<String, int> expectedResults;         

        [TestInitialize]
        public void init()
        {
            expectedResults = new Dictionary<String, int>();
            expectedResults["add"] = 55;
            expectedResults["subtract"] = 45;
            expectedResults["multiply"] = 250;
            expectedResults.Add("divide", 10); 
        }

        [TestCleanup] 
        public void calledAtEnd()
        {
            Console.WriteLine("called at end"); 
        }

        [TestMethod]
        public void addTest()
        {
            Assert.AreEqual(expectedResults["add"], calc.add());
            Assert.AreEqual(expectedResults["subtract"], calc.subtract());
            Assert.AreEqual(expectedResults["multiply"], calc.multiply());
            Assert.AreEqual(expectedResults["divide"], calc.divide());
        }
    } // end of class 
}
