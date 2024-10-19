using Tyuiu.ChelolyanAE.Sprint2.Task7.V1.Lib;

namespace Tyuiu.ChelolyanAE.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedARea()
        {
            DataService ds = new DataService();
            double x = -0.7;
            double y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}