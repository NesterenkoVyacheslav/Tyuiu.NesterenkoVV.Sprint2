using System.IO.Compression;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NesterenkoVV.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string res = "";
            switch (((k - 1) + d - 1) % 7 + 1)
            {
                case 1:
                    res = "Понедельник";
                    break;
                case 2:
                    res = "Вторник";
                    break;
                case 3:
                    res = "Среда";
                    break;
                case 4:
                    res = "Четверг ";
                    break;
                case 5:
                    res = "Пятница";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 7:
                    res = "Воскресенье";
                    break;
                default:
                    throw new ArgumentException($"k должно быть от 1 до 365 (Значение {k} ) и d от 1 до 7 (Значение {d})");

            }
            return res;
        }   
    }
}
