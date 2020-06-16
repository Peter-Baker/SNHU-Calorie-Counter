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
using MySection;

namespace NutritionCalculator
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closepopupboxbutton_Click(object sender, EventArgs e)
        {
            popuppanel.Visible = false;
            popuppanel.SendToBack();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
         
            if (usernametextbox.Text == "admin" && passwordtextbox.Text == "admin")//ADMIN LOGIN
            {
                this.Hide();
                AdminDashboard con = new AdminDashboard();
                con.ShowDialog();
                this.Close();
            }
            else if (File.Exists(@"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + usernametextbox.Text + ".txt"))
            {
                string passcheck;
                string[] lines;
                lines = File.ReadAllLines(@"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + usernametextbox.Text + ".txt");
                passcheck = lines[3].Split(' ')[1];
                
                if (passcheck == passwordtextbox.Text)
                {
                    string temp = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + usernametextbox.Text + ".txt";
                    String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + usernametextbox.Text + @"\" + DateTime.Now.ToString("M.d.yyyy") + @".txt";
                    User userdata = new User(temp);
                    this.Hide();
                    Dashboard con = new Dashboard(userdata, path);
                    con.ShowDialog();
                    this.Close();
                }
                else
                {
                 falselogin();
                }
            }

            else
            {
                falselogin();

            }
            
        }
        private void falselogin()
        {
            popuppanel.BringToFront();
            popuppanel.Visible = true;
        }
        private void popuppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage con = new RegisterPage();
            con.ShowDialog();
            this.Close();
        }

        private void Checkbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {
            passwordtextbox.PasswordChar = '*';
        }
    }
}
