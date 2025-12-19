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
                // 4. РАЗБИВАЕМ СТРОКУ ПО ЗАПЯТЫМ
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
    }
}
