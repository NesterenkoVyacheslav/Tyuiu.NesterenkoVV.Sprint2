using Tyuiu.NesterenkoVV.Sprint2.Task6.V11.Lib;
namespace Tyuiu.NesterenkoVV.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Нестеренко В. В. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Нестеренко Вячеслав Владимирович | ИИПБ-25-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дата некоторого дня характеризуется тремя натуральными числами: g (год), *");
            Console.WriteLine("*m (порядковый номер месяца) и n (число). По заданным g, n и m определить *");
            Console.WriteLine("*дату следующего дня                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            int g, m, d;
            Console.WriteLine("Введите g");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите m");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d");
            d = Convert.ToInt32(Console.ReadLine());
            var res = ds.FindDateOfNextDay(g, m, d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
