using Tyuiu.MoskalevSO.Sprint5.Task6.V23.Lib;

DataService ds = new DataService();
string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V23.txt");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Файл: " + path);
Console.WriteLine(File.ReadAllText(path));
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Количество знаков тире: " + ds.LoadFromDataFile(path));
Console.WriteLine("***************************************************************************");
Console.ReadKey();