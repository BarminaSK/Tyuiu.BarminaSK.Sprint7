namespace Tyuiu.BarminaSK.Sprint7.Project.V13
{
    partial class FormChart_BSK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonClose_BSK = new Button();
            chartCountries_BSK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelChart_BSK = new Label();
            ((System.ComponentModel.ISupportInitialize)chartCountries_BSK).BeginInit();
            SuspendLayout();
            // 
            // buttonClose_BSK
            // 
            buttonClose_BSK.BackColor = Color.LightCoral;
            buttonClose_BSK.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            buttonClose_BSK.FlatAppearance.BorderSize = 2;
            buttonClose_BSK.FlatStyle = FlatStyle.Flat;
            buttonClose_BSK.Location = new Point(452, 503);
            buttonClose_BSK.Name = "buttonClose_BSK";
            buttonClose_BSK.Size = new Size(123, 35);
            buttonClose_BSK.TabIndex = 5;
            buttonClose_BSK.Text = "Закрыть";
            buttonClose_BSK.UseVisualStyleBackColor = false;
            buttonClose_BSK.Click += buttonClose_BSK_Click;
            // 
            // chartCountries_BSK
            // 
            chartArea1.Name = "ChartArea1";
            chartCountries_BSK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCountries_BSK.Legends.Add(legend1);
            chartCountries_BSK.Location = new Point(25, 54);
            chartCountries_BSK.Name = "chartCountries_BSK";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCountries_BSK.Series.Add(series1);
            chartCountries_BSK.Size = new Size(550, 432);
            chartCountries_BSK.TabIndex = 6;
            chartCountries_BSK.Text = "chart1";
            // 
            // labelChart_BSK
            // 
            labelChart_BSK.AutoSize = true;
            labelChart_BSK.Location = new Point(167, 19);
            labelChart_BSK.Name = "labelChart_BSK";
            labelChart_BSK.Size = new Size(226, 23);
            labelChart_BSK.TabIndex = 7;
            labelChart_BSK.Text = "Топ-7 стран по населению:";
            // 
            // FormChart_BSK
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 556);
            Controls.Add(labelChart_BSK);
            Controls.Add(chartCountries_BSK);
            Controls.Add(buttonClose_BSK);
            Font = new Font("Segoe UI", 9.7F);
            Name = "FormChart_BSK";
            Text = "График населения стран";
            ((System.ComponentModel.ISupportInitialize)chartCountries_BSK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonClose_BSK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountries_BSK;
        private Label labelChart_BSK;
    }
}