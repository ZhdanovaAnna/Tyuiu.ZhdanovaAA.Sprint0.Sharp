using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Анна";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Анна", res);
        }
    }
}
