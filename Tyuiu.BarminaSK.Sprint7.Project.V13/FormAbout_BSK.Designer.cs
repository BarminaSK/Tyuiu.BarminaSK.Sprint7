namespace Tyuiu.BarminaSK.Sprint7.Project.V13
{
    partial class FormAbout_BSK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_BSK));
            pictureBoxPhoto_BSK = new PictureBox();
            labelDescription_BSK = new Label();
            buttonOK_BSK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_BSK).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto_BSK
            // 
            pictureBoxPhoto_BSK.Image = Properties.Resources.Photo;
            pictureBoxPhoto_BSK.Location = new Point(27, 29);
            pictureBoxPhoto_BSK.Name = "pictureBoxPhoto_BSK";
            pictureBoxPhoto_BSK.Size = new Size(185, 251);
            pictureBoxPhoto_BSK.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto_BSK.TabIndex = 0;
            pictureBoxPhoto_BSK.TabStop = false;
            // 
            // labelDescription_BSK
            // 
            labelDescription_BSK.AutoSize = true;
            labelDescription_BSK.Location = new Point(231, 29);
            labelDescription_BSK.Name = "labelDescription_BSK";
            labelDescription_BSK.Size = new Size(394, 210);
            labelDescription_BSK.TabIndex = 1;
            labelDescription_BSK.Text = resources.GetString("labelDescription_BSK.Text");
            // 
            // buttonOK_BSK
            // 
            buttonOK_BSK.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            buttonOK_BSK.FlatAppearance.BorderSize = 2;
            buttonOK_BSK.FlatStyle = FlatStyle.Flat;
            buttonOK_BSK.Location = new Point(509, 242);
            buttonOK_BSK.Name = "buttonOK_BSK";
            buttonOK_BSK.Size = new Size(116, 38);
            buttonOK_BSK.TabIndex = 2;
            buttonOK_BSK.Text = "OK";
            buttonOK_BSK.UseVisualStyleBackColor = true;
            buttonOK_BSK.Click += buttonOK_BSK_Click;
            // 
            // FormAbout_BSK
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 297);
            Controls.Add(buttonOK_BSK);
            Controls.Add(labelDescription_BSK);
            Controls.Add(pictureBoxPhoto_BSK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_BSK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_BSK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPhoto_BSK;
        private Label labelDescription_BSK;
        private Button buttonOK_BSK;
    }
}