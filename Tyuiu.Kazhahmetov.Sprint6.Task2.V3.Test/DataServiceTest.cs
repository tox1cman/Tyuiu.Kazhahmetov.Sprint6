using Tyuiu.Kazhahmetov.Sprint6.Task2.V3.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] wait = new double[len];
            wait[0] = -12.18;
            wait[1] = 16.03;
            wait[2] = 18.87;
            wait[3] = 4.96;
            wait[4] = -9.99;
            wait[5] = -2;
            wait[6] = 2.16;
            wait[7] = -7.54;
            wait[8] = -22.76;
            wait[9] = -20.45;
            wait[10] = 7.77;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
