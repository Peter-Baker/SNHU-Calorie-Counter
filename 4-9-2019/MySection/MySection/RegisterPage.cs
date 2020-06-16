using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // Things used to save files
using System.Xml.Serialization; //Things used to save files
using System.IO;//Things used to save files
using System.Text.RegularExpressions;//Regex
using MySection;

namespace NutritionCalculator
{
    public partial class RegisterPage : Form
    {

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            usernameText.Text = "";
            passwordText.Text = "";
            emailText.Text = "";
            heightText.Text = "";
            weightText.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage con = new LoginPage();
            con.ShowDialog();
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + usernameText.Text + @".txt";
            if (fninvalid.Visible == false && lninvalid.Visible == false && uninvalid.Visible == false && pwinvalid.Visible == false && eminvalid.Visible == false && heinvalid.Visible == false && weinvalid.Visible == false){
                User saveUser = new User(firstNameText.Text, lastNameText.Text, usernameText.Text, passwordText.Text, emailText.Text, heightText.Text, weightText.Text, 2000);
                saveUser.Save(path);
                this.Hide();
                LoginPage con = new LoginPage();
                con.ShowDialog();
                this.Close();
            }
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(firstNameText.Text, @"^[a-zA-Z]+$")))
                fninvalid.Visible = false;
            else
                fninvalid.Visible = true;
        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(lastNameText.Text, @"^[a-zA-Z/-]+$")))
                lninvalid.Visible = false;
            else
                lninvalid.Visible = true;
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
          
            if ((Regex.IsMatch(usernameText.Text, @"^[a-zA-Z0-9]+$")))
                uninvalid.Visible = false;
            else
                uninvalid.Visible = true;
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(passwordText.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,})"))
                pwinvalid.Visible = false;
            else
                pwinvalid.Visible = true;
        }

        

        private void emailText_TextChanged(object sender, EventArgs e)
        {
            string mail;
            string[] filePaths = Directory.GetFiles(@"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed");
            string[] lines;
            int count = filePaths.Length;
            
            for (int i = 0; i < count; i++)
            {
                lines = File.ReadAllLines(filePaths[i]);
                mail = lines[4].Split(' ')[1];
                if (mail == emailText.Text || emailText.Text.Length <= 4 || !(emailText.Text.Contains('@') && emailText.Text.Contains('.')))
                {
                    eminvalid.Visible = true;
                    break;
                }
                else
                {
                    eminvalid.Visible = false;
                }
            }

        }

        private void heightText_MaskInputRejected(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(heightText.Text, @"[0-9]'1[0-1]") || (Regex.IsMatch(heightText.Text, @"[0-9]'0[0-9]"))))
                heinvalid.Visible = false;
            else
                heinvalid.Visible = true;
        }

        private void weightText_MaskInputRejected(object sender, EventArgs e)
        {
           if ((Regex.IsMatch(weightText.Text, @"^[0-9][0-9][0-9].[0-9][0-9]")))
                weinvalid.Visible = false;
            else
            weinvalid.Visible = true;
        }

        private void fninvalid_Click(object sender, EventArgs e)
        {

        }

        private void destruction_Click(object sender, EventArgs e)
        {

        }
    }
}
