using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.BarminaSK.Sprint7.Project.V13.Lib;
using Color = System.Drawing.Color;

namespace Tyuiu.BarminaSK.Sprint7.Project.V13
{
    public partial class FormChart_BSK : Form
    {

        private List<Country_BSK> countries;

        public FormChart_BSK(List<Country_BSK> countries)
        {
            InitializeComponent();
            this.countries = countries;

            ShowChart();
        }

        private void ShowChart()
        {
            var topCountries = countries
                .OrderByDescending(c => c.Population)
                .Take(7)
                .ToList();

            chartCountries_BSK.Series.Clear();

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            series.IsValueShownAsLabel = false;
            series["PieLabelStyle"] = "Disabled";

            foreach (var country in topCountries)
            {
                series.Points.AddXY(country.Name, country.Population);
            }

            chartCountries_BSK.Series.Add(series);
        }

        private void buttonClose_BSK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
