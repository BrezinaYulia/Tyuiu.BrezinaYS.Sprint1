using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BrezinaYS.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            int z = (int)x - 5 * (int)y;

            return Math.Round(1 / Math.Sqrt(z), 3);
        }
    }
}
