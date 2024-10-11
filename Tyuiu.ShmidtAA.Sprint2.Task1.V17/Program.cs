using Tyuiu.ShmidtAA.Sprint2.Task1.V17.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)*");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность(массив)*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   a = 135, b = 123, c = 455, d = 321                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:  Массив : (True, False, True, True, True, False)             *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }



        }
    }
}
