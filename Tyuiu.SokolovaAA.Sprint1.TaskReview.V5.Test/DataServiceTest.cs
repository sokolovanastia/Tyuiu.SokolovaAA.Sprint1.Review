using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint1.TaskReview.V5.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.TaskReview.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -5;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, -0.387);
        }
    }
}
