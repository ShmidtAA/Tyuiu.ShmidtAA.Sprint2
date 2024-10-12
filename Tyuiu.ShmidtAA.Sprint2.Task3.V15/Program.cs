using Tyuiu.ShmidtAA.Sprint2.Task3.V15.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("*  использованием   вложенных оператор if-else, где пользователь          *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры.Округлить полученное          *");
            Console.WriteLine("* значение до трех знаков после запятой;                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   Пользователь вводит double x                         *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("Введите Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

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
