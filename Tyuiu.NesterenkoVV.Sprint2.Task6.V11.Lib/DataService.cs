using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NesterenkoVV.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string result;
            int days;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        days = 31;
                        break;
                    }

                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        days = 30;
                        break;
                    }

                case 2:
                    {
                        days = 29;
                        break;
                    }

                default:
                    {
                        return "Ошибка";
                        break;
                    }

            }
            n++;

            if (n > days)
            {
                n = 1;
                m++;
            }

            if (m > 12)
            {
                m = 1;
                g++;
            }
            string z, k;
            if (n <= 9)
            {
                z = Convert.ToString(n);
                z = "0" + z;
            }
            else
            {
                z = Convert.ToString(n);
            }
            if (m <= 9)
            {
                k = Convert.ToString(m);
                k = "0" + k;
            }
            else
            {
                k = Convert.ToString(m);
            }
            string years = Convert.ToString(g);
            result = z+"."+k+"."+years;
            return result;
        }
    }
}