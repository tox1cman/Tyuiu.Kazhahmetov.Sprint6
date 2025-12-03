using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.Kazhahmetov.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader read = new StreamReader(path))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    if (line.Contains(" "))
                    {
                        line.Split(" ");
                        foreach (string part in line.Split())
                        {
                            if (part.Contains("z"))
                            { 
                                res += part + " ";
                            }
                        }
                    }
                }
            }
            return res.TrimEnd();
        }
    }
}
