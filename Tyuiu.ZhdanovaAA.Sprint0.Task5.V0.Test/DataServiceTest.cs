using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(12, DataService.Addition(3, 9));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(6, DataService.Subtraction(9, 3));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(18, DataService.Multiplication(3, 6));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(-1, DataService.Division(25, 0));
        }
    }
}
