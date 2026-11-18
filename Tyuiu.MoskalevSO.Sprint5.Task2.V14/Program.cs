using Tyuiu.MoskalevSO.Sprint5.Task2.V14.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = { { -3, -6, -3 }, { 6, 8, 3 }, { -6, -5, 5 } };

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("РЕЗУЛЬТАТ");
            string path = ds.SaveToFileTextData(matrix);
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("Файл: " + path);
        }
    }
}