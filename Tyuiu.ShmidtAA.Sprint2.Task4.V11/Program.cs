using Tyuiu.ShmidtAA.Sprint2.Task4.V11.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь                   *");
            Console.WriteLine("* вводит значение переменной X, Y с клавиатуры.Округлить полученное       *");
            Console.WriteLine("* значение до трех знаков после запятой;                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:   Пользователь вводит double x,y                       *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.Write("Введите Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);  
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
