using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BrezinaYS.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
 
            int a3 = (int)number % 10;
            int a2 = ((int)number / 10) % 10;
            int a1 = (int)number / 100;
            return a1 * a2 * a3;

        }
    }
}
