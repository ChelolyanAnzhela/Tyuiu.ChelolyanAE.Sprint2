using Tyuiu.ChelolyanAE.Sprint2.Task0.V20.Lib;

namespace Tyuiu.ChelolyanAE.Sprint2.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1075;
            int y = 275;
            bool [] res = new bool [6];
            res  = ds.GetCompareOperations(x, y); 
            Console.Title = "Спринт #2 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:Операции сравнения                                                 *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнения и арифметических выражений,    *");
            Console.WriteLine("* которая вернет логическую последовательность:                           *");
            Console.WriteLine("* (True, False,True, False, True, False), при x=1075, y=275               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" x ={1075} ");
            Console.WriteLine($" y ={275}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
