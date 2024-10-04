using System;
using Tyuiu.BrezinaYS.Sprint1.Task3.V13.Lib;


namespace Tyuiu.BrezinaYS.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double number = 345;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(60, res);
        }
    }
}