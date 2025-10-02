using Tyuiu.NesterenkoVV.Sprint2.Task7.V12.Lib;
namespace Tyuiu.NesterenkoVV.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            double x = 1;
            double y = 1;
            bool wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
