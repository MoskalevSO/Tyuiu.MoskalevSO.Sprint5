using Tyuiu.MoskalevSO.Sprint5.Task7.V30.Lib;

DataService ds = new DataService();
string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V30.txt");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Файл: " + path);
Console.WriteLine(File.ReadAllText(path));
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
string pathSave = ds.LoadDataAndSave(path);
Console.WriteLine("Файл OutPutDataFileTask7V30.txt сохранён: " + pathSave);
Console.WriteLine(File.ReadAllText(pathSave));
Console.WriteLine("***************************************************************************");
Console.ReadKey();