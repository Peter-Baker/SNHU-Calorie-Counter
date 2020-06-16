using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;//Regex
using System.Xml; // Things used to save files
using System.Xml.Serialization; //Things used to save files
using System.IO;//Things used to save files
using MySection;

namespace NutritionCalculator
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string userName;
        private string password;
        private string email;
        private string height;
        private string weight;
        private int calorieAmount;
        public User(string firstname, string lastname, string username, string passWord, string Email, string Height, string Weight, int calcount)
        {
            firstName = firstname;
            lastName = lastname;
            userName = username;
            password = passWord;
            email = Email;
            height = Height;
            weight = Weight;
            calorieAmount = calcount;
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + userName + @"\";
            Directory.CreateDirectory(path);
        }
        public User(string firstname, string lastname, string username, string passWord, string Email, string Height, string Weight) //Save File
        {
            firstName = firstname;
            lastName = lastname;
            userName = username;
            password = passWord;
            email = Email;
            height = Height;
            weight = Weight;
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + userName + @"\";
            Directory.CreateDirectory(path);
        }

        public User(string uname)
        {
            string[] lines;
            lines = File.ReadAllLines(uname);
            firstName = lines[0].Split(' ')[1];
            lastName = lines[1].Split(' ')[1]; 
            userName = lines[2].Split(' ')[1];
            password = lines[3].Split(' ')[1];
            email = lines[4].Split(' ')[1];
            height = lines[5].Split(' ')[1];
            weight = lines[6].Split(' ')[1];
            calorieAmount = int.Parse(lines[7].Split(' ')[1]);
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + userName + @"\";
            Directory.CreateDirectory(path);
        }

        public void Save(string path)
        {
            string[] lines = { "Firstname: " + firstName, "Lastname: " + lastName, "Username: " + userName, "Password: " + password, "Email: " + email, "Height: " + height, "Weight: " + weight, "CalCount: " + calorieAmount};
            File.WriteAllLines(path, lines);
        }

        public void Save(string path, string h, string w)
        {
            string[] lines = { "Firstname: " + firstName, "Lastname: " + lastName, "Username: " + userName, "Password: " + password, "Email: " + email, "Height: " + h, "Weight: " + w, "CalCount: " + calorieAmount};
            File.WriteAllLines(path, lines);
        }

        public string get_firstName()
        {
            return firstName;
        }
        public string get_lastName()
        {
            return lastName;
        }
        public string get_username()
        {
            return userName;
        }
        public string get_password()
        {
            return password;
        }
        public string get_email()
        {
            return email;
        }
        public string get_height()
        {
            return height;
        }
        public string get_weight()
        {
            return weight;
        }
        public int get_calorieAmount()
        {
            return calorieAmount;
        }
        public void set_firstName(string fn)
        {
            firstName = fn;
        }
        public void set_lastName(string ln)
        {
            lastName = ln;
        }
        public void set_username(string un)
        {
            userName = un;
        }
        public void set_password(string pw)
        {
            password = pw;
        }
        public void set_email(string em)
        {
            email = em;
        }
        public void set_height(string he )
        {
            height = he;
        }
        public void set_weight(string we)
        {
            weight = we;
        }
        public void set_calorieAmount(int ca)
        {
            calorieAmount = ca;
        }
    }
}
