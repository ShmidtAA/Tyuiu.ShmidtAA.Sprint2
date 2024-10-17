using Tyuiu.ShmidtAA.Sprint2.Task7.V9.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool wait = true;
           const double PI = 3.1415926535897931;
            double x = PI/6;
            double y = 0.3;

            Assert.AreEqual(wait,ds.CheckDotInShadedArea(x,y));


        }
    }
}