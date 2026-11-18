using Tyuiu.MoskalevSO.Sprint5.Task0.V16.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task0.V16
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
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("Файл: " + path);
        }
    }
}