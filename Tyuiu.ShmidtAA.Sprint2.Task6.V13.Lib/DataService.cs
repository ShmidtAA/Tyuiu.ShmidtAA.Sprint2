using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShmidtAA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string result = null;
            int DayIsMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 29,
                _ => throw new ArgumentException("Месяц может быть только от 1 до 12!") 
            };
            if (n < DayIsMonth)
            {
                if ((n + 1 < 10) && (m < 10))
                {
                    result = $"0{n + 1}.0{m}.{g}";
                }
                else if ((n + 1 < 10) && (m >= 10))
                {
                    result = $"0{n + 1}.{m}.{g}";
                }
                else if (m < 10)
                {
                    result = $"{n + 1}.0{m}.{g}";
                }
                else
                {
                    result = $"{n + 1}.{m}.{g}";
                }


                
            }
            else if(m == 12)
            {
                result = $"01.01.{g+1}";

            }
            else
            {
                if (m + 1 < 10)
                {
                    result = $"01.0{m + 1}.{g}";
                }
                else
                {
                   result = $"01.{m + 1}.{g}";
                }

            }


            return result;
        }
    }
}
