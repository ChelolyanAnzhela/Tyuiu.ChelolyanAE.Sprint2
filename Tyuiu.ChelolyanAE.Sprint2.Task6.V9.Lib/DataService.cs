using System.Runtime.InteropServices;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChelolyanAE.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string res = "";
            int count = m switch
            {
                1 => count = 31,
                2 => count = 28,
                3 => count = 31,
                4 => count = 30,
                5 => count = 31,
                6 => count = 30,
                7 => count = 31,
                8 => count = 31,
                9 => count = 30,
                10 => count = 31,
                11 => count = 30,
                12 => count = 31,
                < 1 => throw new ArgumentException($"Номер месяца указан некорректно. Значение {m} не соответствует условию"),
                > 12 => throw new ArgumentException($"Номер месяца указан некорректно. Значение {m} не соответствует условию"),
            };
            if (n < count)
            {
                if (n + 1 <= 9)
                {
                    res = ($"0{n + 1}.0{m}");
                }
                else
                {
                    res = ($"{n+1}.{m}");
                }

;
            }
            else
            {
                res = ($"{01}.{m + 1}");
            }
            return res;
        }

        
    }
}
