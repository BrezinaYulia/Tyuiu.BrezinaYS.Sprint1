using System;
using Tyuiu.BrezinaYS.Sprint1.Task6.V17.Lib;

namespace Tyuiu.BrezinaYS.Sprint1.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* аписать программу: пользователь вводит текст.                           *");
            Console.WriteLine("* Проверить, что строка является перевертышем.                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            string value;
            Console.WriteLine("Введите строку:");
            value = Convert.ToString(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine( ds.CheckPalindrome(value) );
            Console.ReadKey();
        }
    }
}
