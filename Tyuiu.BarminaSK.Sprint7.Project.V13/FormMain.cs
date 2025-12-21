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
                Width = 120,
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
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "N0" }
            });

            dataGridViewCountries_BSK.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MainNationality",
                HeaderText = "Национальность",
                Width = 120
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
    }
}
