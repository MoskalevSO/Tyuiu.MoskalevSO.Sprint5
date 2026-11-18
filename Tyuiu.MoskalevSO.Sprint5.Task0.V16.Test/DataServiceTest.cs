using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint5.Task0.V16.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            Assert.AreEqual(true, File.Exists(path));
            Assert.AreEqual(Math.Round(17 / Math.Sqrt(7), 3).ToString(), File.ReadAllText(path));
        }
    }
}