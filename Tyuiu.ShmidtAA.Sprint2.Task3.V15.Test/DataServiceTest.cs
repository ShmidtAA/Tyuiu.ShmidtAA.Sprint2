using Tyuiu.ShmidtAA.Sprint2.Task3.V15.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 2;

            DataService ds = new DataService();

            double res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double x = 0;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double x = 1;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            double wait = 256;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double x = -20;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            double wait = -219.95 ;
            Assert.AreEqual(wait, res);
        }
    }
}