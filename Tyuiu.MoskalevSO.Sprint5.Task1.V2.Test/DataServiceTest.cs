using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint5.Task1.V2.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            Assert.AreEqual(true, File.Exists(path));
            Assert.AreEqual(11, File.ReadAllLines(path).Length);
            Assert.AreEqual("-32,26", File.ReadAllLines(path)[0]);
        }
    }
}