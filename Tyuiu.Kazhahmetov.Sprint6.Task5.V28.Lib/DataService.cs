using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.Kazhahmetov.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] data = new double[len];
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        line = line.Replace(",", ".");
                        data[index] = Math.Round(Convert.ToDouble(line), 3);
                    }
                    else
                    {
                        data[index] = Convert.ToInt32(line);
                    }
                    index++;
                }
            }

            data = data.Where(x => x < 10).ToArray();
            return data;
        }
    }
}
