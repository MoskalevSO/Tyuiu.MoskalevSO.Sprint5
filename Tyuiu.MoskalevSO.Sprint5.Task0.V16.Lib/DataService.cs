namespace Tyuiu.MoskalevSO.Sprint5.Task0.V16.Lib
{
    public class DataService : ISprint5Task0V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            double y = (2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2);
            y = Math.Round(y, 3);

            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
} 