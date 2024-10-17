using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShmidtAA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((0.5 >= Math.Sin(x)) && x > 0 && y > 0)
            {
                return true;
            }
            else if (x == 0.5 && y == 0.5)
            {
                return false;
            }

            else { 
                return false; 
            }
        }
    }
}
