using System;
using Tyuiu.BrezinaYS.Sprint1.Task2.V22.Lib;
namespace Tyuiu.BrezinaYS.Sprint1.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int value, valueTwo, valueThree;
            Console.WriteLine("Введите первое число:");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CalculateAVGValue(value, valueTwo, valueThree));
            Console.ReadKey();

        }
    }
}
