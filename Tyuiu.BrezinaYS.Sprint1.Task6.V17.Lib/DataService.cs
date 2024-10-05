using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BrezinaYS.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {


            //string str = "Educative";
            char[] stringArray = value.ToCharArray();
            Array.Reverse(stringArray);
            string res = new string(stringArray);
            if (res == value)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}
