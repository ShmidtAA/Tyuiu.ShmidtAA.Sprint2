using Tyuiu.ShmidtAA.Sprint2.Task4.V11.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x =10;
            double y =4;
            double res = ds.Calculate(x, y);
            double wait = 89.992;
            Assert.AreEqual(wait,res);
        }

        [TestMethod]

        public void TestMethod2() 
        {
            DataService ds = new DataService();
            double x =70;
            double y =100;
            double res = ds.Calculate(x, y);
            double wait = 100;
            Assert.AreEqual(wait, res);
        }
    }
}