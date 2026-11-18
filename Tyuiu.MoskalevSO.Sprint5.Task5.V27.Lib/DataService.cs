using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MoskalevSO.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] items = text.Split(new char[] { '\n', '\r', ' ', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            int count = 0;
            foreach (string item in items)
            {
                if (int.TryParse(item.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out int number))
                {
                    if (number % 5 == 0)
                    {
                        sum += number;
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                return 0;
            }
            return Math.Round(sum / count, 3);
        }
    }
}