using NutritionCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySection
{
    public partial class AdminDashboard : Form
    {

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void MealCreatedText_Click(object sender, EventArgs e)
        {

        }

        private void DuplicateMealText_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            String temp = NameTextBox.Text;
            bool tempBool = false;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == ' ')
                {
                    tempBool = true;
                }
            }
            NoSpacesText.Visible = tempBool;
        }

        private void CalorieAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateMealButton_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\GlobalCategories\" + CategoryBox.SelectedItem.ToString() + ".txt";

            string[] lines = File.ReadAllLines(path);
            bool duplicate = false;
            for(int i = 0; i < lines.Length; i++)
            {
                if(lines[i].Contains(NameTextBox.Text) == true)
                {
                    MessageBox.Show("Food already exists");
                    duplicate = true;
                    break;
                }
            }

            if(duplicate == false)
            {
                string[] linesNew = new string[lines.Length + 1];
                for(int i = 0; i < lines.Length; i++)
                {
                    linesNew[i] = lines[i];
                }
                linesNew[linesNew.Length - 1] = NameTextBox.Text + ":" + CalorieAmountTextBox.Text;

                File.WriteAllLines(path, linesNew);

                MessageBox.Show("Meal Created!");
            }

        } 

        private void CancelMealButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
