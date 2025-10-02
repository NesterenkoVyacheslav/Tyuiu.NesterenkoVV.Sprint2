using Tyuiu.NesterenkoVV.Sprint2.Task6.V11.Lib;
namespace Tyuiu.NesterenkoVV.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 31;
            int m = 1;
            int g = 2000;
            string wait = "1.2.2000";
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(res, wait);
        }
    }
}
