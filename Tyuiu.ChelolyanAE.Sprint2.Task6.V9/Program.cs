using Tyuiu.ChelolyanAE.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ChelolyanAE.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:Получение результата из switch                                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует опертор switch вычисляет         *");
            Console.WriteLine("* требуемое значение и возращает результат.                               *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами m(месяц) *");
            Console.WriteLine("* и n(число).По заданным n и m определить дату следующего дня             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите число m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.FindDateOfNextDay(m, n);
            Console.WriteLine($"Следующая дата:{res}");
            Console.ReadKey();
        }
    }
}
