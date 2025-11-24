using Tyuiu.Kazhahmetov.Sprint6.Task0.V10.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(37.56, res);
        }
    }
}
