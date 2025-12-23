using Tyuiu.BarminaSK.Sprint7.Project.V13.Lib;

namespace Tyuiu.BarminaSK.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        private DataService_BSK dataService;
        private List<Country_BSK> countries;
        private List<Country_BSK> currentDisplay;
        public FormMain()
        {
            InitializeComponent();

            dataService = new DataService_BSK();
            countries = new List<Country_BSK>();
            currentDisplay = new List<Country_BSK>();

            SetupInitialState();

        }
        private void SetupInitialState()
        {
            if (dataGridViewCountries_BSK.Columns.Count == 0)
            {
                SetupDataGridViewColumns();
            }
        }
        private void SetupDataGridViewColumns()
        {
            dataGridViewCountries_BSK.AutoGenerateColumns = false;
            dataGridViewCountries_BSK.Columns.Clear();

            dataGridViewCountries_BSK.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Страна",
                Width = 150
            });

            dataGridViewCountries_BSK.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Capital",
                HeaderText = "Столица",
                Width = 120
            });

            dataGridViewCountries_BSK.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Area",
                HeaderText = "Площадь (км²)",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "N0" }
            });

            dataGridViewCountries_BSK.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IsDeveloped",
                HeaderText = "Развитая",
                Width = 80
            });

            dataGridViewCountries_BSK.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Population",
                HeaderText = "Население",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "N0" }
            });

            dataGridViewCountries_BSK.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MainNationality",
                HeaderText = "Национальность",
                Width = 130
            });

            dataGridViewCountries_BSK.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Note",
                HeaderText = "Примечание",
                Width = 150
            });
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void buttonSearch_BSK_Click(object sender, EventArgs e)
        {

        }


        private void dataGridViewCountries_BSK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelAvgArea_BSK_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemOpen_BSK_Click(object sender, EventArgs e)
        {
            OpenFile();

        }

        private void buttonOpenFile_BSK_Click(object sender, EventArgs e)
        {
            //buttonOpenFile_BSK.ToolTipTitle = "Открыть файл";
            OpenFile();
        }
        private void OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    countries = dataService.LoadFromCsvFile(dialog.FileName);
                    dataGridViewCountries_BSK.DataSource = countries;
                    MessageBox.Show($"Загружено {countries.Count} стран", "Успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }
        }

        private void ToolStripMenuItemSave_BSK_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void buttonSaveFile_BSK_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataService.SaveToCsvFile(countries, dialog.FileName);
                    MessageBox.Show($"Сохранено {countries.Count} стран", "Успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }
        }

        private void ToolStripMenuItemExit_BSK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?",
                                         "Выход из программы",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ToolStripMenuItemAdd_BSK_Click(object sender, EventArgs e)
        {
            AddNewCountry();
        }

        private void buttonAddCountry_BSK_Click(object sender, EventArgs e)
        {
            AddNewCountry();
        }
        private void AddNewCountry()
        {
            FormAddCountry_BSK addForm = new FormAddCountry_BSK();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Country_BSK newCountry = new Country_BSK
                {
                    Name = addForm.CountryName,
                    Capital = addForm.Capital,
                    Area = addForm.Area,
                    IsDeveloped = addForm.IsDeveloped,
                    Population = addForm.Population,
                    MainNationality = addForm.MainNationality,
                    Note = addForm.Note
                };

                countries.Add(newCountry);

                dataGridViewCountries_BSK.DataSource = null;
                dataGridViewCountries_BSK.DataSource = countries;

                MessageBox.Show($"Добавлена страна: {newCountry.Name}", "Успешно");

            }
        }

        private void ToolStripMenuItemDelete_BSK_Click(object sender, EventArgs e)
        {
            DeleteCountry();
        }

        private void buttonDeleteCountry_BSK_Click(object sender, EventArgs e)
        {
            DeleteCountry();

        }

        private void DeleteCountry()
        {
            if (dataGridViewCountries_BSK.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите страну!");
                return;
            }

            var row = dataGridViewCountries_BSK.SelectedRows[0];
            var country = (Country_BSK)row.DataBoundItem;

            if (MessageBox.Show($"Удалить {country.Name}?",
                "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                countries.Remove(country);

                dataGridViewCountries_BSK.DataSource = null;
                dataGridViewCountries_BSK.DataSource = countries;

                MessageBox.Show("Удалено!");
            }
        }

        private void ToolStripMenuItemEdit_BSK_Click(object sender, EventArgs e)
        {
            EditCountry();
        }

        private void buttonEditCountry_BSK_Click(object sender, EventArgs e)
        {
            EditCountry();
        }
        private void EditCountry()
        {
            if (dataGridViewCountries_BSK.CurrentRow == null)
            {
                MessageBox.Show("Выберите страну для редактирования!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Country_BSK selectedCountry = (Country_BSK)dataGridViewCountries_BSK.CurrentRow.DataBoundItem;

            FormEditCountry_BSK editForm = new FormEditCountry_BSK(selectedCountry);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedCountry.Name = editForm.CountryName;
                    selectedCountry.Capital = editForm.Capital;
                    selectedCountry.Area = editForm.Area;
                    selectedCountry.IsDeveloped = editForm.IsDeveloped;
                    selectedCountry.Population = editForm.Population;
                    selectedCountry.MainNationality = editForm.Nationality;
                    selectedCountry.Note = editForm.Note;

                    dataGridViewCountries_BSK.Refresh();

                    MessageBox.Show($"Данные страны '{selectedCountry.Name}' обновлены!",
                        "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка в числовых данных!", "Ошибка");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
                }
            }
        }

        private void ToolStripMenuItemStatistic_BSK_Click(object sender, EventArgs e)
        {
            UpdateStatistics();
            MessageBox.Show("Статистика обновлена!");
        }

        private void buttonStatistic_BSK_Click(object sender, EventArgs e)
        {
            UpdateStatistics();
            MessageBox.Show("Статистика обновлена!");
        }
        private void UpdateStatistics()
        {
            if (countries.Count == 0)
            {
                return;
            }

            DataService_BSK service = new DataService_BSK();

            textBoxCount_BSK.Text = service.GetCount(countries).ToString();
            textBoxTotalPopulation_BSK.Text = service.GetTotalPopulation(countries).ToString("N0");
            textBoxAvgArea_BSK.Text = service.GetAverageArea(countries).ToString("N2") + " км²";
            textBoxMaxArea_BSK.Text = service.GetMaxArea(countries).ToString("N0") + " км²";
            textBoxMinArea_BSK.Text = service.GetMinArea(countries).ToString("N0") + " км²";
            textBoxMaxPopulation_BSK.Text = service.GetMaxPopulation(countries).ToString("N0");
            textBoxMinPopulation_BSK.Text = service.GetMinPopulation(countries).ToString("N0");
        }

        private void buttonApplyFilter_BSK_Click(object sender, EventArgs e)
        {
            try
            {

                string developedFilter = comboBoxIsDeveloped_BSK.Text;

                long minPopulation = 0;
                long maxPopulation = long.MaxValue;

                if (!string.IsNullOrWhiteSpace(textBoxPopFrom_BSK.Text))
                    minPopulation = long.Parse(textBoxPopFrom_BSK.Text);

                if (!string.IsNullOrWhiteSpace(textBoxPopTo_BSK.Text))
                    maxPopulation = long.Parse(textBoxPopTo_BSK.Text);

                List<Country_BSK> filteredList = countries;

                if (developedFilter == "Развитые")
                {
                    filteredList = dataService.FilterByDeveloped(filteredList, true);
                }
                else if (developedFilter == "Неразвитые")
                {
                    filteredList = dataService.FilterByDeveloped(filteredList, false);
                }

                if (minPopulation > 0 || maxPopulation < long.MaxValue)
                {
                    filteredList = dataService.FilterByPopulationRange(
                        filteredList, minPopulation, maxPopulation);
                }

                dataGridViewCountries_BSK.DataSource = null;
                dataGridViewCountries_BSK.DataSource = filteredList;

                UpdateStatisticsForFiltered(filteredList);

                if (filteredList.Count == 0)
                {
                    MessageBox.Show("Нет стран, соответствующих фильтрам", "Результат");
                }
                else
                {
                    MessageBox.Show($"Найдено {filteredList.Count} стран", "Результат фильтрации");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числа в поля населения", "Ошибка ввода");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка фильтрации");
            }
        }
        private void UpdateStatisticsForFiltered(List<Country_BSK> filteredCountries)
        {
            if (filteredCountries.Count == 0)
            {
                ClearStatistics();
                return;
            }

            DataService_BSK service = new DataService_BSK();

            textBoxCount_BSK.Text = service.GetCount(filteredCountries).ToString();
            textBoxTotalPopulation_BSK.Text = service.GetTotalPopulation(filteredCountries).ToString("N0");
            textBoxAvgArea_BSK.Text = service.GetAverageArea(filteredCountries).ToString("N2") + " км²";
            textBoxMaxArea_BSK.Text = service.GetMaxArea(filteredCountries).ToString("N0") + " км²";
            textBoxMinArea_BSK.Text = service.GetMinArea(filteredCountries).ToString("N0") + " км²";
            textBoxMaxPopulation_BSK.Text = service.GetMaxPopulation(filteredCountries).ToString("N0");
            textBoxMinPopulation_BSK.Text = service.GetMinPopulation(filteredCountries).ToString("N0");
        }

        private void ClearStatistics()
        {
            textBoxCount_BSK.Text = "0";
            textBoxTotalPopulation_BSK.Text = "0";
            textBoxAvgArea_BSK.Text = "0 км²";
            textBoxMaxArea_BSK.Text = "0 км²";
            textBoxMinArea_BSK.Text = "0 км²";
            textBoxMaxPopulation_BSK.Text = "0";
            textBoxMinPopulation_BSK.Text = "0";
        }

        private void ResetAllFilters()
        {
            comboBoxIsDeveloped_BSK.SelectedIndex = 0;
            textBoxPopFrom_BSK.Text = "";
            textBoxPopTo_BSK.Text = "";

            dataGridViewCountries_BSK.DataSource = null;
            dataGridViewCountries_BSK.DataSource = countries;

            UpdateStatistics();

            MessageBox.Show("Все фильтры сброшены. Показаны все страны.", "Сброс фильтров");
        }

        private void buttonResetFilter_BSK_Click(object sender, EventArgs e)
        {
            ResetAllFilters();
        }

        private void buttonSearch_BSK_Click_1(object sender, EventArgs e)
        {
            SearchCountries();
        }
        private void SearchCountries()
        {
            try
            {
                string searchText = textBoxSearch_BSK.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    dataGridViewCountries_BSK.DataSource = null;
                    dataGridViewCountries_BSK.DataSource = countries;
                    UpdateStatistics();
                    MessageBox.Show("Показаны все страны", "Поиск");
                    return;
                }

                List<Country_BSK> searchResult = dataService.SearchByName(countries, searchText);

                dataGridViewCountries_BSK.DataSource = null;
                dataGridViewCountries_BSK.DataSource = searchResult;

                UpdateStatisticsForFiltered(searchResult);

                if (searchResult.Count == 0)
                {
                    MessageBox.Show($"Страны с названием '{searchText}' не найдены", "Результат поиска");
                }
                else
                {
                    MessageBox.Show($"Найдено {searchResult.Count} стран по запросу '{searchText}'",
                        "Результат поиска");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}", "Ошибка");
            }
        }

        private void ToolStripMenuItemChart_BSK_Click(object sender, EventArgs e)
        {
            ShowChartForm();
        }

        private void buttonShowChart_BSK_Click(object sender, EventArgs e)
        {
            ShowChartForm();
        }
        private void ShowChartForm()
        {
            {
                if (countries == null || countries.Count == 0)
                {
                    MessageBox.Show("Загрузите данные о странах сначала!",
                        "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FormChart_BSK chartForm = new FormChart_BSK(countries);
                chartForm.Show();
            }
        }

        private void ToolStripMenuItemManual_BSK_Click(object sender, EventArgs e)
        {
            FormHelp_BSK helpForm = new FormHelp_BSK();
            helpForm.ShowDialog();
        }

        private void ToolStripMenuItemAboutProgram_BSK_Click(object sender, EventArgs e)
        {
            FormAbout_BSK aboutForm = new FormAbout_BSK();
            aboutForm.ShowDialog();
        }
    }
}
