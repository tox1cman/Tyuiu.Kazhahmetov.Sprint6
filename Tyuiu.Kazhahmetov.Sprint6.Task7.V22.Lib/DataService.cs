using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.Kazhahmetov.Sprint6.Task7.V22.Lib
{
    public class DataService : ISprint6Task7V22
    {
        int rows;
        int columns;

        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';'); 
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            int xCol = 5;

            for (int r = 0; r < rows; r++)
            {
                for (int c = xCol;  c <= xCol; c++)
                {
                    if (arrayValues[r,c] > 0 && arrayValues[r,c] % 2 == 0)
                    {
                        arrayValues[r, c] = 111;
                    }
                }
            }

            return arrayValues;
        }
    }
}
