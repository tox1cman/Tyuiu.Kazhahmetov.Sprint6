using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.Kazhahmetov.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length/rows;

            int[] cols2 = new int[5];
            int cnt = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 1)
                    {
                        cols2[cnt] = matrix[i,j];
                        cnt++;
                    }
                }
            }

            Array.Sort(cols2);
            cnt = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 1)
                    {
                        matrix[i, j] = cols2[cnt];
                        cnt++;
                    }
                }
            }
            return matrix;
        }
    }
}
