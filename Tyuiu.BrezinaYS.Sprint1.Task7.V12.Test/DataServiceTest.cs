using System;
using Tyuiu.BrezinaYS.Sprint1.Task7.V12.Lib;
namespace Tyuiu.BrezinaYS.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(333, res);
        }
    }
}