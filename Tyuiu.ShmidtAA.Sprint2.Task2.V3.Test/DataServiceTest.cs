using Tyuiu.ShmidtAA.Sprint2.Task2.V3.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 13;
            int y = 13;

            DataService ds = new DataService();

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}