using System;
using Tyuiu.BrezinaYS.Sprint1.Task6.V17.Lib;

namespace Tyuiu.BrezinaYS.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "123";
            bool res = ds.CheckPalindrome(value);
            
            Assert.AreEqual(false, res);


        }
    }
}