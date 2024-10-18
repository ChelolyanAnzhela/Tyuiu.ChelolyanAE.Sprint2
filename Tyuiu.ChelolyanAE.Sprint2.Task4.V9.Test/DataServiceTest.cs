using Tyuiu.ChelolyanAE.Sprint2.Task4.V9.Lib;

namespace Tyuiu.ChelolyanAE.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCOndition1()
        {
            DataService ds = new DataService();
            double x = -3;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 129307.819;
            Assert.AreEqual(wait,res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 254.5;
            Assert.AreEqual(wait,res);
        }
    }
}