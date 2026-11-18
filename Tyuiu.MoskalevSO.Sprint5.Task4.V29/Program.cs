using Tyuiu.MoskalevSO.Sprint5.Task4.V29.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask4V0.txt");

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ");
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("x = " + File.ReadAllText(path));

            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine(ds.LoadFromDataFile(path));
        }
    }
}