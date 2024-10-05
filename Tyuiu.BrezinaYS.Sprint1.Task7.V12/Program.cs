using System;
using System.Xml.Serialization;
using Tyuiu.BrezinaYS.Sprint1.Task7.V12.Lib;
namespace Tyuiu.BrezinaYS.Sprint1.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Брезина Ю. С. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление у решению итоговых проектов по спринту.                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнил: Брезина Юлия Сергеевна | ИИПб-24-2                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям, вводимых пользователем.                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*              x                                            ");
            Console.WriteLine("*       (x + 1)             2                                                ");
            Console.WriteLine("*   z = ------- + 18 * x * y                                           ");
            Console.WriteLine("*       (x - 1)                                                             ");
            Console.WriteLine("*                                                                    ");

            double x, y;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("z = " + ds.Calculate(x, y));
            Console.ReadKey();

        }
    }
}
