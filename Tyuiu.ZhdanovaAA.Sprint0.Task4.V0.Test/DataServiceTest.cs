using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task4.V0.Test
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
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(3, DataService.Subtraction(9, 6));
        }

        [TestMethod]
        public void CheckedMultiplication()
        {
            Assert.AreEqual(18, DataService.Multiplication(3, 6));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(2, DataService.Division(6, 3));
        }
    }
}
