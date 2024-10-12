using System.Linq.Expressions;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShmidtAA.Sprint2.Task2.V3.Lib
{
    public class DataService : ISprint2Task2V3
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
           if ((x >= 3 && y >= 3) && (x <= 5 && y <= 5)) res = true;
           if ((x >= 7 && y >= 6) && (x <= 13 && y <= 8)) res = true;
           if ((x >= 7 && y >= 9) && (x <= 8 && y <= 12)) res = true;
           if ((x >= 11 && y >= 9) && (x <= 12 && y <= 13)) res = true;
           if ((x >= 7 && y >= 9) && (x <= 8 && y <= 12)) res = true;
           if ((x >= 9 && y >= 3) && (x <= 10 && y <= 5)) res = true;
           if ((x >= 4 && y >= 9) && (x <= 4 && y <= 13)) res = true;
           if ((x >= 11 && y >= 3) && (x <= 12 && y <= 3)) res = true;
           if ((x >= 6 && y >= 5) && (x <= 8 && y <= 5)) res = true;
           if ((x >= 6 && y >= 5) && (x <= 8 && y <= 5)) res = true;
           if ((x >= 5 && y >= 9) && (x <= 6 && y <= 9)) res = true;
           if ((x >= 13 && y >= 11) && (x <= 13 && y <= 13)) res = true;
            if ((x == 3 && y == 11) || (x <= 7 && y == 13)) res = true;



            return res;
        }
    }
}
