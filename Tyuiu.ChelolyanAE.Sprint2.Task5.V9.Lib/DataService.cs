using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChelolyanAE.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int count = 0;
            string res = "";
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    count = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    count = 30;
                    break;
                case 2:
                    count = 28;
                    break;
                default:
                    throw new ArgumentException($"Номер месяца указан некорректно. Значение {m} не соответствует условию");
            }

            if (n < count)
            {
                res = ($"{n + 1}.{m}");
            }
            else
            {
                res = ($"{1}.{m + 1}");
            }
            return res;
        }
    }
}
