using Tyuiu.NesterenkoVV.Sprint2.Task3.V7.Lib;
namespace Tyuiu.NesterenkoVV.Sprint2.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 50;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, wait);

        }
        [TestMethod]
        public void Valid2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void Valid3()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 64;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void Valid4()
        {
            DataService ds = new DataService();
            double x = -12;
            double wait = 20736.25;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, wait);
        }
    }
}
