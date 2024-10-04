using System;
using Tyuiu.BrezinaYS.Sprint1.Task4.V17.Lib;
namespace Tyuiu.BrezinaYS.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);

        }
    }
}