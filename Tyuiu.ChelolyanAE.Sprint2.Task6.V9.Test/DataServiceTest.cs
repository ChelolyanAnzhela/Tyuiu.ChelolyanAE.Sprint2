using Tyuiu.ChelolyanAE.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ChelolyanAE.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay1()
        {
            DataService ds = new DataService();
            int m = 2;
            int n = 28;
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "1.3";
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidFindDateOfNextDay2()
        {
            DataService ds = new DataService();
            int m = 7;
            int n = 14;
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "15.7";
            Assert.AreEqual(wait, res);
        }
    }
}