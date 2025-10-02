using Tyuiu.NesterenkoVV.Sprint2.Task2.V19.Lib;
namespace Tyuiu.NesterenkoVV.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 13;
            bool res=ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
