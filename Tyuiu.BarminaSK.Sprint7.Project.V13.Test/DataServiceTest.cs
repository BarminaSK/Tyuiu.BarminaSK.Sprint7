using Tyuiu.BarminaSK.Sprint7.Project.V13.Lib;

namespace Tyuiu.BarminaSK.Sprint7.Project.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromCsvFile()
        {
            DataService_BSK ds = new DataService_BSK();

            string path = @"C:\DataSprint7\countries.csv";

            List<Country_BSK> result = ds.LoadFromCsvFile(path);

            Assert.AreEqual(10, result.Count);

            Assert.AreEqual("Россия", result[0].Name);
            Assert.AreEqual("Москва", result[0].Capital);
            Assert.AreEqual(17100000, result[0].Area);
            Assert.AreEqual(true, result[0].IsDeveloped);
            Assert.AreEqual(146000000, result[0].Population);
            Assert.AreEqual("Русские", result[0].MainNationality);
            Assert.AreEqual("Самая большая страна", result[0].Note);
        }
        [TestMethod]
        public void ValidSaveToCsvFile()
        {
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Тестовая1", "Столица1", 100000, true, 50000000, "Нация1", "Примечание1"),
                new Country_BSK("Тестовая2", "Столица2", 200000, false, 70000000, "Нация2", "Примечание2")
            };

            string testFilePath = @"test_output.csv";

            ds.SaveToCsvFile(testData, testFilePath);

            Assert.IsTrue(File.Exists(testFilePath));

            List<Country_BSK> loadedData = ds.LoadFromCsvFile(testFilePath);

            Assert.AreEqual(2, loadedData.Count);

            Assert.AreEqual("Тестовая1", loadedData[0].Name);
            Assert.AreEqual("Столица1", loadedData[0].Capital);
            Assert.AreEqual(100000, loadedData[0].Area);
            Assert.AreEqual(true, loadedData[0].IsDeveloped);
            Assert.AreEqual(50000000, loadedData[0].Population);
            Assert.AreEqual("Нация1", loadedData[0].MainNationality);
            Assert.AreEqual("Примечание1", loadedData[0].Note);

            File.Delete(testFilePath);
        }
    }
}
