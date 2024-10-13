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
            int year = 2024;
            int month = 1;
            int day = 1;
            Assert.AreEqual("31.12.2023", ds.FindDateOfPreviousDay(year, month, day));
            Assert.AreEqual("27.01.2023", ds.FindDateOfPreviousDay(2023, 1, 28));
            Assert.AreEqual("09.01.2023", ds.FindDateOfPreviousDay(2023, 1, 10));
            Assert.AreEqual("27.02.2023", ds.FindDateOfPreviousDay(2023, 2, 28));
            Assert.AreEqual("09.02.2023", ds.FindDateOfPreviousDay(2023, 2, 10));
            Assert.AreEqual("27.03.2023", ds.FindDateOfPreviousDay(2023, 3, 28));
            Assert.AreEqual("27.04.2023", ds.FindDateOfPreviousDay(2023, 4, 28));
            Assert.AreEqual("27.05.2023", ds.FindDateOfPreviousDay(2023, 5, 28));
            Assert.AreEqual("27.06.2023", ds.FindDateOfPreviousDay(2023, 6, 28));
            Assert.AreEqual("27.07.2023", ds.FindDateOfPreviousDay(2023, 7, 28));
            Assert.AreEqual("27.08.2023", ds.FindDateOfPreviousDay(2023, 8, 28));
            Assert.AreEqual("27.09.2023", ds.FindDateOfPreviousDay(2023, 9, 28));
            Assert.AreEqual("27.10.2023", ds.FindDateOfPreviousDay(2023, 10, 28));
            Assert.AreEqual("27.11.2023", ds.FindDateOfPreviousDay(2023, 11, 28));
            Assert.AreEqual("27.12.2023", ds.FindDateOfPreviousDay(2023, 12, 28));

            

        }


    }
}