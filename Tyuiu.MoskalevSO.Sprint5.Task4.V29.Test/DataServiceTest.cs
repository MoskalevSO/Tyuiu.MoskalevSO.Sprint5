using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint5.Task4.V29.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "3");

            double res = ds.LoadFromDataFile(path);
            double wait = 0.912;
            Assert.AreEqual(wait, res);
        }
    }
}