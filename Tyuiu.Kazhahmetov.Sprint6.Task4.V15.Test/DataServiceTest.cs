using Tyuiu.Kazhahmetov.Sprint6.Task4.V15.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] doubles = new double[11] { 3.3, -12.37, -14.02, -5.57, 0.65, 0, -0.65, 5.57, 14.02, 12.37, -3.3 };
            CollectionAssert.AreEqual(doubles, ds.GetMassFunction(-5, 5));
        }
    }
}
