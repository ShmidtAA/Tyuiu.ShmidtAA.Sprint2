using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShmidtAA.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a > b) | (a < b);
            result[1] = (c == d) & (c <= d);
            result[2] = (a>b) || (a<b);
            result[3] = (c != d) && (c > d);
            result[4] = !(a>c);
            result[5] = (c<=d) ^ (a==b);

            return result;
            /*  |, &, ||, &&, !, ^ 
             (True, False, True, True, True, False)
              a= 135, b = 123, c = 455, d = 321
             */
        }
    }
}
