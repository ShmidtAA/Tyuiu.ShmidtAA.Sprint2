using Tyuiu.ShmidtAA.Sprint2.Task5.V10.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор Switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* eсловие: Дата некоторого дня характеризуется тремя натуральными числами *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).По заданным g, n и m   *");
            Console.WriteLine("*  определить дату предыдущего дня. Заданный год не является високосным.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   Пользователь вводит int year,month,day               *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.Write("Введите Год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Введите Месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());



            Console.Write("Введите День: ");
            int day = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfPreviousDay(year,month,day);
            Console.WriteLine($"Вы ввели: {day}.{month}.{year}");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine($" Вчерашняя дата: {res}");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
        }
    }
}
