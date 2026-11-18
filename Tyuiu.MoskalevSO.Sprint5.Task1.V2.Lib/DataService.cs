namespace Tyuiu.MoskalevSO.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string strLine = "";
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;
                double result;
                if (denominator == 0)
                {
                    result = 0;
                }
                else
                {
                    result = (2 * x - 3) / denominator + 5 * x - 6;
                }
                result = Math.Round(result, 2);

                strLine = result.ToString();
                if (x != stopValue)
                {
                    strLine += Environment.NewLine;
                }
                File.AppendAllText(path, strLine);
            }
            return path;
        }
    }
}