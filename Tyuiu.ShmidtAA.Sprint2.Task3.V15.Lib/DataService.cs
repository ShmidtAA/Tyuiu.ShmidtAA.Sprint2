using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShmidtAA.Sprint2.Task3.V15.Lib
{
    public class DataService : ISprint2Task3V15
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = x + Math.Pow(((x + 1) / (x - 1)), x);
            }
            else if (x == 0)
            {
                res = ((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12));
            }
            else if ((-19 < x) && (x < 2))
            {
                res = Math.Pow((1 + (1 / Math.Pow(x, 2))), 8);
            }
            else if ( x < -19)
            {
                res = x + 10 * x - (1 / x);
            }
            return Math.Round(res,3);
        }
    }
}
