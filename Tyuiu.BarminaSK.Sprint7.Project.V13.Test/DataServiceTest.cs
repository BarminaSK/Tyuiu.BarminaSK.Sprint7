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
        [TestMethod]
        public void ValidGetCount()
        {
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Страна1", "Столица1", 100000, true, 50000000, "Нация1", ""),
                new Country_BSK("Страна2", "Столица2", 200000, false, 70000000, "Нация2", ""),
                new Country_BSK("Страна3", "Столица3", 300000, true, 90000000, "Нация3", "")
            };

            int result = ds.GetCount(testData);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void ValidGetTotalPopulation()
        {
            DataService_BSK service = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Страна1", "Столица1", 100000, true, 10000000, "Нация1", ""),
                new Country_BSK("Страна2", "Столица2", 200000, false, 20000000, "Нация2", ""),
                new Country_BSK("Страна3", "Столица3", 300000, true, 30000000, "Нация3", "")
            };

            long result = service.GetTotalPopulation(testData);

            Assert.AreEqual(60000000, result);
        }
        [TestMethod]
        public void ValidGetAverageArea()
        {
            DataService_BSK service = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Страна1", "Столица1", 100, true, 10000000, "Нация1", ""),
                new Country_BSK("Страна2", "Столица2", 200, false, 20000000, "Нация2", ""),
                new Country_BSK("Страна3", "Столица3", 300, true, 30000000, "Нация3", "")
            };

            double result = service.GetAverageArea(testData);

            Assert.AreEqual(200, result);
        }
        [TestMethod]
        public void ValidGetMaxArea()
        {
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Страна1", "Столица1", 100, true, 10000000, "Нация1", ""),
                new Country_BSK("Страна2", "Столица2", 500, false, 20000000, "Нация2", ""),
                new Country_BSK("Страна3", "Столица3", 300, true, 30000000, "Нация3", "")
            };

            double result = ds.GetMaxArea(testData);

            Assert.AreEqual(500, result);
        }

        [TestMethod]
        public void ValidGetMinArea()
        {
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Страна1", "Столица1", 100, true, 10000000, "Нация1", ""),
                new Country_BSK("Страна2", "Столица2", 500, false, 20000000, "Нация2", ""),
                new Country_BSK("Страна3", "Столица3", 300, true, 30000000, "Нация3", "")
            };

            double result = ds.GetMinArea(testData);

            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void ValidGetMaxArea_EmptyList()
        {
            DataService_BSK ds = new DataService_BSK();
            List<Country_BSK> emptyList = new List<Country_BSK>();

            double result = ds.GetMaxArea(emptyList);

            Assert.AreEqual(0, result); 
        }

        [TestMethod]
        public void ValidGetMinArea_EmptyList()
        {
            DataService_BSK ds = new DataService_BSK();
            List<Country_BSK> emptyList = new List<Country_BSK>();

            double result = ds.GetMinArea(emptyList);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void ValidSearchByName()
        {
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Россия", "Москва", 17100000, true, 146000000, "Русские", ""),
                new Country_BSK("Германия", "Берлин", 357022, true, 83000000, "Немцы", ""),
                new Country_BSK("Франция", "Париж", 643801, true, 67000000, "Французы", ""),
                new Country_BSK("Бразилия", "Бразилиа", 8515767, false, 213000000, "Бразильцы", "")
            };

            List<Country_BSK> result = ds.SearchByName(testData, "рос");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Россия", result[0].Name);
        }
        [TestMethod]
        public void ValidFilterByDeveloped()
        {
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Россия", "Москва", 17100000, true, 146000000, "Русские", ""),
                new Country_BSK("Германия", "Берлин", 357022, true, 83000000, "Немцы", ""),
                new Country_BSK("Бразилия", "Бразилиа", 8515767, false, 213000000, "Бразильцы", "")
            };

            List<Country_BSK> result = ds.FilterByDeveloped(testData, true);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Россия", result[0].Name);
            Assert.AreEqual("Германия", result[1].Name);

            List<Country_BSK> result2 = ds.FilterByDeveloped(testData, false);

            Assert.AreEqual(1, result2.Count);
            Assert.AreEqual("Бразилия", result2[0].Name);
        }
        [TestMethod]
        public void ValidFilterByPopulationRange()
        {
            // Arrange
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Россия", "Москва", 17100000, true, 146000000, "Русские", ""),
                new Country_BSK("Германия", "Берлин", 357022, true, 83000000, "Немцы", ""),
                new Country_BSK("Франция", "Париж", 643801, true, 67000000, "Французы", "")
            };

            List<Country_BSK> result = ds.FilterByPopulationRange(testData, 70000000, 150000000);

            Assert.AreEqual(2, result.Count);

            bool hasFrance = result.Any(c => c.Name == "Франция");
            Assert.IsFalse(hasFrance);
        }
        [TestMethod]
        public void ValidSortByArea()
        {
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Страна3", "Столица3", 300, true, 30000000, "Нация3", ""),
                new Country_BSK("Страна1", "Столица1", 100, true, 10000000, "Нация1", ""),
                new Country_BSK("Страна2", "Столица2", 200, false, 20000000, "Нация2", "")
            };

            List<Country_BSK> result = ds.SortBy(testData, "area", true);

            Assert.AreEqual(100, result[0].Area);
            Assert.AreEqual(200, result[1].Area);
            Assert.AreEqual(300, result[2].Area);

            List<Country_BSK> resultDesc = ds.SortBy(testData, "area", false);

            Assert.AreEqual(300, resultDesc[0].Area);
            Assert.AreEqual(200, resultDesc[1].Area);
            Assert.AreEqual(100, resultDesc[2].Area);
        }
        [TestMethod]
        public void ValidGetChartData()
        {
            DataService_BSK ds = new DataService_BSK();

            List<Country_BSK> testData = new List<Country_BSK>
            {
                new Country_BSK("Страна1", "Столица1", 100, true, 50000000, "Нация1", ""),
                new Country_BSK("Страна2", "Столица2", 200, false, 90000000, "Нация2", ""),  // Самое большое население
                new Country_BSK("Страна3", "Столица3", 300, true, 70000000, "Нация3", "")
            };

            List<Country_BSK> result = ds.GetChartData(testData, 2);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Страна2", result[0].Name);
            Assert.AreEqual(90000000, result[0].Population);
            Assert.AreEqual("Страна3", result[1].Name);
            Assert.AreEqual(70000000, result[1].Population);
        }
    }
}
