using System;
using Tyuiu.BrezinaYS.Sprint1.Task5.V7.Lib;
namespace Tyuiu.BrezinaYS.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double f = 200;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(6, res);
        }
    }
}