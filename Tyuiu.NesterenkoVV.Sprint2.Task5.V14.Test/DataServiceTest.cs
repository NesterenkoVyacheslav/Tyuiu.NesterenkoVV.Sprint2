using Tyuiu.NesterenkoVV.Sprint2.Task5.V14.Lib;
namespace Tyuiu.NesterenkoVV.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 8;
            int d = 3;
            string wait = "Среда";
            var res = ds.FindDayName(x, d);
            Assert.AreEqual(wait, res);
        }
    }
}
