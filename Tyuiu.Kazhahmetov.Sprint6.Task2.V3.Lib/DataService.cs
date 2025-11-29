using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.Kazhahmetov.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double y;
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            int cnt = 0;
            for (int i = startValue; i < stopValue + 1; i++)
            {
                y = ((Math.Sin(i))/ (i + 1.2)) + (Math.Cos(i) * 7 * i) - 2;
                y = Math.Round(y, 2);
                res[cnt] = y;
                cnt++;
            }
            return res;
        }
    }
}
