using Tyuiu.BarminaSK.Sprint7.Project.V13.Lib;

namespace Tyuiu.BarminaSK.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            toolTipMain_BSK.ToolTipTitle = "Открытие файла";
            toolTipMain_BSK.SetToolTip(buttonOpenFile_BSK, "Загрузить данные из CSV-файла");

            toolTipMain_BSK.ToolTipTitle = "Сохранение";
            toolTipMain_BSK.SetToolTip(buttonSaveFile_BSK, "Сохранить изменения в файл");

            toolTipMain_BSK.ToolTipTitle = "Добавление";
            toolTipMain_BSK.SetToolTip(buttonAddCountry_BSK, "Добавить новую страну");

            toolTipMain_BSK.ToolTipTitle = "Редактирование";
            toolTipMain_BSK.SetToolTip(buttonEditCountry_BSK, "Редактировать выбранную запись");

            toolTipMain_BSK.ToolTipTitle = "Удаление";
            toolTipMain_BSK.SetToolTip(buttonDeleteCountry_BSK, "Удалить выбранную страну");

            toolTipMain_BSK.ToolTipTitle = "График";
            toolTipMain_BSK.SetToolTip(buttonShowChart_BSK, "Построить график");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonOpen_BSK_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewOutPut_BSK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSaveFile_BSK_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_BSK_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxStatistics_BSK_Enter(object sender, EventArgs e)
        {

        }
    }
}
