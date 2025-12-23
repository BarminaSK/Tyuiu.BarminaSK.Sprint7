namespace Tyuiu.BarminaSK.Sprint7.Project.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStripMain_BSK = new MenuStrip();
            ToolStripMenuItemFile_BSK = new ToolStripMenuItem();
            ToolStripMenuItemOpen_BSK = new ToolStripMenuItem();
            ToolStripMenuItemSave_BSK = new ToolStripMenuItem();
            ToolStripMenuItemExit_BSK = new ToolStripMenuItem();
            ToolStripMenuItemEditing_BSK = new ToolStripMenuItem();
            ToolStripMenuItemAdd_BSK = new ToolStripMenuItem();
            ToolStripMenuItemDelete_BSK = new ToolStripMenuItem();
            ToolStripMenuItemEdit_BSK = new ToolStripMenuItem();
            ToolStripMenuItemView_BSK = new ToolStripMenuItem();
            ToolStripMenuItemStatistic_BSK = new ToolStripMenuItem();
            ToolStripMenuItemChart_BSK = new ToolStripMenuItem();
            ToolStripMenuItemHelp_BSK = new ToolStripMenuItem();
            ToolStripMenuItemAboutProgram_BSK = new ToolStripMenuItem();
            ToolStripMenuItemManual_BSK = new ToolStripMenuItem();
            panelStatus_BSK = new Panel();
            statusStripMain_BSK = new StatusStrip();
            panelToolBar_BSK = new Panel();
            buttonStatistic_BSK = new Button();
            buttonShowChart_BSK = new Button();
            buttonEditCountry_BSK = new Button();
            buttonDeleteCountry_BSK = new Button();
            buttonAddCountry_BSK = new Button();
            buttonSaveFile_BSK = new Button();
            buttonOpenFile_BSK = new Button();
            buttonSearch_BSK = new Button();
            toolTipMain_BSK = new ToolTip(components);
            panelInstruments_BSK = new Panel();
            textBoxSearch_BSK = new TextBox();
            labelSearch_BSK = new Label();
            labelIsDeveloped_BSK = new Label();
            textBoxPopTo_BSK = new TextBox();
            labelPopTo_BSK = new Label();
            labelPopFrom_BSK = new Label();
            buttonResetFilter_BSK = new Button();
            buttonApplyFilter_BSK = new Button();
            comboBoxIsDeveloped_BSK = new ComboBox();
            textBoxPopFrom_BSK = new TextBox();
            panelCountries_BSK = new Panel();
            splitContainer1 = new SplitContainer();
            groupBoxCountries_BSK = new GroupBox();
            dataGridViewCountries_BSK = new DataGridView();
            groupBoxStatistics_BSK = new GroupBox();
            textBoxMinArea_BSK = new TextBox();
            textBoxMaxArea_BSK = new TextBox();
            textBoxAvgArea_BSK = new TextBox();
            textBoxMinPopulation_BSK = new TextBox();
            textBoxMaxPopulation_BSK = new TextBox();
            textBoxTotalPopulation_BSK = new TextBox();
            textBoxCount_BSK = new TextBox();
            labelMaxArea_BSK = new Label();
            labelMinPopulation_BSK = new Label();
            labelMinArea_BSK = new Label();
            labelMaxPopulation_BSK = new Label();
            labelAvgArea_BSK = new Label();
            labelTotalPopulation_BSK = new Label();
            labelCount_BSK = new Label();
            menuStripMain_BSK.SuspendLayout();
            panelStatus_BSK.SuspendLayout();
            panelToolBar_BSK.SuspendLayout();
            panelInstruments_BSK.SuspendLayout();
            panelCountries_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxCountries_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries_BSK).BeginInit();
            groupBoxStatistics_BSK.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain_BSK
            // 
            menuStripMain_BSK.ImageScalingSize = new Size(20, 20);
            menuStripMain_BSK.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemFile_BSK, ToolStripMenuItemEditing_BSK, ToolStripMenuItemView_BSK, ToolStripMenuItemHelp_BSK });
            menuStripMain_BSK.Location = new Point(0, 0);
            menuStripMain_BSK.Name = "menuStripMain_BSK";
            menuStripMain_BSK.Size = new Size(1118, 31);
            menuStripMain_BSK.TabIndex = 0;
            menuStripMain_BSK.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile_BSK
            // 
            ToolStripMenuItemFile_BSK.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemOpen_BSK, ToolStripMenuItemSave_BSK, ToolStripMenuItemExit_BSK });
            ToolStripMenuItemFile_BSK.Font = new Font("Segoe UI", 9.7F);
            ToolStripMenuItemFile_BSK.Name = "ToolStripMenuItemFile_BSK";
            ToolStripMenuItemFile_BSK.Size = new Size(64, 27);
            ToolStripMenuItemFile_BSK.Text = "Файл";
            // 
            // ToolStripMenuItemOpen_BSK
            // 
            ToolStripMenuItemOpen_BSK.Name = "ToolStripMenuItemOpen_BSK";
            ToolStripMenuItemOpen_BSK.Size = new Size(178, 28);
            ToolStripMenuItemOpen_BSK.Text = "Открыть";
            ToolStripMenuItemOpen_BSK.Click += ToolStripMenuItemOpen_BSK_Click;
            // 
            // ToolStripMenuItemSave_BSK
            // 
            ToolStripMenuItemSave_BSK.Name = "ToolStripMenuItemSave_BSK";
            ToolStripMenuItemSave_BSK.Size = new Size(178, 28);
            ToolStripMenuItemSave_BSK.Text = "Сохранить";
            ToolStripMenuItemSave_BSK.Click += ToolStripMenuItemSave_BSK_Click;
            // 
            // ToolStripMenuItemExit_BSK
            // 
            ToolStripMenuItemExit_BSK.Name = "ToolStripMenuItemExit_BSK";
            ToolStripMenuItemExit_BSK.Size = new Size(178, 28);
            ToolStripMenuItemExit_BSK.Text = "Выход";
            ToolStripMenuItemExit_BSK.Click += ToolStripMenuItemExit_BSK_Click;
            // 
            // ToolStripMenuItemEditing_BSK
            // 
            ToolStripMenuItemEditing_BSK.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAdd_BSK, ToolStripMenuItemDelete_BSK, ToolStripMenuItemEdit_BSK });
            ToolStripMenuItemEditing_BSK.Font = new Font("Segoe UI", 9.7F);
            ToolStripMenuItemEditing_BSK.Name = "ToolStripMenuItemEditing_BSK";
            ToolStripMenuItemEditing_BSK.Size = new Size(153, 27);
            ToolStripMenuItemEditing_BSK.Text = "Редактирование";
            // 
            // ToolStripMenuItemAdd_BSK
            // 
            ToolStripMenuItemAdd_BSK.Name = "ToolStripMenuItemAdd_BSK";
            ToolStripMenuItemAdd_BSK.Size = new Size(172, 28);
            ToolStripMenuItemAdd_BSK.Text = "Добавить";
            ToolStripMenuItemAdd_BSK.Click += ToolStripMenuItemAdd_BSK_Click;
            // 
            // ToolStripMenuItemDelete_BSK
            // 
            ToolStripMenuItemDelete_BSK.Name = "ToolStripMenuItemDelete_BSK";
            ToolStripMenuItemDelete_BSK.Size = new Size(172, 28);
            ToolStripMenuItemDelete_BSK.Text = "Удалить";
            ToolStripMenuItemDelete_BSK.Click += ToolStripMenuItemDelete_BSK_Click;
            // 
            // ToolStripMenuItemEdit_BSK
            // 
            ToolStripMenuItemEdit_BSK.Name = "ToolStripMenuItemEdit_BSK";
            ToolStripMenuItemEdit_BSK.Size = new Size(172, 28);
            ToolStripMenuItemEdit_BSK.Text = "Изменить";
            ToolStripMenuItemEdit_BSK.Click += ToolStripMenuItemEdit_BSK_Click;
            // 
            // ToolStripMenuItemView_BSK
            // 
            ToolStripMenuItemView_BSK.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemStatistic_BSK, ToolStripMenuItemChart_BSK });
            ToolStripMenuItemView_BSK.Font = new Font("Segoe UI", 9.7F);
            ToolStripMenuItemView_BSK.Name = "ToolStripMenuItemView_BSK";
            ToolStripMenuItemView_BSK.Size = new Size(53, 27);
            ToolStripMenuItemView_BSK.Text = "Вид";
            // 
            // ToolStripMenuItemStatistic_BSK
            // 
            ToolStripMenuItemStatistic_BSK.Name = "ToolStripMenuItemStatistic_BSK";
            ToolStripMenuItemStatistic_BSK.Size = new Size(180, 28);
            ToolStripMenuItemStatistic_BSK.Text = "Статистика";
            ToolStripMenuItemStatistic_BSK.Click += ToolStripMenuItemStatistic_BSK_Click;
            // 
            // ToolStripMenuItemChart_BSK
            // 
            ToolStripMenuItemChart_BSK.Name = "ToolStripMenuItemChart_BSK";
            ToolStripMenuItemChart_BSK.Size = new Size(180, 28);
            ToolStripMenuItemChart_BSK.Text = "График";
            ToolStripMenuItemChart_BSK.Click += ToolStripMenuItemChart_BSK_Click;
            // 
            // ToolStripMenuItemHelp_BSK
            // 
            ToolStripMenuItemHelp_BSK.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAboutProgram_BSK, ToolStripMenuItemManual_BSK });
            ToolStripMenuItemHelp_BSK.Font = new Font("Segoe UI", 9.7F);
            ToolStripMenuItemHelp_BSK.Name = "ToolStripMenuItemHelp_BSK";
            ToolStripMenuItemHelp_BSK.Size = new Size(90, 27);
            ToolStripMenuItemHelp_BSK.Text = "Справка";
            // 
            // ToolStripMenuItemAboutProgram_BSK
            // 
            ToolStripMenuItemAboutProgram_BSK.Name = "ToolStripMenuItemAboutProgram_BSK";
            ToolStripMenuItemAboutProgram_BSK.Size = new Size(224, 28);
            ToolStripMenuItemAboutProgram_BSK.Text = "О программе";
            ToolStripMenuItemAboutProgram_BSK.Click += ToolStripMenuItemAboutProgram_BSK_Click;
            // 
            // ToolStripMenuItemManual_BSK
            // 
            ToolStripMenuItemManual_BSK.Name = "ToolStripMenuItemManual_BSK";
            ToolStripMenuItemManual_BSK.Size = new Size(224, 28);
            ToolStripMenuItemManual_BSK.Text = "Руководство";
            ToolStripMenuItemManual_BSK.Click += ToolStripMenuItemManual_BSK_Click;
            // 
            // panelStatus_BSK
            // 
            panelStatus_BSK.Controls.Add(statusStripMain_BSK);
            panelStatus_BSK.Dock = DockStyle.Bottom;
            panelStatus_BSK.Location = new Point(0, 763);
            panelStatus_BSK.Name = "panelStatus_BSK";
            panelStatus_BSK.Size = new Size(1118, 22);
            panelStatus_BSK.TabIndex = 0;
            // 
            // statusStripMain_BSK
            // 
            statusStripMain_BSK.ImageScalingSize = new Size(20, 20);
            statusStripMain_BSK.Location = new Point(0, 0);
            statusStripMain_BSK.Name = "statusStripMain_BSK";
            statusStripMain_BSK.Size = new Size(1118, 22);
            statusStripMain_BSK.TabIndex = 0;
            statusStripMain_BSK.Text = "statusStrip1";
            // 
            // panelToolBar_BSK
            // 
            panelToolBar_BSK.AutoSize = true;
            panelToolBar_BSK.Controls.Add(buttonStatistic_BSK);
            panelToolBar_BSK.Controls.Add(buttonShowChart_BSK);
            panelToolBar_BSK.Controls.Add(buttonEditCountry_BSK);
            panelToolBar_BSK.Controls.Add(buttonDeleteCountry_BSK);
            panelToolBar_BSK.Controls.Add(buttonAddCountry_BSK);
            panelToolBar_BSK.Controls.Add(buttonSaveFile_BSK);
            panelToolBar_BSK.Controls.Add(buttonOpenFile_BSK);
            panelToolBar_BSK.Dock = DockStyle.Top;
            panelToolBar_BSK.Location = new Point(0, 31);
            panelToolBar_BSK.Name = "panelToolBar_BSK";
            panelToolBar_BSK.Size = new Size(1118, 83);
            panelToolBar_BSK.TabIndex = 4;
            // 
            // buttonStatistic_BSK
            // 
            buttonStatistic_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStatistic_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonStatistic_BSK.FlatAppearance.BorderSize = 2;
            buttonStatistic_BSK.FlatStyle = FlatStyle.Flat;
            buttonStatistic_BSK.Image = Properties.Resources.Statistic;
            buttonStatistic_BSK.Location = new Point(1028, 6);
            buttonStatistic_BSK.Name = "buttonStatistic_BSK";
            buttonStatistic_BSK.Size = new Size(78, 74);
            buttonStatistic_BSK.TabIndex = 7;
            buttonStatistic_BSK.UseVisualStyleBackColor = true;
            buttonStatistic_BSK.Click += buttonStatistic_BSK_Click;
            // 
            // buttonShowChart_BSK
            // 
            buttonShowChart_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonShowChart_BSK.FlatAppearance.BorderSize = 2;
            buttonShowChart_BSK.FlatStyle = FlatStyle.Flat;
            buttonShowChart_BSK.Image = Properties.Resources.Chart;
            buttonShowChart_BSK.Location = new Point(943, 6);
            buttonShowChart_BSK.Name = "buttonShowChart_BSK";
            buttonShowChart_BSK.Size = new Size(79, 74);
            buttonShowChart_BSK.TabIndex = 5;
            toolTipMain_BSK.SetToolTip(buttonShowChart_BSK, "Построить график");
            buttonShowChart_BSK.UseVisualStyleBackColor = true;
            buttonShowChart_BSK.Click += buttonShowChart_BSK_Click;
            // 
            // buttonEditCountry_BSK
            // 
            buttonEditCountry_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonEditCountry_BSK.FlatAppearance.BorderSize = 2;
            buttonEditCountry_BSK.FlatStyle = FlatStyle.Flat;
            buttonEditCountry_BSK.Image = Properties.Resources.Edit;
            buttonEditCountry_BSK.Location = new Point(355, 3);
            buttonEditCountry_BSK.Name = "buttonEditCountry_BSK";
            buttonEditCountry_BSK.Size = new Size(79, 74);
            buttonEditCountry_BSK.TabIndex = 4;
            toolTipMain_BSK.SetToolTip(buttonEditCountry_BSK, "Редактировать выбранную страну");
            buttonEditCountry_BSK.UseVisualStyleBackColor = true;
            buttonEditCountry_BSK.Click += buttonEditCountry_BSK_Click;
            // 
            // buttonDeleteCountry_BSK
            // 
            buttonDeleteCountry_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonDeleteCountry_BSK.FlatAppearance.BorderSize = 2;
            buttonDeleteCountry_BSK.FlatStyle = FlatStyle.Flat;
            buttonDeleteCountry_BSK.Image = Properties.Resources.Delete;
            buttonDeleteCountry_BSK.Location = new Point(270, 3);
            buttonDeleteCountry_BSK.Name = "buttonDeleteCountry_BSK";
            buttonDeleteCountry_BSK.Size = new Size(79, 74);
            buttonDeleteCountry_BSK.TabIndex = 3;
            toolTipMain_BSK.SetToolTip(buttonDeleteCountry_BSK, "Удалить выбранную страну");
            buttonDeleteCountry_BSK.UseVisualStyleBackColor = true;
            buttonDeleteCountry_BSK.Click += buttonDeleteCountry_BSK_Click;
            // 
            // buttonAddCountry_BSK
            // 
            buttonAddCountry_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonAddCountry_BSK.FlatAppearance.BorderSize = 2;
            buttonAddCountry_BSK.FlatStyle = FlatStyle.Flat;
            buttonAddCountry_BSK.Image = Properties.Resources.Add;
            buttonAddCountry_BSK.Location = new Point(185, 3);
            buttonAddCountry_BSK.Name = "buttonAddCountry_BSK";
            buttonAddCountry_BSK.Size = new Size(79, 74);
            buttonAddCountry_BSK.TabIndex = 2;
            toolTipMain_BSK.SetToolTip(buttonAddCountry_BSK, "Добавить новую страну");
            buttonAddCountry_BSK.UseVisualStyleBackColor = true;
            buttonAddCountry_BSK.Click += buttonAddCountry_BSK_Click;
            // 
            // buttonSaveFile_BSK
            // 
            buttonSaveFile_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonSaveFile_BSK.FlatAppearance.BorderSize = 2;
            buttonSaveFile_BSK.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_BSK.Image = Properties.Resources.Save;
            buttonSaveFile_BSK.Location = new Point(97, 3);
            buttonSaveFile_BSK.Name = "buttonSaveFile_BSK";
            buttonSaveFile_BSK.Size = new Size(82, 74);
            buttonSaveFile_BSK.TabIndex = 1;
            toolTipMain_BSK.SetToolTip(buttonSaveFile_BSK, "Сохранить данные в CSV-файл");
            buttonSaveFile_BSK.UseVisualStyleBackColor = true;
            buttonSaveFile_BSK.Click += buttonSaveFile_BSK_Click;
            // 
            // buttonOpenFile_BSK
            // 
            buttonOpenFile_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonOpenFile_BSK.FlatAppearance.BorderSize = 2;
            buttonOpenFile_BSK.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_BSK.Image = Properties.Resources.Open2;
            buttonOpenFile_BSK.Location = new Point(12, 3);
            buttonOpenFile_BSK.Name = "buttonOpenFile_BSK";
            buttonOpenFile_BSK.Size = new Size(79, 74);
            buttonOpenFile_BSK.TabIndex = 0;
            toolTipMain_BSK.SetToolTip(buttonOpenFile_BSK, "Загрузить данные из CSV-файла");
            buttonOpenFile_BSK.UseVisualStyleBackColor = true;
            buttonOpenFile_BSK.Click += buttonOpenFile_BSK_Click;
            // 
            // buttonSearch_BSK
            // 
            buttonSearch_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonSearch_BSK.FlatAppearance.BorderSize = 2;
            buttonSearch_BSK.FlatStyle = FlatStyle.Flat;
            buttonSearch_BSK.Image = Properties.Resources.Search;
            buttonSearch_BSK.Location = new Point(1028, 9);
            buttonSearch_BSK.Name = "buttonSearch_BSK";
            buttonSearch_BSK.Size = new Size(78, 74);
            buttonSearch_BSK.TabIndex = 6;
            buttonSearch_BSK.UseVisualStyleBackColor = true;
            buttonSearch_BSK.Click += buttonSearch_BSK_Click_1;
            // 
            // toolTipMain_BSK
            // 
            toolTipMain_BSK.IsBalloon = true;
            toolTipMain_BSK.ToolTipIcon = ToolTipIcon.Info;
            // 
            // panelInstruments_BSK
            // 
            panelInstruments_BSK.Controls.Add(textBoxSearch_BSK);
            panelInstruments_BSK.Controls.Add(labelSearch_BSK);
            panelInstruments_BSK.Controls.Add(labelIsDeveloped_BSK);
            panelInstruments_BSK.Controls.Add(buttonSearch_BSK);
            panelInstruments_BSK.Controls.Add(textBoxPopTo_BSK);
            panelInstruments_BSK.Controls.Add(labelPopTo_BSK);
            panelInstruments_BSK.Controls.Add(labelPopFrom_BSK);
            panelInstruments_BSK.Controls.Add(buttonResetFilter_BSK);
            panelInstruments_BSK.Controls.Add(buttonApplyFilter_BSK);
            panelInstruments_BSK.Controls.Add(comboBoxIsDeveloped_BSK);
            panelInstruments_BSK.Controls.Add(textBoxPopFrom_BSK);
            panelInstruments_BSK.Dock = DockStyle.Top;
            panelInstruments_BSK.Location = new Point(0, 114);
            panelInstruments_BSK.Name = "panelInstruments_BSK";
            panelInstruments_BSK.Size = new Size(1118, 104);
            panelInstruments_BSK.TabIndex = 5;
            // 
            // textBoxSearch_BSK
            // 
            textBoxSearch_BSK.Location = new Point(773, 54);
            textBoxSearch_BSK.Name = "textBoxSearch_BSK";
            textBoxSearch_BSK.Size = new Size(217, 29);
            textBoxSearch_BSK.TabIndex = 9;
            // 
            // labelSearch_BSK
            // 
            labelSearch_BSK.AutoSize = true;
            labelSearch_BSK.Font = new Font("Segoe UI", 9.7F);
            labelSearch_BSK.Location = new Point(773, 17);
            labelSearch_BSK.Name = "labelSearch_BSK";
            labelSearch_BSK.Size = new Size(217, 23);
            labelSearch_BSK.TabIndex = 8;
            labelSearch_BSK.Text = "Введите название страны:";
            // 
            // labelIsDeveloped_BSK
            // 
            labelIsDeveloped_BSK.AutoSize = true;
            labelIsDeveloped_BSK.Font = new Font("Segoe UI", 9.7F);
            labelIsDeveloped_BSK.Location = new Point(297, 20);
            labelIsDeveloped_BSK.Name = "labelIsDeveloped_BSK";
            labelIsDeveloped_BSK.Size = new Size(101, 23);
            labelIsDeveloped_BSK.TabIndex = 7;
            labelIsDeveloped_BSK.Text = "Развитость:";
            // 
            // textBoxPopTo_BSK
            // 
            textBoxPopTo_BSK.Location = new Point(151, 62);
            textBoxPopTo_BSK.Name = "textBoxPopTo_BSK";
            textBoxPopTo_BSK.Size = new Size(125, 29);
            textBoxPopTo_BSK.TabIndex = 6;
            // 
            // labelPopTo_BSK
            // 
            labelPopTo_BSK.AutoSize = true;
            labelPopTo_BSK.Font = new Font("Segoe UI", 9.7F);
            labelPopTo_BSK.Location = new Point(10, 65);
            labelPopTo_BSK.Name = "labelPopTo_BSK";
            labelPopTo_BSK.Size = new Size(123, 23);
            labelPopTo_BSK.TabIndex = 5;
            labelPopTo_BSK.Text = "Население до:";
            // 
            // labelPopFrom_BSK
            // 
            labelPopFrom_BSK.AutoSize = true;
            labelPopFrom_BSK.Font = new Font("Segoe UI", 9.7F);
            labelPopFrom_BSK.Location = new Point(12, 20);
            labelPopFrom_BSK.Name = "labelPopFrom_BSK";
            labelPopFrom_BSK.Size = new Size(121, 23);
            labelPopFrom_BSK.TabIndex = 4;
            labelPopFrom_BSK.Text = "Население от:";
            // 
            // buttonResetFilter_BSK
            // 
            buttonResetFilter_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonResetFilter_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonResetFilter_BSK.FlatAppearance.BorderSize = 2;
            buttonResetFilter_BSK.FlatStyle = FlatStyle.Flat;
            buttonResetFilter_BSK.Font = new Font("Segoe UI", 9.7F);
            buttonResetFilter_BSK.Location = new Point(562, 57);
            buttonResetFilter_BSK.Name = "buttonResetFilter_BSK";
            buttonResetFilter_BSK.Size = new Size(176, 42);
            buttonResetFilter_BSK.TabIndex = 3;
            buttonResetFilter_BSK.Text = "Сбросить фильтр";
            buttonResetFilter_BSK.UseVisualStyleBackColor = true;
            buttonResetFilter_BSK.Click += buttonResetFilter_BSK_Click;
            // 
            // buttonApplyFilter_BSK
            // 
            buttonApplyFilter_BSK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonApplyFilter_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonApplyFilter_BSK.FlatAppearance.BorderSize = 2;
            buttonApplyFilter_BSK.FlatStyle = FlatStyle.Flat;
            buttonApplyFilter_BSK.Font = new Font("Segoe UI", 9.7F);
            buttonApplyFilter_BSK.Location = new Point(562, 9);
            buttonApplyFilter_BSK.Name = "buttonApplyFilter_BSK";
            buttonApplyFilter_BSK.Size = new Size(176, 42);
            buttonApplyFilter_BSK.TabIndex = 2;
            buttonApplyFilter_BSK.Text = "Применить фильтр";
            buttonApplyFilter_BSK.UseVisualStyleBackColor = true;
            buttonApplyFilter_BSK.Click += buttonApplyFilter_BSK_Click;
            // 
            // comboBoxIsDeveloped_BSK
            // 
            comboBoxIsDeveloped_BSK.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIsDeveloped_BSK.FormattingEnabled = true;
            comboBoxIsDeveloped_BSK.Items.AddRange(new object[] { "Все страны", "Развитые", "Неразвитые" });
            comboBoxIsDeveloped_BSK.Location = new Point(419, 17);
            comboBoxIsDeveloped_BSK.Name = "comboBoxIsDeveloped_BSK";
            comboBoxIsDeveloped_BSK.Size = new Size(109, 29);
            comboBoxIsDeveloped_BSK.TabIndex = 1;
            // 
            // textBoxPopFrom_BSK
            // 
            textBoxPopFrom_BSK.Location = new Point(151, 17);
            textBoxPopFrom_BSK.Name = "textBoxPopFrom_BSK";
            textBoxPopFrom_BSK.Size = new Size(125, 29);
            textBoxPopFrom_BSK.TabIndex = 0;
            // 
            // panelCountries_BSK
            // 
            panelCountries_BSK.Controls.Add(splitContainer1);
            panelCountries_BSK.Dock = DockStyle.Fill;
            panelCountries_BSK.Location = new Point(0, 218);
            panelCountries_BSK.Name = "panelCountries_BSK";
            panelCountries_BSK.Size = new Size(1118, 545);
            panelCountries_BSK.TabIndex = 6;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxCountries_BSK);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxStatistics_BSK);
            splitContainer1.Size = new Size(1118, 545);
            splitContainer1.SplitterDistance = 783;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxCountries_BSK
            // 
            groupBoxCountries_BSK.Controls.Add(dataGridViewCountries_BSK);
            groupBoxCountries_BSK.Dock = DockStyle.Fill;
            groupBoxCountries_BSK.Font = new Font("Segoe UI", 9.7F);
            groupBoxCountries_BSK.Location = new Point(0, 0);
            groupBoxCountries_BSK.Name = "groupBoxCountries_BSK";
            groupBoxCountries_BSK.Size = new Size(783, 545);
            groupBoxCountries_BSK.TabIndex = 0;
            groupBoxCountries_BSK.TabStop = false;
            groupBoxCountries_BSK.Text = "Страны ";
            // 
            // dataGridViewCountries_BSK
            // 
            dataGridViewCountries_BSK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountries_BSK.Dock = DockStyle.Fill;
            dataGridViewCountries_BSK.Location = new Point(3, 25);
            dataGridViewCountries_BSK.MultiSelect = false;
            dataGridViewCountries_BSK.Name = "dataGridViewCountries_BSK";
            dataGridViewCountries_BSK.RowHeadersVisible = false;
            dataGridViewCountries_BSK.RowHeadersWidth = 51;
            dataGridViewCountries_BSK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCountries_BSK.Size = new Size(777, 517);
            dataGridViewCountries_BSK.TabIndex = 0;
            dataGridViewCountries_BSK.CellContentClick += dataGridViewCountries_BSK_CellContentClick;
            // 
            // groupBoxStatistics_BSK
            // 
            groupBoxStatistics_BSK.Controls.Add(textBoxMinArea_BSK);
            groupBoxStatistics_BSK.Controls.Add(textBoxMaxArea_BSK);
            groupBoxStatistics_BSK.Controls.Add(textBoxAvgArea_BSK);
            groupBoxStatistics_BSK.Controls.Add(textBoxMinPopulation_BSK);
            groupBoxStatistics_BSK.Controls.Add(textBoxMaxPopulation_BSK);
            groupBoxStatistics_BSK.Controls.Add(textBoxTotalPopulation_BSK);
            groupBoxStatistics_BSK.Controls.Add(textBoxCount_BSK);
            groupBoxStatistics_BSK.Controls.Add(labelMaxArea_BSK);
            groupBoxStatistics_BSK.Controls.Add(labelMinPopulation_BSK);
            groupBoxStatistics_BSK.Controls.Add(labelMinArea_BSK);
            groupBoxStatistics_BSK.Controls.Add(labelMaxPopulation_BSK);
            groupBoxStatistics_BSK.Controls.Add(labelAvgArea_BSK);
            groupBoxStatistics_BSK.Controls.Add(labelTotalPopulation_BSK);
            groupBoxStatistics_BSK.Controls.Add(labelCount_BSK);
            groupBoxStatistics_BSK.Dock = DockStyle.Fill;
            groupBoxStatistics_BSK.Font = new Font("Segoe UI", 9.7F);
            groupBoxStatistics_BSK.Location = new Point(0, 0);
            groupBoxStatistics_BSK.Name = "groupBoxStatistics_BSK";
            groupBoxStatistics_BSK.Size = new Size(331, 545);
            groupBoxStatistics_BSK.TabIndex = 0;
            groupBoxStatistics_BSK.TabStop = false;
            groupBoxStatistics_BSK.Text = "Статистика";
            // 
            // textBoxMinArea_BSK
            // 
            textBoxMinArea_BSK.Location = new Point(197, 342);
            textBoxMinArea_BSK.Name = "textBoxMinArea_BSK";
            textBoxMinArea_BSK.Size = new Size(125, 29);
            textBoxMinArea_BSK.TabIndex = 13;
            // 
            // textBoxMaxArea_BSK
            // 
            textBoxMaxArea_BSK.Location = new Point(197, 295);
            textBoxMaxArea_BSK.Name = "textBoxMaxArea_BSK";
            textBoxMaxArea_BSK.Size = new Size(125, 29);
            textBoxMaxArea_BSK.TabIndex = 12;
            // 
            // textBoxAvgArea_BSK
            // 
            textBoxAvgArea_BSK.Location = new Point(197, 244);
            textBoxAvgArea_BSK.Name = "textBoxAvgArea_BSK";
            textBoxAvgArea_BSK.Size = new Size(125, 29);
            textBoxAvgArea_BSK.TabIndex = 11;
            // 
            // textBoxMinPopulation_BSK
            // 
            textBoxMinPopulation_BSK.Location = new Point(197, 194);
            textBoxMinPopulation_BSK.Name = "textBoxMinPopulation_BSK";
            textBoxMinPopulation_BSK.Size = new Size(125, 29);
            textBoxMinPopulation_BSK.TabIndex = 10;
            // 
            // textBoxMaxPopulation_BSK
            // 
            textBoxMaxPopulation_BSK.Location = new Point(197, 145);
            textBoxMaxPopulation_BSK.Name = "textBoxMaxPopulation_BSK";
            textBoxMaxPopulation_BSK.Size = new Size(125, 29);
            textBoxMaxPopulation_BSK.TabIndex = 9;
            // 
            // textBoxTotalPopulation_BSK
            // 
            textBoxTotalPopulation_BSK.Location = new Point(197, 92);
            textBoxTotalPopulation_BSK.Name = "textBoxTotalPopulation_BSK";
            textBoxTotalPopulation_BSK.Size = new Size(125, 29);
            textBoxTotalPopulation_BSK.TabIndex = 8;
            // 
            // textBoxCount_BSK
            // 
            textBoxCount_BSK.Location = new Point(197, 38);
            textBoxCount_BSK.Name = "textBoxCount_BSK";
            textBoxCount_BSK.Size = new Size(125, 29);
            textBoxCount_BSK.TabIndex = 7;
            // 
            // labelMaxArea_BSK
            // 
            labelMaxArea_BSK.AutoSize = true;
            labelMaxArea_BSK.Location = new Point(25, 298);
            labelMaxArea_BSK.Name = "labelMaxArea_BSK";
            labelMaxArea_BSK.Size = new Size(133, 23);
            labelMaxArea_BSK.TabIndex = 6;
            labelMaxArea_BSK.Text = "Макс. площадь:";
            // 
            // labelMinPopulation_BSK
            // 
            labelMinPopulation_BSK.AutoSize = true;
            labelMinPopulation_BSK.Location = new Point(25, 197);
            labelMinPopulation_BSK.Name = "labelMinPopulation_BSK";
            labelMinPopulation_BSK.Size = new Size(141, 23);
            labelMinPopulation_BSK.TabIndex = 5;
            labelMinPopulation_BSK.Text = "Мин. население:";
            // 
            // labelMinArea_BSK
            // 
            labelMinArea_BSK.AutoSize = true;
            labelMinArea_BSK.Location = new Point(25, 345);
            labelMinArea_BSK.Name = "labelMinArea_BSK";
            labelMinArea_BSK.Size = new Size(128, 23);
            labelMinArea_BSK.TabIndex = 4;
            labelMinArea_BSK.Text = "Мин. площадь:";
            // 
            // labelMaxPopulation_BSK
            // 
            labelMaxPopulation_BSK.AutoSize = true;
            labelMaxPopulation_BSK.Location = new Point(25, 148);
            labelMaxPopulation_BSK.Name = "labelMaxPopulation_BSK";
            labelMaxPopulation_BSK.Size = new Size(146, 23);
            labelMaxPopulation_BSK.TabIndex = 3;
            labelMaxPopulation_BSK.Text = "Макс. население:";
            // 
            // labelAvgArea_BSK
            // 
            labelAvgArea_BSK.AutoSize = true;
            labelAvgArea_BSK.Location = new Point(25, 247);
            labelAvgArea_BSK.Name = "labelAvgArea_BSK";
            labelAvgArea_BSK.Size = new Size(156, 23);
            labelAvgArea_BSK.TabIndex = 2;
            labelAvgArea_BSK.Text = "Средняя площадь:";
            labelAvgArea_BSK.Click += labelAvgArea_BSK_Click;
            // 
            // labelTotalPopulation_BSK
            // 
            labelTotalPopulation_BSK.AutoSize = true;
            labelTotalPopulation_BSK.Location = new Point(25, 95);
            labelTotalPopulation_BSK.Name = "labelTotalPopulation_BSK";
            labelTotalPopulation_BSK.Size = new Size(154, 23);
            labelTotalPopulation_BSK.TabIndex = 1;
            labelTotalPopulation_BSK.Text = "Сумма населения:";
            // 
            // labelCount_BSK
            // 
            labelCount_BSK.AutoSize = true;
            labelCount_BSK.Font = new Font("Segoe UI", 9.7F);
            labelCount_BSK.Location = new Point(25, 41);
            labelCount_BSK.Name = "labelCount_BSK";
            labelCount_BSK.Size = new Size(155, 23);
            labelCount_BSK.TabIndex = 0;
            labelCount_BSK.Text = "Количество стран:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 785);
            Controls.Add(panelCountries_BSK);
            Controls.Add(panelInstruments_BSK);
            Controls.Add(panelToolBar_BSK);
            Controls.Add(panelStatus_BSK);
            Controls.Add(menuStripMain_BSK);
            MainMenuStrip = menuStripMain_BSK;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "География стран";
            Load += Form1_Load;
            menuStripMain_BSK.ResumeLayout(false);
            menuStripMain_BSK.PerformLayout();
            panelStatus_BSK.ResumeLayout(false);
            panelStatus_BSK.PerformLayout();
            panelToolBar_BSK.ResumeLayout(false);
            panelInstruments_BSK.ResumeLayout(false);
            panelInstruments_BSK.PerformLayout();
            panelCountries_BSK.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxCountries_BSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries_BSK).EndInit();
            groupBoxStatistics_BSK.ResumeLayout(false);
            groupBoxStatistics_BSK.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain_BSK;
        private ToolStripMenuItem ToolStripMenuItemFile_BSK;
        private ToolStripMenuItem ToolStripMenuItemOpen_BSK;
        private ToolStripMenuItem ToolStripMenuItemSave_BSK;
        private ToolStripMenuItem ToolStripMenuItemExit_BSK;
        private ToolStripMenuItem ToolStripMenuItemEditing_BSK;
        private ToolStripMenuItem ToolStripMenuItemAdd_BSK;
        private ToolStripMenuItem ToolStripMenuItemDelete_BSK;
        private ToolStripMenuItem ToolStripMenuItemEdit_BSK;
        private ToolStripMenuItem ToolStripMenuItemView_BSK;
        private ToolStripMenuItem ToolStripMenuItemStatistic_BSK;
        private ToolStripMenuItem ToolStripMenuItemChart_BSK;
        private ToolStripMenuItem ToolStripMenuItemResetFilters_BSK;
        private ToolStripMenuItem ToolStripMenuItemHelp_BSK;
        private ToolStripMenuItem ToolStripMenuItemAboutProgram_BSK;
        private ToolStripMenuItem ToolStripMenuItemManual_BSK;
        private Panel panelStatus_BSK;
        private Panel panelToolBar_BSK;
        private Button buttonShowChart_BSK;
        private Button buttonEditCountry_BSK;
        private Button buttonDeleteCountry_BSK;
        private Button buttonAddCountry_BSK;
        private Button buttonSaveFile_BSK;
        private Button buttonOpenFile_BSK;
        private ToolTip toolTipMain_BSK;
        private Button buttonSearch_BSK;
        private Button buttonStatistic_BSK;
        private Panel panelInstruments_BSK;
        private Panel panelCountries_BSK;
        private SplitContainer splitContainer1;
        private DataGridView dataGridViewCountries_BSK;
        private GroupBox groupBoxCountries_BSK;
        private GroupBox groupBoxStatistics_BSK;
        private Button buttonApplyFilter_BSK;
        private ComboBox comboBoxIsDeveloped_BSK;
        private TextBox textBoxPopFrom_BSK;
        private Button buttonResetFilter_BSK;
        private Label labelAvgArea_BSK;
        private Label labelTotalPopulation_BSK;
        private Label labelCount_BSK;
        private Label labelMinArea_BSK;
        private Label labelMaxPopulation_BSK;
        private StatusStrip statusStripMain_BSK;
        private Label labelMaxArea_BSK;
        private Label labelMinPopulation_BSK;
        private TextBox textBoxMinArea_BSK;
        private TextBox textBoxMaxArea_BSK;
        private TextBox textBoxAvgArea_BSK;
        private TextBox textBoxMinPopulation_BSK;
        private TextBox textBoxMaxPopulation_BSK;
        private TextBox textBoxTotalPopulation_BSK;
        private TextBox textBoxCount_BSK;
        private TextBox textBoxPopTo_BSK;
        private Label labelPopTo_BSK;
        private Label labelPopFrom_BSK;
        private Label labelIsDeveloped_BSK;
        private TextBox textBoxSearch_BSK;
        private Label labelSearch_BSK;
    }
}
