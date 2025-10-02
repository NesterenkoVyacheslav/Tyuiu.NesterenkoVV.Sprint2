using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.NesterenkoVV.Sprint2.Task4.V17.Lib;
namespace Tyuiu.NesterenkoVV.Sprint2.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 14;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 100;
            double y = 1;
            double wait =  6.0002;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
