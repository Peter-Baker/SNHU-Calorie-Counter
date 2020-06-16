using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NutritionCalculator;

namespace MySection
{
    public partial class ChangeDate : Form
    {


        private User tempStu;
        public ChangeDate()
        {
            InitializeComponent();
        }

        public ChangeDate(User temp)
        {
            InitializeComponent();
            this.tempStu = temp;
        }

        private void CancelButton_Click(object sender, EventArgs e) //CancelButtonChangeDate
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(tempStu);
            dashboard.ShowDialog();
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            //Create a Date.cs class then use it to be able to change the date and save it.
            //If you click save, save all data to a text file named MONTH.DAY.YEAR.txt (CHECK IF FILE EXISTS ALREADY!)
            //If you click another date if a file already exists load it. Else just load a new dashboard and when they save it create a new file.

            String calendarDate = Calendar.SelectionRange.ToString();
            int firstNum = calendarDate.IndexOfAny("0123456789".ToCharArray());
            if(calendarDate.ElementAt(24) == '/')
            {
                calendarDate = calendarDate.Substring(firstNum, 9);
                calendarDate = calendarDate.Replace('/', '.');
            }
            else
            {
                calendarDate = calendarDate.Substring(firstNum, 10);
                calendarDate = calendarDate.Replace('/', '.');
            }
            
            this.Hide();
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + tempStu.get_username() + @"\" + calendarDate + @".txt";
            Dashboard dashboard = new Dashboard(tempStu, path);
            dashboard.ShowDialog();
            this.Close();
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ChangeDate_Load(object sender, EventArgs e)
        {

        }
    }
}
