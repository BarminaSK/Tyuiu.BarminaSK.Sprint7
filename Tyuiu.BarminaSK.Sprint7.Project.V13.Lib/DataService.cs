using System;
using System.Collections.Generic;
using System.IO;

namespace Tyuiu.BarminaSK.Sprint7.Project.V13.Lib
{
    public class Country_BSK
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }
        public bool IsDeveloped { get; set; }
        public long Population { get; set; }
        public string MainNationality { get; set; }
        public string Note { get; set; }

        public Country_BSK() { }

        public Country_BSK(string name, string capital, double area,
                          bool isDeveloped, long population,
                          string mainNationality, string note)
        {
            Name = name;
            Capital = capital;
            Area = area;
            IsDeveloped = isDeveloped;
            Population = population;
            MainNationality = mainNationality;
            Note = note;
        }
    }

    public class DataService_BSK
    {
        public List<Country_BSK> LoadFromCsvFile(string FilePath)
        {
            List<Country_BSK> countries = new List<Country_BSK>();

            string[] allLines = File.ReadAllLines(FilePath);

            for (int i = 1; i < allLines.Length; i++)
            {
                string[] columns = allLines[i].Split(',');

                Country_BSK country = new Country_BSK();

                country.Name = columns[0];
                country.Capital = columns[1];
                country.Area = double.Parse(columns[2]);
                country.IsDeveloped = bool.Parse(columns[3]);
                country.Population = long.Parse(columns[4]);
                country.MainNationality = columns[5];
                country.Note = columns[6];

                countries.Add(country);
            }
            return countries;
        }
        public void SaveToCsvFile(List<Country_BSK> countries, string filePath)
        {
            List<string> lines = new List<string>();

            lines.Add("Name,Capital,Area,IsDeveloped,Population,MainNationality,Note");

            foreach (Country_BSK country in countries)
            {
                string line = $"{country.Name},{country.Capital},{country.Area}," +
                             $"{country.IsDeveloped},{country.Population}," +
                             $"{country.MainNationality},{country.Note}";

                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }
        public int GetCount(List<Country_BSK> countries)
        {
            return countries.Count;
        }
        public long GetTotalPopulation(List<Country_BSK> countries)
        {
            long total = 0;

            foreach (Country_BSK country in countries)
            {
                total += country.Population;
            }

            return total;
        }
        public double GetAverageArea(List<Country_BSK> countries)
        {
            if (countries.Count == 0)
                return 0;

            double sum = 0;

            foreach (Country_BSK country in countries)
            {
                sum += country.Area;
            }

            return sum / countries.Count;
        }
        public double GetMaxArea(List<Country_BSK> countries)
        {
            if (countries.Count == 0)
                return 0;

            double max = double.MinValue;

            foreach (Country_BSK country in countries)
            {
                if (country.Area > max)
                {
                    max = country.Area;
                }
            }

            return max;
        }
        public double GetMinArea(List<Country_BSK> countries)
        {
            if (countries.Count == 0)
                return 0;

            double min = double.MaxValue;  // Самое большое возможное число

            foreach (Country_BSK country in countries)
            {
                if (country.Area < min)
                {
                    min = country.Area;
                }
            }

            return min;
        }
        public long GetMaxPopulation(List<Country_BSK> countries)
        {
            if (countries.Count == 0) return 0;

            long max = countries[0].Population;
            foreach (var country in countries)
            {
                if (country.Population > max)
                    max = country.Population;
            }
            return max;
        }
        public long GetMinPopulation(List<Country_BSK> countries)
        {
            if (countries.Count == 0) return 0;

            long min = countries[0].Population;
            foreach (var country in countries)
            {
                if (country.Population < min)
                    min = country.Population;
            }
            return min;
        }
        public List<Country_BSK> SearchByName(List<Country_BSK> countries, string searchText)
        {
            List<Country_BSK> result = new List<Country_BSK>();

            foreach (Country_BSK country in countries)
            {
                if (country.Name != null &&
                    country.Name.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(country);
                }
            }

            return result;
        }
        public List<Country_BSK> FilterByDeveloped(List<Country_BSK> countries, bool isDeveloped)
        {
            List<Country_BSK> result = new List<Country_BSK>();

            foreach (Country_BSK country in countries)
            {
                if (country.IsDeveloped == isDeveloped)
                {
                    result.Add(country);
                }
            }

            return result;
        }
        public List<Country_BSK> FilterByPopulationRange(List<Country_BSK> countries,
                                                long minPopulation,
                                                long maxPopulation)
        {
            List<Country_BSK> result = new List<Country_BSK>();

            foreach (Country_BSK country in countries)
            {
                if (country.Population >= minPopulation &&
                    country.Population <= maxPopulation)
                {
                    result.Add(country);
                }
            }

            return result;
        }
        public List<Country_BSK> SortBy(List<Country_BSK> countries, string sortBy, bool ascending = true)
        {
            List<Country_BSK> sortedList = new List<Country_BSK>(countries);

            switch (sortBy.ToLower())
            {
                case "name":
                    if (ascending)
                        sortedList.Sort((a, b) => string.Compare(a.Name, b.Name));
                    else
                        sortedList.Sort((a, b) => string.Compare(b.Name, a.Name));
                    break;
            }

            return sortedList;
        }
        public List<Country_BSK> GetChartData(List<Country_BSK> countries, int topCount = 10)
        {
            List<Country_BSK> sorted = SortBy(countries, "population", false);

            return sorted.Take(topCount).ToList();
        }
    }
}
