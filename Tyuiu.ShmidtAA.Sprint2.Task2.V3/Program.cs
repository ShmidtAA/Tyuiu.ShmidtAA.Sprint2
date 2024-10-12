using Tyuiu.ShmidtAA.Sprint2.Task2.V3.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и *");
            Console.WriteLine("*  вычисляет находится и точка с координатами X,Y в заштрихованной области. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   пользователь вводит int x , y                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.Write("Введите х:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("точки в заштрихованной области");
            }
            else
            {
                Console.WriteLine(" точки не в заштрихованной области");
            }


            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");



        }
    }
}
