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
    }
}
