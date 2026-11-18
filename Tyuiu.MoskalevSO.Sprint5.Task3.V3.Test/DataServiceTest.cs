using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint5.Task3.V3.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task3.V3.Test
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
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                Assert.AreEqual(7.348, reader.ReadDouble());
            }
        }
    }
}