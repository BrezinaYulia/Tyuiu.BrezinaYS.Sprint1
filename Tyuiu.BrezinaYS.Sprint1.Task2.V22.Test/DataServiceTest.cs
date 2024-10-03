using System;
using Tyuiu.BrezinaYS.Sprint1.Task2.V22.Lib;
namespace Tyuiu.BrezinaYS.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 7;
            int valueTwo = 3;
            int valueThree = 5;
            var res = ds.CalculateAVGValue(value, valueTwo, valueThree);
            Assert.AreEqual(5, res);
        }
    }
}