using Tyuiu.ChelolyanAE.Sprint2.Task1.V29.Lib;

namespace Tyuiu.ChelolyanAE.Sprint2.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:Операции сравнения                                                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,а так же *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность: *");
            Console.WriteLine("* (True, True, True, False, True, True), при x=657, y=654, c=657, d=657   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657;
            Console.WriteLine($" x={657}");
            Console.WriteLine($" y={654}");
            Console.WriteLine($" c={657}");
            Console.WriteLine($" d={657}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            bool[] res = new bool[6];
            res=ds.GetLogicOperations(a,b,c,d);
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();


        }
    }
}
