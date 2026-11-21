using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint5.Task7.V30.Lib;

namespace Tyuiu.MoskalevSO.Sprint5.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V30.txt");
            File.WriteAllText(path, "a1 b23 c4 d567 8");

            string pathSave = ds.LoadDataAndSave(path);
            string res = File.ReadAllText(pathSave);

            Assert.AreEqual("a9 b23 c9 d567 9", res);
        }
    }
}