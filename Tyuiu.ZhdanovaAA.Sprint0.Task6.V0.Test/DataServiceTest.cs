using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServcie.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServcie.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataServcie.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
