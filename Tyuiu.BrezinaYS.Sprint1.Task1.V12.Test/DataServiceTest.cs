using System;
using Tyuiu.BrezinaYS.Sprint1.Task1.V12.Lib;

namespace Tyuiu.BrezinaYS.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServiceTest ds = new DataServiceTest();
            double x = 5.0;
            double y = 7.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);    
        }
    }
}