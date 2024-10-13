using System.Net.Http.Headers;
using Tyuiu.ShmidtAA.Sprint2.Task5.V10.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            

            for (int i=1; i<=12; i++)
            {
                Assert.AreEqual($"27.{i}.2023",ds.FindDateOfPreviousDay(2023, i,28));

            }

        }


    }
}