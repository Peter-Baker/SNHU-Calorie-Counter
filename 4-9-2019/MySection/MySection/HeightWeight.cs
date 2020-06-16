using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutritionCalculator;
using System.Text.RegularExpressions;//Regex

namespace MySection
{
    public partial class HeightWeight : Form
    {

        private User temp;
        private String path;

        public HeightWeight() //Dont use this one
        {
            InitializeComponent();
        }

        public HeightWeight(User temp, String path)
        {
            InitializeComponent();
            this.temp = temp;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            temp.Save(@"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + temp.get_username() + ".txt", heightTextBox.Text, weightTextBox.Text);
            this.Hide();

            User newTemp = new User(@"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + temp.get_username() + ".txt");

            Dashboard dashboard = new Dashboard(newTemp, path);
            dashboard.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) //CancelButton
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(temp, path);
            dashboard.ShowDialog();
            this.Close();
        }

        private void heightTextBox_MaskInputRejected(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(heightTextBox.Text, @"[0-9]'1[0-1]") || (Regex.IsMatch(heightTextBox.Text, @"[0-9]'0[0-9]"))))
                heinvalid.Visible = false;
            else
                heinvalid.Visible = true;
        }

        private void weightTextBox_MaskInputRejected(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(weightTextBox.Text, @"^[0-9][0-9][0-9].[0-9][0-9]")))
                weinvalid.Visible = false;
            else
                weinvalid.Visible = true;
        }

        private void heinvalid_Click(object sender, EventArgs e)
        {

        }

        private void heightTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void HeightText_Click(object sender, EventArgs e)
        {

        }
    }
}
