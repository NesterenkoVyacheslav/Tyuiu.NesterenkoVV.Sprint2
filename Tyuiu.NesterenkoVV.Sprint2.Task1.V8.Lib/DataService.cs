using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NesterenkoVV.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            
            bool[] result = new bool[6];
            result[0] = (a < b) | (b != d);
            result[1] = (a + 1 != b) || (b >= d);
            result[2] = (d > c) & (c != a);
            result[3] = (b == c) && (c > d);
            result[4] = !(a > c);
            result[5] = (d > a) ^ (a <= b);
            return result;
        }
    }
}
