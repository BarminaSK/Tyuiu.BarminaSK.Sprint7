using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BarminaSK.Sprint7.Project.V13.Lib;

namespace Tyuiu.BarminaSK.Sprint7.Project.V13
{
    public partial class FormEditCountry_BSK : Form
    {
        public string CountryName => textBoxName_BSK.Text;
        public string Capital => textBoxCapital_BSK.Text;
        public double Area => double.Parse(textBoxArea_BSK.Text);
        public bool IsDeveloped => checkBoxIsDeveloped_BSK.Checked;
        public long Population => long.Parse(textBoxPopulation_BSK.Text);
        public string Nationality => textBoxNationality_BSK.Text;
        public string Note => textBoxNote_BSK.Text;

        public FormEditCountry_BSK(Country_BSK countryToEdit)
        {
            InitializeComponent();
            FillFormWithData(countryToEdit);
        }

        private void FillFormWithData(Country_BSK country)
        {
            textBoxName_BSK.Text = country.Name;
            textBoxCapital_BSK.Text = country.Capital;
            textBoxArea_BSK.Text = country.Area.ToString();
            textBoxPopulation_BSK.Text = country.Population.ToString();
            textBoxNationality_BSK.Text = country.MainNationality;
            textBoxNote_BSK.Text = country.Note;
            checkBoxIsDeveloped_BSK.Checked = country.IsDeveloped;
        }

        private void buttonSave_BSK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName_BSK.Text))
            {
                MessageBox.Show("Введите название страны", "Ошибка");
                textBoxName_BSK.Focus();
                return;
            }

            if (ContainsDigits(textBoxName_BSK.Text))
            {
                MessageBox.Show("Название страны не должно содержать цифр", "Ошибка");
                textBoxName_BSK.Focus();
                textBoxName_BSK.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxCapital_BSK.Text))
            {
                MessageBox.Show("Введите столицу", "Ошибка");
                textBoxCapital_BSK.Focus();
                return;
            }

            if (ContainsDigits(textBoxCapital_BSK.Text))
            {
                MessageBox.Show("Название столицы не должно содержать цифр", "Ошибка");
                textBoxCapital_BSK.Focus();
                textBoxCapital_BSK.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxArea_BSK.Text))
            {
                MessageBox.Show("Введите площадь", "Ошибка");
                textBoxArea_BSK.Focus();
                return;
            }

            if (!double.TryParse(textBoxArea_BSK.Text, out double area))
            {
                MessageBox.Show("Площадь должна быть числом!\nНапример: 17100000 или 12345.67",
                               "Ошибка ввода площади");
                textBoxArea_BSK.Focus();
                textBoxArea_BSK.SelectAll(); // Выделяем текст для исправления
                return;
            }

            if (area <= 0)
            {
                MessageBox.Show("Площадь должна быть больше 0", "Ошибка");
                textBoxArea_BSK.Focus();
                textBoxArea_BSK.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPopulation_BSK.Text))
            {
                MessageBox.Show("Введите население", "Ошибка");
                textBoxPopulation_BSK.Focus();
                return;
            }

            if (!long.TryParse(textBoxPopulation_BSK.Text, out long population))
            {
                MessageBox.Show("Население должно быть целым числом!\nНапример: 146000000",
                               "Ошибка ввода населения");
                textBoxPopulation_BSK.Focus();
                textBoxPopulation_BSK.SelectAll();
                return;
            }

            if (population <= 0)
            {
                MessageBox.Show("Население должно быть больше 0", "Ошибка");
                textBoxPopulation_BSK.Focus();
                textBoxPopulation_BSK.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNationality_BSK.Text))
            {
                MessageBox.Show("Введите название национальности", "Ошибка");
                textBoxNationality_BSK.Focus();
                return;
            }

            if (ContainsDigits(textBoxNationality_BSK.Text))
            {
                MessageBox.Show("Название национальности не должно содержать цифр", "Ошибка");
                textBoxNationality_BSK.Focus();
                textBoxNationality_BSK.SelectAll();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_BSK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        private bool ContainsDigits(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
