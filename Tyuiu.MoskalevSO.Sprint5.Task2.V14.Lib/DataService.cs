using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MoskalevSO.Sprint5.Task2.V14.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }

                    str += matrix[i, j];
                    if (j != columns - 1)
                    {
                        str += ";";
                    }
                }
                if (i != rows - 1)
                {
                    str += Environment.NewLine;
                }
                File.AppendAllText(path, str);
            }
            return path;
        }
    }
}