
using Tyuiu.ShmidtAA.Sprint2.Task7.V9.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по шаблону                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные данные                 *");
            Console.WriteLine("* (вещественные значения) и вычисляет , находится ли точка с              *");
            Console.WriteLine("* координатами X,Y в заштрихованной области.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            DataService ds = new DataService();
            Console.Write("Введите Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine($"Результат вычислений {res}");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");


        }
    }
}
