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
using NutritionCalculator;
using System.Text.RegularExpressions;
using System.Collections;

namespace MySection
{
    public partial class Dashboard : Form
    {

        private User name;
        private String category;
        private String pathForDate;

        private ArrayList breakfast = new ArrayList();
        private ArrayList lunch = new ArrayList();
        private ArrayList dinner = new ArrayList();
        private ArrayList snacks = new ArrayList();
        private ArrayList workouts = new ArrayList();

        public Dashboard() //Do not use this one
        {
            InitializeComponent();
        }

        public Dashboard(User name) //LOADING CURRENT DATE
        {
            InitializeComponent();
            this.name = name;
            changeCalories("2000");
            name.set_calorieAmount(2000);
            heightText.Text = "Height: " + name.get_height();
            WeightText.Text = "Weight: " + name.get_weight();
            changeCalories(name.get_calorieAmount().ToString());
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\GlobalCategories\Breakfast.txt";
            String[] lines = File.ReadAllLines(path);
            for(int i = 0; i < lines.Length; i++)
            {
                listBoxforPopUp.Items.Add(lines[i]);
            }
            category = "Breakfast";

            if (File.Exists(@"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + name.get_username() + @"\" + DateTime.Now.ToString("M.d.yyyy") + @".txt"))
            {
                string[] temp = File.ReadAllLines(@"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\" + name.get_username() + @"\" + DateTime.Now.ToString("M.d.yyyy") + @".txt");
                int lunchSpot = 0;
                int dinnerSpot = 0;
                int snacksSpot = 0;
                int workoutSpot = 0;

                for (int i = 1; i < temp.Length; i++)
                {
                    if (temp[i] == "lunch")
                        lunchSpot = i;
                    if (temp[i] == "dinner")
                        dinnerSpot = i;
                    if (temp[i] == "snacks")
                        snacksSpot = i;
                    if (temp[i] == "workouts")
                        workoutSpot = i;
                }
                if (lunchSpot != 1) {
                    for (int i = 1; i < lunchSpot; i++) //BREAKFAST ITEMS
                    {
                        BreakfastItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        breakfast.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
                if (dinnerSpot - lunchSpot != 1)
                {
                    for (int i = lunchSpot + 1; i < dinnerSpot; i++) //LUNCH ITEMS
                    {
                        LunchItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        lunch.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
                if (snacksSpot - dinnerSpot != 1)
                {
                    for (int i = dinnerSpot + 1; i < snacksSpot; i++) //DINNER ITEMS
                    {
                        DinnerItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        dinner.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
                if (workoutSpot - snacksSpot != 1)
                {
                    for (int i = snacksSpot + 1; i < workoutSpot; i++)
                    {
                        SnackItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        snacks.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
                if (workoutSpot != temp.Length - 1)
                {
                    for (int i = workoutSpot + 1; i < temp.Length; i++)
                    {
                        WorkoutItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        workouts.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
            }
            changeCalories(name.get_calorieAmount().ToString());
        }
        
        public Dashboard(User name, String path) //IF A DATE HAS BEEN CHOSEN
        {
            InitializeComponent();
            changeCalories("2000");
            name.set_calorieAmount(2000);
            
            pathForDate = path;
            this.name = name;
            heightText.Text = "Height: " + name.get_height();
            WeightText.Text = "Weight: " + name.get_weight();
            changeCalories(name.get_calorieAmount().ToString());
            String pathTwo = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\GlobalCategories\Breakfast.txt";
            String[] lines = File.ReadAllLines(pathTwo);
            for (int i = 0; i < lines.Length; i++)
            {
                listBoxforPopUp.Items.Add(lines[i]);
            }
            category = "Breakfast";

            if (File.Exists(path))
            {
                string[] temp = File.ReadAllLines(path);
                int lunchSpot = 0;
                int dinnerSpot = 0;
                int snacksSpot = 0;
                int workoutSpot = 0;

                for (int i = 1; i < temp.Length; i++)
                {
                    if (temp[i] == "lunch")
                        lunchSpot = i;
                    if (temp[i] == "dinner")
                        dinnerSpot = i;
                    if (temp[i] == "snacks")
                        snacksSpot = i;
                    if (temp[i] == "workouts")
                        workoutSpot = i;
                }
                if (lunchSpot != 1)
                {
                    for (int i = 1; i < lunchSpot; i++) //BREAKFAST ITEMS
                    {
                        BreakfastItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        breakfast.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
                if (dinnerSpot - lunchSpot != 1)
                {
                    for (int i = lunchSpot + 1; i < dinnerSpot; i++) //LUNCH ITEMS
                    {
                        LunchItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        lunch.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
                if (snacksSpot - dinnerSpot != 1)
                {
                    for (int i = dinnerSpot + 1; i < snacksSpot; i++) //DINNER ITEMS
                    {
                        DinnerItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        dinner.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
                if (workoutSpot - snacksSpot != 1)
                {
                    for (int i = snacksSpot + 1; i < workoutSpot; i++)
                    {
                        SnackItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        snacks.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
                if (workoutSpot != temp.Length - 1)
                {
                    for (int i = workoutSpot + 1; i < temp.Length; i++)
                    {
                        WorkoutItems.Items.Add(temp[i]);
                        int tempNum = name.get_calorieAmount();
                        String tempString = temp[i];
                        workouts.Add(tempString);
                        tempString = tempString.Substring(tempString.IndexOf(":") + 1);
                        tempNum = tempNum - int.Parse(tempString);
                        changeCalories(tempString);
                        name.set_calorieAmount(tempNum);
                    }
                }
            }
            changeCalories(name.get_calorieAmount().ToString());
        }
        
        public void changeCalories(String calories)
        {
            CaloriesLeftLabel.Text = "Calories Left: " + calories;
            CaloriesLeftCounter.Text = calories;
            if (int.Parse(CaloriesLeftCounter.Text) > 500)
                CaloriesLeftCounter.ForeColor = System.Drawing.Color.Green;
            else
                CaloriesLeftCounter.ForeColor = System.Drawing.Color.Red;
        }

        private void CalorieAmount_Click(object sender, EventArgs e) //Calorie Number Shown at Top of Page
        {

        }

        private void ChooseDateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeDate dateChange = new ChangeDate(name);
            dateChange.ShowDialog();
            this.Close();
        }

        private void BreakfastButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            PopUpPanel.Visible = true;
            breakfastItemPopUpText.Visible = true;
            listBoxforPopUp.Visible = true;
           
            closepopupboxbutton.Visible = true;
            AddButton.Visible = true;
            listBoxforPopUp.Items.Clear();
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\GlobalCategories\Breakfast.txt";
            String[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                listBoxforPopUp.Items.Add(lines[i]);
            }
            category = "Breakfast";
        }

        private void LunchButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            PopUpPanel.Visible = true;
            breakfastItemPopUpText.Visible = true;
            listBoxforPopUp.Visible = true;
            closepopupboxbutton.Visible = true;
            AddButton.Visible = true;
            listBoxforPopUp.Items.Clear();
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\GlobalCategories\Lunch.txt";
            String[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                listBoxforPopUp.Items.Add(lines[i]);
            }
            category = "Lunch";
        }

        private void DinnerButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            PopUpPanel.Visible = true;
            breakfastItemPopUpText.Visible = true;
            listBoxforPopUp.Visible = true;
            closepopupboxbutton.Visible = true;
            AddButton.Visible = true;
            listBoxforPopUp.Items.Clear();
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\GlobalCategories\Dinner.txt";
            String[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                listBoxforPopUp.Items.Add(lines[i]);
            }
            category = "Dinner";
        }

        private void SnacksButton_Click(object sender, EventArgs e)
        {
            PopUpPanel.Visible = true;
            breakfastItemPopUpText.Visible = true;
            listBoxforPopUp.Visible = true;
            closepopupboxbutton.Visible = true;
            AddButton.Visible = true;
            listBoxforPopUp.Items.Clear();
            String path = @"C:\Users\peter\Desktop\Final Product\4-9-2019\MySection\DataUsed\GlobalCategories\Snacks.txt";
            String[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                listBoxforPopUp.Items.Add(lines[i]);
            }
            category = "Snacks";
        }

        private void WorkoutsButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            WorkoutAddPanel.Visible = true;
            typeWorkoutText.Visible = true;
            calorBurnedText.Visible = true;
            typeWorkoutText.Visible = true;
            calorBurnedText.Visible = true;
            AddAWorkOutTitle.Visible = true;
            CloseWorkout.Visible = true;
            ConfirmWorkout.Visible = true;
            WorkoutInvalid.BringToFront();
            InvalidCalories.BringToFront();
            WorkoutAddPanel.BringToFront();
        }

        private void heightWeightButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeightWeight heightWeightChange = new HeightWeight(name, pathForDate);
            heightWeightChange.ShowDialog();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            heightText.Text = "Height: " + name.get_height();
            WeightText.Text = "Weight: " + name.get_weight();
        }

        private void heightText_Click(object sender, EventArgs e)
        {

        }

        private void WeightText_Click(object sender, EventArgs e)
        {

        }

        private void PopUpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closepopupboxbutton_Click(object sender, EventArgs e)
        {
            PopUpPanel.Visible = false;
            breakfastItemPopUpText.Visible = false;
            listBoxforPopUp.Visible = false;
            closepopupboxbutton.Visible = false;
            AddButton.Visible = false;
        }

        private void listBoxforPopUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PopUpPanel.Visible = false;
            breakfastItemPopUpText.Visible = false;
            listBoxforPopUp.Visible = false;
            closepopupboxbutton.Visible = false;
            AddButton.Visible = false;

            if (category == "Breakfast")
            {
                BreakfastItems.Items.Add(listBoxforPopUp.SelectedItem.ToString());
                breakfast.Add(listBoxforPopUp.SelectedItem.ToString());
            }
            else if (category == "Lunch")
            {
                LunchItems.Items.Add(listBoxforPopUp.SelectedItem.ToString());
                lunch.Add(listBoxforPopUp.SelectedItem.ToString());
            }
            else if (category == "Dinner")
            {
                DinnerItems.Items.Add(listBoxforPopUp.SelectedItem.ToString());
                dinner.Add(listBoxforPopUp.SelectedItem.ToString());
            }
            else
            {
                SnackItems.Items.Add(listBoxforPopUp.SelectedItem.ToString());
                snacks.Add(listBoxforPopUp.SelectedItem.ToString());
            }
         
            int temp = name.get_calorieAmount();
            String tempString = listBoxforPopUp.SelectedItem.ToString();
            tempString = tempString.Substring(tempString.IndexOf(":") + 1);
            temp = temp - int.Parse(tempString);
            changeCalories(temp.ToString());
            name.set_calorieAmount(temp);
        }

        private void BreakfastItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BreakfastRemoveButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            if (BreakfastItems.SelectedItems != null && BreakfastItems.SelectedItems.Count > 0)
            {
                int temp = name.get_calorieAmount();
                String tempString = BreakfastItems.SelectedItems[0].ToString();
                tempString = tempString.Substring(tempString.IndexOf(":") + 3, tempString.Length-4 - tempString.IndexOf(":"));
                breakfast.Remove(tempString);
                temp = temp + int.Parse(tempString.Substring(tempString.IndexOfAny("0123456789".ToCharArray())));
                changeCalories(temp.ToString());
                name.set_calorieAmount(temp);
                BreakfastItems.Items.Remove(BreakfastItems.SelectedItems[0]);
                
            }
            else
            {
                NoItemsInCategory.Visible = true;
                CloseButtonNoItemsInCategory.Visible = true;
                NoItemsInCategoryText.Visible = true;
            }
        }

        private void CloseButtonNoItemsInCategory_Click(object sender, EventArgs e)
        {
            NoItemsInCategory.Visible = false;
            CloseButtonNoItemsInCategory.Visible = false;
            NoItemsInCategoryText.Visible = false;
        }

        private void typeOfWorkouttext_TextChanged(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(typeOfWorkouttext.Text, @"^[0-9a-zA-Z]+$")))
                WorkoutInvalid.Visible = true;
            else
                WorkoutInvalid.Visible = false;
        }

        private void caloriesBrunedtext_TextChanged(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(caloriesBurnedtext.Text, @"^[0-9]+$")))
                InvalidCalories.Visible = true;
            else
                InvalidCalories.Visible = false;
        }

        private void ConfirmWorkout_Click(object sender, EventArgs e)
        {
            if(WorkoutInvalid.Visible || InvalidCalories.Visible) { }
            else
            {
                WorkoutItems.Items.Add(typeOfWorkouttext.Text + ":" + caloriesBurnedtext.Text);
                workouts.Add(typeOfWorkouttext.Text + ":" + caloriesBurnedtext.Text);

                int temp = name.get_calorieAmount() + int.Parse(caloriesBurnedtext.Text);
                changeCalories(temp.ToString());
                name.set_calorieAmount(temp);

                WorkoutAddPanel.Visible = false;
                typeWorkoutText.Visible = false;
                calorBurnedText.Visible = false;
                AddAWorkOutTitle.Visible = false;
                CloseWorkout.Visible = false;
                ConfirmWorkout.Visible = false;
                WorkoutInvalid.SendToBack();
                InvalidCalories.SendToBack();
                WorkoutAddPanel.SendToBack();
            }
        }

        private void CloseWorkout_Click(object sender, EventArgs e)
        {
            WorkoutAddPanel.Visible = false;
            WorkoutAddPanel.SendToBack();
        }

        private void WorkoutsRemoveButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            if (WorkoutItems.SelectedItems != null && WorkoutItems.SelectedItems.Count > 0)
            {
                int temp = name.get_calorieAmount();
                String tempString = WorkoutItems.SelectedItems[0].ToString();
                tempString = tempString.Substring(tempString.IndexOf(":") + 3, tempString.Length - 4 - tempString.IndexOf(":"));
                workouts.Remove(tempString);
                temp = temp - int.Parse(tempString.Substring(tempString.IndexOfAny("0123456789".ToCharArray())));
                changeCalories(temp.ToString());
                name.set_calorieAmount(temp);
                WorkoutItems.Items.Remove(WorkoutItems.SelectedItems[0]);
            }
            else
            {
                NoItemsInCategory.Visible = true;
                CloseButtonNoItemsInCategory.Visible = true;
                NoItemsInCategoryText.Visible = true;
            }
}

        private void WorkoutItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LunchRemoveButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            if (LunchItems.SelectedItems != null && LunchItems.SelectedItems.Count > 0)
            {
                int temp = name.get_calorieAmount();
                String tempString = LunchItems.SelectedItems[0].ToString();
                tempString = tempString.Substring(tempString.IndexOf(":") + 3, tempString.Length - 4 - tempString.IndexOf(":"));
                lunch.Remove(tempString);
                temp = temp + int.Parse(tempString.Substring(tempString.IndexOfAny("0123456789".ToCharArray())));
                changeCalories(temp.ToString());
                name.set_calorieAmount(temp);
                LunchItems.Items.Remove(LunchItems.SelectedItems[0]);
            }
            else
            {
                NoItemsInCategory.Visible = true;
                CloseButtonNoItemsInCategory.Visible = true;
                NoItemsInCategoryText.Visible = true;
            }
        }

        private void DinnerRemoveButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            if (DinnerItems.SelectedItems != null && DinnerItems.SelectedItems.Count > 0)
            {
                int temp = name.get_calorieAmount();
                String tempString = DinnerItems.SelectedItems[0].ToString();
                tempString = tempString.Substring(tempString.IndexOf(":") + 3, tempString.Length - 4 - tempString.IndexOf(":"));
                dinner.Remove(tempString);
                temp = temp + int.Parse(tempString.Substring(tempString.IndexOfAny("0123456789".ToCharArray())));
                changeCalories(temp.ToString());
                name.set_calorieAmount(temp);
                DinnerItems.Items.Remove(DinnerItems.SelectedItems[0]);
            }
            else
            {
                NoItemsInCategory.Visible = true;
                CloseButtonNoItemsInCategory.Visible = true;
                NoItemsInCategoryText.Visible = true;
            }
        }

        private void SnacksRemoveButton_Click(object sender, EventArgs e)
        {
            SavedDayText.Visible = false;
            if (SnackItems.SelectedItems != null && SnackItems.SelectedItems.Count > 0)
            {
                int temp = name.get_calorieAmount();
                String tempString = SnackItems.SelectedItems[0].ToString();
                tempString = tempString.Substring(tempString.IndexOf(":") + 3, tempString.Length - 4 - tempString.IndexOf(":"));
                snacks.Remove(tempString);
                temp = temp + int.Parse(tempString.Substring(tempString.IndexOfAny("0123456789".ToCharArray())));
                changeCalories(temp.ToString());
                name.set_calorieAmount(temp);
                SnackItems.Items.Remove(SnackItems.SelectedItems[0]);
            }
            else
            {
                NoItemsInCategory.Visible = true;
                CloseButtonNoItemsInCategory.Visible = true;
                NoItemsInCategoryText.Visible = true;
            }
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            Date newDate = new Date(pathForDate, name, breakfast, lunch, dinner, snacks, workouts);
            SavedDayText.Visible = true;
        }

        private void CaloriesLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void CaloriesLeftCounter_Click(object sender, EventArgs e)
        {
           
        }
    }
}
