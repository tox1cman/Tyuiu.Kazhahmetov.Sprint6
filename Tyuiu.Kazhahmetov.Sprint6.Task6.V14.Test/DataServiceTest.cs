using Tyuiu.Kazhahmetov.Sprint6.Task6.V14.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V14.txt";
            string wait = "GzTsc AucHJjziZ jiUFMDjMsEervIz ziwVyU";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
