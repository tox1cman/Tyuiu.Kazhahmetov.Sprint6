using Tyuiu.Kazhahmetov.Sprint6.Task3.V23.Lib;
namespace Tyuiu.Kazhahmetov.Sprint6.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { 
                                {0, -19, 25, 34,  0 },
                                {-19, -16, 1, -5, 32},
                                {1, 13, -5, -17,  -5},
                                {3, -9, -15, -1,   0},
                                {1, 20, 15, -5,   31} };

            int[,] wait_matrix = new int[5, 5] { 
                                {0, -19, 25, 34,  0 },
                                {-19, -16, 1, -5, 32},
                                {1, -9, -5, -17,  -5},
                                {3, 13, -15, -1,   0},
                                {1, 20, 15, -5,   31} };

            int[,] res_matrix = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait_matrix, res_matrix);
        }
    }
}
