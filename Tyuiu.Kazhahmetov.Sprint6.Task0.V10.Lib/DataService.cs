using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.Kazhahmetov.Sprint6.Task0.V10.Lib
{
    public class DataService : ISprint6Task0V10
    {
        public double Calculate(int x)
        {
            double y = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2;
            return Math.Round(y, 3);
        }
    }
}
