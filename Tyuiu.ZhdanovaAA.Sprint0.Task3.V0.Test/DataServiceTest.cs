using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZhdanovaAA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(24, DataService.Sum(13, 11));
        }
    }
}
