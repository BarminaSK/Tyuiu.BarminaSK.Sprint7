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
            groupBoxTop_BSK = new GroupBox();
            groupBoxMiddle_BSK = new GroupBox();
            groupBoxFill_BSK = new GroupBox();
            buttonOpen_BSK = new Button();
            buttonSave_BSK = new Button();
            buttonHelp_BSK = new Button();
            buttonEdit_BSK = new Button();
            dataGridViewInfo_BSK = new DataGridView();
            groupBoxTop_BSK.SuspendLayout();
            groupBoxMiddle_BSK.SuspendLayout();
            groupBoxFill_BSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_BSK).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTop_BSK
            // 
            groupBoxTop_BSK.Controls.Add(buttonHelp_BSK);
            groupBoxTop_BSK.Controls.Add(buttonSave_BSK);
            groupBoxTop_BSK.Controls.Add(buttonOpen_BSK);
            groupBoxTop_BSK.Dock = DockStyle.Top;
            groupBoxTop_BSK.Location = new Point(0, 0);
            groupBoxTop_BSK.Name = "groupBoxTop_BSK";
            groupBoxTop_BSK.Size = new Size(1017, 125);
            groupBoxTop_BSK.TabIndex = 0;
            groupBoxTop_BSK.TabStop = false;
            groupBoxTop_BSK.Text = "Работа с файлом";
            // 
            // groupBoxMiddle_BSK
            // 
            groupBoxMiddle_BSK.Controls.Add(buttonEdit_BSK);
            groupBoxMiddle_BSK.Dock = DockStyle.Top;
            groupBoxMiddle_BSK.Location = new Point(0, 125);
            groupBoxMiddle_BSK.Name = "groupBoxMiddle_BSK";
            groupBoxMiddle_BSK.Size = new Size(1017, 125);
            groupBoxMiddle_BSK.TabIndex = 1;
            groupBoxMiddle_BSK.TabStop = false;
            groupBoxMiddle_BSK.Text = "Работа с данными";
            // 
            // groupBoxFill_BSK
            // 
            groupBoxFill_BSK.Controls.Add(dataGridViewInfo_BSK);
            groupBoxFill_BSK.Dock = DockStyle.Fill;
            groupBoxFill_BSK.Location = new Point(0, 250);
            groupBoxFill_BSK.Name = "groupBoxFill_BSK";
            groupBoxFill_BSK.Size = new Size(1017, 476);
            groupBoxFill_BSK.TabIndex = 2;
            groupBoxFill_BSK.TabStop = false;
            groupBoxFill_BSK.Text = "Вывод";
            // 
            // buttonOpen_BSK
            // 
            buttonOpen_BSK.Image = Properties.Resources.folder_page_white;
            buttonOpen_BSK.Location = new Point(24, 37);
            buttonOpen_BSK.Name = "buttonOpen_BSK";
            buttonOpen_BSK.Size = new Size(82, 68);
            buttonOpen_BSK.TabIndex = 0;
            buttonOpen_BSK.UseVisualStyleBackColor = true;
            // 
            // buttonSave_BSK
            // 
            buttonSave_BSK.Image = Properties.Resources.page_save;
            buttonSave_BSK.Location = new Point(122, 37);
            buttonSave_BSK.Name = "buttonSave_BSK";
            buttonSave_BSK.Size = new Size(82, 68);
            buttonSave_BSK.TabIndex = 1;
            buttonSave_BSK.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_BSK
            // 
            buttonHelp_BSK.Image = Properties.Resources.information;
            buttonHelp_BSK.Location = new Point(920, 37);
            buttonHelp_BSK.Name = "buttonHelp_BSK";
            buttonHelp_BSK.Size = new Size(73, 68);
            buttonHelp_BSK.TabIndex = 2;
            buttonHelp_BSK.UseVisualStyleBackColor = true;
            // 
            // buttonEdit_BSK
            // 
            buttonEdit_BSK.Location = new Point(24, 52);
            buttonEdit_BSK.Name = "buttonEdit_BSK";
            buttonEdit_BSK.Size = new Size(94, 29);
            buttonEdit_BSK.TabIndex = 0;
            buttonEdit_BSK.Text = "Добавить";
            buttonEdit_BSK.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInfo_BSK
            // 
            dataGridViewInfo_BSK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo_BSK.Dock = DockStyle.Fill;
            dataGridViewInfo_BSK.Location = new Point(3, 25);
            dataGridViewInfo_BSK.Name = "dataGridViewInfo_BSK";
            dataGridViewInfo_BSK.RowHeadersWidth = 51;
            dataGridViewInfo_BSK.Size = new Size(1011, 448);
            dataGridViewInfo_BSK.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 726);
            Controls.Add(groupBoxFill_BSK);
            Controls.Add(groupBoxMiddle_BSK);
            Controls.Add(groupBoxTop_BSK);
            Name = "FormMain";
            Text = "Спринт 7 | Проект | Вариант 13 | Бармина С.К. ";
            Load += Form1_Load;
            groupBoxTop_BSK.ResumeLayout(false);
            groupBoxMiddle_BSK.ResumeLayout(false);
            groupBoxFill_BSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_BSK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTop_BSK;
        private GroupBox groupBoxMiddle_BSK;
        private GroupBox groupBoxFill_BSK;
        private Button buttonHelp_BSK;
        private Button buttonSave_BSK;
        private Button buttonOpen_BSK;
        private Button buttonEdit_BSK;
        private DataGridView dataGridViewInfo_BSK;
    }
}
