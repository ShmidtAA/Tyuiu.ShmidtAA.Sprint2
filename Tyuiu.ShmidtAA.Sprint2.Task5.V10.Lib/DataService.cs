using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShmidtAA.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res = null;

            switch (m)
            {
                //(m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) // месяца 31 день 
                //(m == 2) //если февраль 28 дней
                // 4 6 9 11 // 30 days
                case 1:
                    
                    if(n<=31 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"31.12.{g - 1}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.0{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.0{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение: {n}");
                    }
                    
                    break;

                case 2: // 28 дней

                    if (n <= 28 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"31.01.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.0{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.0{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 28. Значение: {n}");
                    }

                   

                    break;

                case 3:
                    if (n <= 31 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"28.02.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.0{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.0{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение: {n}");
                    }

                    break;

                case 4:
                    if (n <= 30 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"31.{m - 1}.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.0{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.0{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 30. Значение: {n}");
                    }

                    break;

                case 5:
                    if (n <= 31 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"30.{m-1}.{g}";
                        }
                        else
                        {
                            res = $"{n - 1}.{m}.{g}";
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение: {n}");
                    }

                    break;


                case 6:
                    if (n <= 30 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"31.{m - 1}.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.0{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.0{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 30. Значение: {n}");
                    }
                    break;


                case 7:
                    if (n <= 31 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"30.{m - 1}.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.0{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.0{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение: {n}");
                    }

                    break;

                case 8:
                    if (n <= 31 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"31.{m - 1}.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.0{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.0{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение: {n}");
                    }

                    break;


                case 9:
                    if (n <= 30 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"31.{m - 1}.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.0{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.0{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 30. Значение: {n}");
                    }
                    break;


                case 10:
                    if (n <= 31 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"30.{m - 1}.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение: {n}");
                    }
                    break;


                case 11:
                    if (n <= 30 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"31.{m - 1}.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 30. Значение: {n}");
                    }

                    break;


                case 12:
                    if (n <= 31 && n >= 1)
                    {
                        if (n == 1)
                        {
                            res = $"30.{m - 1}.{g}";
                        }
                        else
                        {
                            if (n > 10)
                            {
                                res = $"{n - 1}.{m}.{g}";
                            }
                            else
                            {
                                res = $"0{n - 1}.{m}.{g}";
                            }
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"День должен быть от 1 до 31. Значение: {n}");
                    }

                    break;
                
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение: {m}");


            }
            
           
            if (String.IsNullOrEmpty(res)) 
            {
                throw new ArgumentException("Произошла ошибка, res пустой");
            }
            return res;
        
        }
    }
}
