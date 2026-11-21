using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint5.Task6.V23.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V23.txt");
            File.WriteAllText(path, "a-b - c--d");

            int res = ds.LoadFromDataFile(path);

            Assert.AreEqual(4, res);
        }
    }
}