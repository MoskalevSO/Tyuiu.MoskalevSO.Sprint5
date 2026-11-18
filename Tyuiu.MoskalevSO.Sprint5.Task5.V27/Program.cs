using Tyuiu.MoskalevSO.Sprint5.Task5.V27.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task5.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask5V27.txt");

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ");
            Console.WriteLine("Файл: " + path);
            Console.WriteLine(File.ReadAllText(path));

            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(ds.LoadFromDataFile(path));
        }
    }
}