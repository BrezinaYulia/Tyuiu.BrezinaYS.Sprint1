using System;
using Tyuiu.BrezinaYS.Sprint1.Task1.V12.Lib;
namespace Tyuiu.BrezinaYS.Sprint1.Task1.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (х + у) / 6 и печатает его на экране.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
