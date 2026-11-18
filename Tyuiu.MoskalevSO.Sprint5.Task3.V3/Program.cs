using Tyuiu.MoskalevSO.Sprint5.Task3.V3.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ");
            Console.WriteLine("x = " + x);

            Console.WriteLine("РЕЗУЛЬТАТ");
            string path = ds.SaveToFileTextData(x);
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                Console.WriteLine(reader.ReadDouble());
            }
            Console.WriteLine("Файл: " + path);
        }
    }
}