using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BrezinaYS.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            double x = f / 30;
            int res = Convert.ToInt32(Math.Floor(x));
            return res;
        }
    }
}
