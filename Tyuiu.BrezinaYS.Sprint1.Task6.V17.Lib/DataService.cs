using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BrezinaYS.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {

            
            char[] charArray = value.ToCharArray();
            int length = value.Length;
            for (int i = 0; i < length / 2; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[length - i - 1];
                charArray[length - i - 1] = temp;
            }
            string reversed = new string(charArray);

            return reversed;


        }
    }
}
