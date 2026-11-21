using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MoskalevSO.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            // однозначные числа: цифра, не являющаяся частью более длинного числа
            string result = Regex.Replace(text, @"(?<!\d)\d(?!\d)", "9");

            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V30.txt");
            File.WriteAllText(pathSave, result);

            return pathSave;
        }
    }
}