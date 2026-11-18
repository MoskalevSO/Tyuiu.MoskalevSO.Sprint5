using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint5.Task5.V27.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "5\n10\n3\n20\n2,5");

            double res = ds.LoadFromDataFile(path);
            double wait = 11.667;
            Assert.AreEqual(wait, res);
        }
    }
}