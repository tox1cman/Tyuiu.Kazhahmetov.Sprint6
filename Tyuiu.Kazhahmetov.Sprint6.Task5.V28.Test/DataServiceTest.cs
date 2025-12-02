using Tyuiu.Kazhahmetov.Sprint6.Task5.V28.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\\DataSprint6\InPutDataFileTask5V28.txt";
            DataService ds = new DataService();
            double[] wait = new double[] {-17, 0, -14.32, 5, -7.84, -1.57, -3.64, -13.26, -8.91, -17.77, -9, 8.86, 0, -1.49, -7 };
            CollectionAssert.AreEqual(wait, ds.LoadFromDataFile(path));

        }
    }
}
