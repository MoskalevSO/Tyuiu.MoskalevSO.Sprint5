using Tyuiu.MoskalevSO.Sprint5.Task1.V2.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ");
            Console.WriteLine("Диапазон: [" + startValue + "; " + stopValue + "], шаг 1");

            Console.WriteLine("РЕЗУЛЬТАТ");
            string path = ds.SaveToFileTextData(startValue, stopValue);
            string[] lines = File.ReadAllLines(path);

            Console.WriteLine("+-------+----------+");
            Console.WriteLine("|   x   |   F(x)   |");
            Console.WriteLine("+-------+----------+");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("| {0,5} | {1,8} |", startValue + i, lines[i]);
            }
            Console.WriteLine("+-------+----------+");
            Console.WriteLine("Файл: " + path);
        }
    }
}