using Tyuiu.ShmidtAA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.ShmidtAA.Sprint2.Task6.V13.Test
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
            Assert.AreEqual("02.01.2024", ds.FindDateOfNextDay(year, month, day));
            Assert.AreEqual("02.10.2024", ds.FindDateOfNextDay(year, 10, 1));
            Assert.AreEqual("01.10.2024", ds.FindDateOfNextDay(year, 9, 30));

            
            Assert.AreEqual("02.01.2024", ds.FindDateOfNextDay(year, 1, 1));

        
            Assert.AreEqual("02.10.2024", ds.FindDateOfNextDay(year, 10, 1));

          
            Assert.AreEqual("01.10.2024", ds.FindDateOfNextDay(year, 9, 30));

          
            Assert.AreEqual("01.01.2025", ds.FindDateOfNextDay(year, 12, 31));

          
            Assert.AreEqual("29.02.2024", ds.FindDateOfNextDay(year, 2, 28));

           
            Assert.AreEqual("01.03.2024", ds.FindDateOfNextDay(year, 2, 29));
        }
    }
}