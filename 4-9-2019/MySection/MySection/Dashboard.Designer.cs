namespace MySection
{
    partial class Dashboard
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
            this.CalorieCounterTitle = new System.Windows.Forms.Label();
            this.ChooseDateButton = new System.Windows.Forms.Button();
            this.BreakfastButton = new System.Windows.Forms.Button();
            this.CaloriesLeftLabel = new System.Windows.Forms.Label();
            this.LunchButton = new System.Windows.Forms.Button();
            this.DinnerButton = new System.Windows.Forms.Button();
            this.SnacksButton = new System.Windows.Forms.Button();
            this.WorkoutsButton = new System.Windows.Forms.Button();
            this.heightText = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.Label();
            this.heightWeightButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BreakfastItems = new System.Windows.Forms.ListView();
            this.LunchItems = new System.Windows.Forms.ListView();
            this.DinnerItems = new System.Windows.Forms.ListView();
            this.SnackItems = new System.Windows.Forms.ListView();
            this.WorkoutItems = new System.Windows.Forms.ListView();
            this.BreakfastLabel = new System.Windows.Forms.Label();
            this.LunchLabel = new System.Windows.Forms.Label();
            this.DinnerLabel = new System.Windows.Forms.Label();
            this.SnacksLabel = new System.Windows.Forms.Label();
            this.BreakfastRemoveButton = new System.Windows.Forms.Button();
            this.LunchRemoveButton = new System.Windows.Forms.Button();
            this.DinnerRemoveButton = new System.Windows.Forms.Button();
            this.SnacksRemoveButton = new System.Windows.Forms.Button();
            this.WorkoutsLabel = new System.Windows.Forms.Label();
            this.WorkoutsRemoveButton = new System.Windows.Forms.Button();
            this.PopUpPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.listBoxforPopUp = new System.Windows.Forms.ListBox();
            this.breakfastItemPopUpText = new System.Windows.Forms.Label();
            this.closepopupboxbutton = new System.Windows.Forms.Button();
            this.WorkoutAddPanel = new System.Windows.Forms.Panel();
            this.InvalidCalories = new System.Windows.Forms.Label();
            this.WorkoutInvalid = new System.Windows.Forms.Label();
            this.caloriesBurnedtext = new System.Windows.Forms.TextBox();
            this.typeOfWorkouttext = new System.Windows.Forms.TextBox();
            this.calorBurnedText = new System.Windows.Forms.Label();
            this.typeWorkoutText = new System.Windows.Forms.Label();
            this.ConfirmWorkout = new System.Windows.Forms.Button();
            this.AddAWorkOutTitle = new System.Windows.Forms.Label();
            this.CloseWorkout = new System.Windows.Forms.Button();
            this.NoItemsInCategory = new System.Windows.Forms.Panel();
            this.NoItemsInCategoryText = new System.Windows.Forms.Label();
            this.CloseButtonNoItemsInCategory = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SavedDayText = new System.Windows.Forms.Label();
            this.CaloriesLeftCounter = new System.Windows.Forms.Label();
            this.PopUpPanel.SuspendLayout();
            this.WorkoutAddPanel.SuspendLayout();
            this.NoItemsInCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalorieCounterTitle
            // 
            this.CalorieCounterTitle.AutoSize = true;
            this.CalorieCounterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalorieCounterTitle.Location = new System.Drawing.Point(92, 9);
            this.CalorieCounterTitle.Name = "CalorieCounterTitle";
            this.CalorieCounterTitle.Size = new System.Drawing.Size(300, 32);
            this.CalorieCounterTitle.TabIndex = 0;
            this.CalorieCounterTitle.Text = "SNHU Calorie Counter";
            // 
            // ChooseDateButton
            // 
            this.ChooseDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDateButton.Location = new System.Drawing.Point(163, 49);
            this.ChooseDateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChooseDateButton.Name = "ChooseDateButton";
            this.ChooseDateButton.Size = new System.Drawing.Size(148, 38);
            this.ChooseDateButton.TabIndex = 1;
            this.ChooseDateButton.Text = "Choose Date";
            this.ChooseDateButton.UseVisualStyleBackColor = true;
            this.ChooseDateButton.Click += new System.EventHandler(this.ChooseDateButton_Click);
            // 
            // BreakfastButton
            // 
            this.BreakfastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakfastButton.Location = new System.Drawing.Point(204, 238);
            this.BreakfastButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BreakfastButton.Name = "BreakfastButton";
            this.BreakfastButton.Size = new System.Drawing.Size(35, 33);
            this.BreakfastButton.TabIndex = 3;
            this.BreakfastButton.Text = "+";
            this.BreakfastButton.UseVisualStyleBackColor = true;
            this.BreakfastButton.Click += new System.EventHandler(this.BreakfastButton_Click);
            // 
            // CaloriesLeftLabel
            // 
            this.CaloriesLeftLabel.AutoSize = true;
            this.CaloriesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CaloriesLeftLabel.Location = new System.Drawing.Point(131, 180);
            this.CaloriesLeftLabel.Name = "CaloriesLeftLabel";
            this.CaloriesLeftLabel.Size = new System.Drawing.Size(127, 25);
            this.CaloriesLeftLabel.TabIndex = 3;
            this.CaloriesLeftLabel.Text = "Calories Left:";
            this.CaloriesLeftLabel.Click += new System.EventHandler(this.CaloriesLeftLabel_Click);
            // 
            // LunchButton
            // 
            this.LunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchButton.Location = new System.Drawing.Point(241, 238);
            this.LunchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LunchButton.Name = "LunchButton";
            this.LunchButton.Size = new System.Drawing.Size(35, 33);
            this.LunchButton.TabIndex = 4;
            this.LunchButton.Text = "+";
            this.LunchButton.UseVisualStyleBackColor = true;
            this.LunchButton.Click += new System.EventHandler(this.LunchButton_Click);
            // 
            // DinnerButton
            // 
            this.DinnerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinnerButton.Location = new System.Drawing.Point(204, 373);
            this.DinnerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DinnerButton.Name = "DinnerButton";
            this.DinnerButton.Size = new System.Drawing.Size(35, 34);
            this.DinnerButton.TabIndex = 7;
            this.DinnerButton.Text = "+";
            this.DinnerButton.UseVisualStyleBackColor = true;
            this.DinnerButton.Click += new System.EventHandler(this.DinnerButton_Click);
            // 
            // SnacksButton
            // 
            this.SnacksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnacksButton.Location = new System.Drawing.Point(241, 373);
            this.SnacksButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SnacksButton.Name = "SnacksButton";
            this.SnacksButton.Size = new System.Drawing.Size(35, 34);
            this.SnacksButton.TabIndex = 8;
            this.SnacksButton.Text = "+";
            this.SnacksButton.UseVisualStyleBackColor = true;
            this.SnacksButton.Click += new System.EventHandler(this.SnacksButton_Click);
            // 
            // WorkoutsButton
            // 
            this.WorkoutsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkoutsButton.Location = new System.Drawing.Point(300, 479);
            this.WorkoutsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WorkoutsButton.Name = "WorkoutsButton";
            this.WorkoutsButton.Size = new System.Drawing.Size(35, 30);
            this.WorkoutsButton.TabIndex = 12;
            this.WorkoutsButton.Text = "+";
            this.WorkoutsButton.UseVisualStyleBackColor = true;
            this.WorkoutsButton.Click += new System.EventHandler(this.WorkoutsButton_Click);
            // 
            // heightText
            // 
            this.heightText.AutoSize = true;
            this.heightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightText.Location = new System.Drawing.Point(137, 103);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(74, 25);
            this.heightText.TabIndex = 9;
            this.heightText.Text = "Height:";
            this.heightText.Click += new System.EventHandler(this.heightText_Click);
            // 
            // WeightText
            // 
            this.WeightText.AutoSize = true;
            this.WeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WeightText.Location = new System.Drawing.Point(257, 103);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(80, 25);
            this.WeightText.TabIndex = 10;
            this.WeightText.Text = "Weight:";
            this.WeightText.Click += new System.EventHandler(this.WeightText_Click);
            // 
            // heightWeightButton
            // 
            this.heightWeightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightWeightButton.Location = new System.Drawing.Point(147, 132);
            this.heightWeightButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.heightWeightButton.Name = "heightWeightButton";
            this.heightWeightButton.Size = new System.Drawing.Size(181, 38);
            this.heightWeightButton.TabIndex = 2;
            this.heightWeightButton.Text = "Choose Height/Weight";
            this.heightWeightButton.UseVisualStyleBackColor = true;
            this.heightWeightButton.Click += new System.EventHandler(this.heightWeightButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(104, 630);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(127, 38);
            this.LogOutButton.TabIndex = 13;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // BreakfastItems
            // 
            this.BreakfastItems.Location = new System.Drawing.Point(11, 238);
            this.BreakfastItems.Margin = new System.Windows.Forms.Padding(1);
            this.BreakfastItems.Name = "BreakfastItems";
            this.BreakfastItems.Size = new System.Drawing.Size(192, 96);
            this.BreakfastItems.TabIndex = 30;
            this.BreakfastItems.UseCompatibleStateImageBehavior = false;
            this.BreakfastItems.SelectedIndexChanged += new System.EventHandler(this.BreakfastItems_SelectedIndexChanged);
            // 
            // LunchItems
            // 
            this.LunchItems.Location = new System.Drawing.Point(279, 238);
            this.LunchItems.Margin = new System.Windows.Forms.Padding(1);
            this.LunchItems.Name = "LunchItems";
            this.LunchItems.Size = new System.Drawing.Size(192, 96);
            this.LunchItems.TabIndex = 14;
            this.LunchItems.UseCompatibleStateImageBehavior = false;
            // 
            // DinnerItems
            // 
            this.DinnerItems.Location = new System.Drawing.Point(11, 373);
            this.DinnerItems.Margin = new System.Windows.Forms.Padding(1);
            this.DinnerItems.Name = "DinnerItems";
            this.DinnerItems.Size = new System.Drawing.Size(192, 96);
            this.DinnerItems.TabIndex = 15;
            this.DinnerItems.UseCompatibleStateImageBehavior = false;
            // 
            // SnackItems
            // 
            this.SnackItems.Location = new System.Drawing.Point(279, 373);
            this.SnackItems.Margin = new System.Windows.Forms.Padding(1);
            this.SnackItems.Name = "SnackItems";
            this.SnackItems.Size = new System.Drawing.Size(192, 96);
            this.SnackItems.TabIndex = 16;
            this.SnackItems.UseCompatibleStateImageBehavior = false;
            // 
            // WorkoutItems
            // 
            this.WorkoutItems.Location = new System.Drawing.Point(147, 510);
            this.WorkoutItems.Margin = new System.Windows.Forms.Padding(1);
            this.WorkoutItems.Name = "WorkoutItems";
            this.WorkoutItems.Size = new System.Drawing.Size(191, 96);
            this.WorkoutItems.TabIndex = 17;
            this.WorkoutItems.UseCompatibleStateImageBehavior = false;
            this.WorkoutItems.SelectedIndexChanged += new System.EventHandler(this.WorkoutItems_SelectedIndexChanged);
            // 
            // BreakfastLabel
            // 
            this.BreakfastLabel.AutoSize = true;
            this.BreakfastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BreakfastLabel.Location = new System.Drawing.Point(53, 213);
            this.BreakfastLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.BreakfastLabel.Name = "BreakfastLabel";
            this.BreakfastLabel.Size = new System.Drawing.Size(100, 25);
            this.BreakfastLabel.TabIndex = 18;
            this.BreakfastLabel.Text = "Breakfast:";
            // 
            // LunchLabel
            // 
            this.LunchLabel.AutoSize = true;
            this.LunchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LunchLabel.Location = new System.Drawing.Point(337, 213);
            this.LunchLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LunchLabel.Name = "LunchLabel";
            this.LunchLabel.Size = new System.Drawing.Size(72, 25);
            this.LunchLabel.TabIndex = 19;
            this.LunchLabel.Text = "Lunch:";
            // 
            // DinnerLabel
            // 
            this.DinnerLabel.AutoSize = true;
            this.DinnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DinnerLabel.Location = new System.Drawing.Point(64, 347);
            this.DinnerLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.DinnerLabel.Name = "DinnerLabel";
            this.DinnerLabel.Size = new System.Drawing.Size(75, 25);
            this.DinnerLabel.TabIndex = 20;
            this.DinnerLabel.Text = "Dinner:";
            // 
            // SnacksLabel
            // 
            this.SnacksLabel.AutoSize = true;
            this.SnacksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SnacksLabel.Location = new System.Drawing.Point(337, 347);
            this.SnacksLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SnacksLabel.Name = "SnacksLabel";
            this.SnacksLabel.Size = new System.Drawing.Size(84, 25);
            this.SnacksLabel.TabIndex = 21;
            this.SnacksLabel.Text = "Snacks:";
            // 
            // BreakfastRemoveButton
            // 
            this.BreakfastRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakfastRemoveButton.Location = new System.Drawing.Point(204, 277);
            this.BreakfastRemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BreakfastRemoveButton.Name = "BreakfastRemoveButton";
            this.BreakfastRemoveButton.Size = new System.Drawing.Size(35, 33);
            this.BreakfastRemoveButton.TabIndex = 5;
            this.BreakfastRemoveButton.Text = "-";
            this.BreakfastRemoveButton.UseVisualStyleBackColor = true;
            this.BreakfastRemoveButton.Click += new System.EventHandler(this.BreakfastRemoveButton_Click);
            // 
            // LunchRemoveButton
            // 
            this.LunchRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LunchRemoveButton.Location = new System.Drawing.Point(241, 277);
            this.LunchRemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LunchRemoveButton.Name = "LunchRemoveButton";
            this.LunchRemoveButton.Size = new System.Drawing.Size(35, 33);
            this.LunchRemoveButton.TabIndex = 6;
            this.LunchRemoveButton.Text = "-";
            this.LunchRemoveButton.UseVisualStyleBackColor = true;
            this.LunchRemoveButton.Click += new System.EventHandler(this.LunchRemoveButton_Click);
            // 
            // DinnerRemoveButton
            // 
            this.DinnerRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinnerRemoveButton.Location = new System.Drawing.Point(204, 414);
            this.DinnerRemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DinnerRemoveButton.Name = "DinnerRemoveButton";
            this.DinnerRemoveButton.Size = new System.Drawing.Size(35, 33);
            this.DinnerRemoveButton.TabIndex = 9;
            this.DinnerRemoveButton.Text = "-";
            this.DinnerRemoveButton.UseVisualStyleBackColor = true;
            this.DinnerRemoveButton.Click += new System.EventHandler(this.DinnerRemoveButton_Click);
            // 
            // SnacksRemoveButton
            // 
            this.SnacksRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnacksRemoveButton.Location = new System.Drawing.Point(241, 414);
            this.SnacksRemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SnacksRemoveButton.Name = "SnacksRemoveButton";
            this.SnacksRemoveButton.Size = new System.Drawing.Size(35, 33);
            this.SnacksRemoveButton.TabIndex = 10;
            this.SnacksRemoveButton.Text = "-";
            this.SnacksRemoveButton.UseVisualStyleBackColor = true;
            this.SnacksRemoveButton.Click += new System.EventHandler(this.SnacksRemoveButton_Click);
            // 
            // WorkoutsLabel
            // 
            this.WorkoutsLabel.AutoSize = true;
            this.WorkoutsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WorkoutsLabel.Location = new System.Drawing.Point(189, 484);
            this.WorkoutsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.WorkoutsLabel.Name = "WorkoutsLabel";
            this.WorkoutsLabel.Size = new System.Drawing.Size(102, 25);
            this.WorkoutsLabel.TabIndex = 26;
            this.WorkoutsLabel.Text = "Workouts:";
            // 
            // WorkoutsRemoveButton
            // 
            this.WorkoutsRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkoutsRemoveButton.Location = new System.Drawing.Point(147, 479);
            this.WorkoutsRemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WorkoutsRemoveButton.Name = "WorkoutsRemoveButton";
            this.WorkoutsRemoveButton.Size = new System.Drawing.Size(35, 30);
            this.WorkoutsRemoveButton.TabIndex = 11;
            this.WorkoutsRemoveButton.Text = "-";
            this.WorkoutsRemoveButton.UseVisualStyleBackColor = true;
            this.WorkoutsRemoveButton.Click += new System.EventHandler(this.WorkoutsRemoveButton_Click);
            // 
            // PopUpPanel
            // 
            this.PopUpPanel.BackColor = System.Drawing.Color.LightBlue;
            this.PopUpPanel.Controls.Add(this.AddButton);
            this.PopUpPanel.Controls.Add(this.listBoxforPopUp);
            this.PopUpPanel.Controls.Add(this.breakfastItemPopUpText);
            this.PopUpPanel.Controls.Add(this.closepopupboxbutton);
            this.PopUpPanel.Location = new System.Drawing.Point(24, 258);
            this.PopUpPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PopUpPanel.Name = "PopUpPanel";
            this.PopUpPanel.Size = new System.Drawing.Size(437, 186);
            this.PopUpPanel.TabIndex = 31;
            this.PopUpPanel.Visible = false;
            this.PopUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PopUpPanel_Paint);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(237, 132);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 44);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // listBoxforPopUp
            // 
            this.listBoxforPopUp.FormattingEnabled = true;
            this.listBoxforPopUp.ItemHeight = 16;
            this.listBoxforPopUp.Location = new System.Drawing.Point(67, 39);
            this.listBoxforPopUp.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxforPopUp.Name = "listBoxforPopUp";
            this.listBoxforPopUp.Size = new System.Drawing.Size(297, 84);
            this.listBoxforPopUp.TabIndex = 10;
            this.listBoxforPopUp.Visible = false;
            this.listBoxforPopUp.SelectedIndexChanged += new System.EventHandler(this.listBoxforPopUp_SelectedIndexChanged);
            // 
            // breakfastItemPopUpText
            // 
            this.breakfastItemPopUpText.AutoSize = true;
            this.breakfastItemPopUpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastItemPopUpText.Location = new System.Drawing.Point(87, 11);
            this.breakfastItemPopUpText.Name = "breakfastItemPopUpText";
            this.breakfastItemPopUpText.Size = new System.Drawing.Size(231, 29);
            this.breakfastItemPopUpText.TabIndex = 8;
            this.breakfastItemPopUpText.Text = "Click on Item Below:";
            this.breakfastItemPopUpText.Visible = false;
            // 
            // closepopupboxbutton
            // 
            this.closepopupboxbutton.Location = new System.Drawing.Point(80, 132);
            this.closepopupboxbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closepopupboxbutton.Name = "closepopupboxbutton";
            this.closepopupboxbutton.Size = new System.Drawing.Size(105, 44);
            this.closepopupboxbutton.TabIndex = 9;
            this.closepopupboxbutton.Text = "Close";
            this.closepopupboxbutton.UseVisualStyleBackColor = true;
            this.closepopupboxbutton.Visible = false;
            this.closepopupboxbutton.Click += new System.EventHandler(this.closepopupboxbutton_Click);
            // 
            // WorkoutAddPanel
            // 
            this.WorkoutAddPanel.BackColor = System.Drawing.Color.LightBlue;
            this.WorkoutAddPanel.Controls.Add(this.InvalidCalories);
            this.WorkoutAddPanel.Controls.Add(this.WorkoutInvalid);
            this.WorkoutAddPanel.Controls.Add(this.caloriesBurnedtext);
            this.WorkoutAddPanel.Controls.Add(this.typeOfWorkouttext);
            this.WorkoutAddPanel.Controls.Add(this.calorBurnedText);
            this.WorkoutAddPanel.Controls.Add(this.typeWorkoutText);
            this.WorkoutAddPanel.Controls.Add(this.ConfirmWorkout);
            this.WorkoutAddPanel.Controls.Add(this.AddAWorkOutTitle);
            this.WorkoutAddPanel.Controls.Add(this.CloseWorkout);
            this.WorkoutAddPanel.Location = new System.Drawing.Point(24, 466);
            this.WorkoutAddPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WorkoutAddPanel.Name = "WorkoutAddPanel";
            this.WorkoutAddPanel.Size = new System.Drawing.Size(437, 186);
            this.WorkoutAddPanel.TabIndex = 32;
            this.WorkoutAddPanel.Visible = false;
            // 
            // InvalidCalories
            // 
            this.InvalidCalories.AutoSize = true;
            this.InvalidCalories.BackColor = System.Drawing.Color.LightBlue;
            this.InvalidCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidCalories.ForeColor = System.Drawing.Color.Red;
            this.InvalidCalories.Location = new System.Drawing.Point(161, 81);
            this.InvalidCalories.Name = "InvalidCalories";
            this.InvalidCalories.Size = new System.Drawing.Size(100, 18);
            this.InvalidCalories.TabIndex = 17;
            this.InvalidCalories.Text = "Numbers only";
            this.InvalidCalories.Visible = false;
            // 
            // WorkoutInvalid
            // 
            this.WorkoutInvalid.AutoSize = true;
            this.WorkoutInvalid.BackColor = System.Drawing.Color.LightBlue;
            this.WorkoutInvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkoutInvalid.ForeColor = System.Drawing.Color.Red;
            this.WorkoutInvalid.Location = new System.Drawing.Point(161, 34);
            this.WorkoutInvalid.Name = "WorkoutInvalid";
            this.WorkoutInvalid.Size = new System.Drawing.Size(90, 18);
            this.WorkoutInvalid.TabIndex = 16;
            this.WorkoutInvalid.Text = "No Symbols";
            this.WorkoutInvalid.Visible = false;
            // 
            // caloriesBurnedtext
            // 
            this.caloriesBurnedtext.Location = new System.Drawing.Point(163, 103);
            this.caloriesBurnedtext.Margin = new System.Windows.Forms.Padding(1);
            this.caloriesBurnedtext.Name = "caloriesBurnedtext";
            this.caloriesBurnedtext.Size = new System.Drawing.Size(209, 22);
            this.caloriesBurnedtext.TabIndex = 15;
            this.caloriesBurnedtext.TextChanged += new System.EventHandler(this.caloriesBrunedtext_TextChanged);
            // 
            // typeOfWorkouttext
            // 
            this.typeOfWorkouttext.Location = new System.Drawing.Point(163, 57);
            this.typeOfWorkouttext.Margin = new System.Windows.Forms.Padding(1);
            this.typeOfWorkouttext.Name = "typeOfWorkouttext";
            this.typeOfWorkouttext.Size = new System.Drawing.Size(209, 22);
            this.typeOfWorkouttext.TabIndex = 14;
            this.typeOfWorkouttext.TextChanged += new System.EventHandler(this.typeOfWorkouttext_TextChanged);
            // 
            // calorBurnedText
            // 
            this.calorBurnedText.AutoSize = true;
            this.calorBurnedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorBurnedText.Location = new System.Drawing.Point(13, 103);
            this.calorBurnedText.Name = "calorBurnedText";
            this.calorBurnedText.Size = new System.Drawing.Size(135, 20);
            this.calorBurnedText.TabIndex = 13;
            this.calorBurnedText.Text = "Calories Burned:";
            this.calorBurnedText.Visible = false;
            // 
            // typeWorkoutText
            // 
            this.typeWorkoutText.AutoSize = true;
            this.typeWorkoutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeWorkoutText.Location = new System.Drawing.Point(12, 57);
            this.typeWorkoutText.Name = "typeWorkoutText";
            this.typeWorkoutText.Size = new System.Drawing.Size(136, 20);
            this.typeWorkoutText.TabIndex = 12;
            this.typeWorkoutText.Text = "Type of Workout:";
            this.typeWorkoutText.Visible = false;
            // 
            // ConfirmWorkout
            // 
            this.ConfirmWorkout.Location = new System.Drawing.Point(237, 132);
            this.ConfirmWorkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmWorkout.Name = "ConfirmWorkout";
            this.ConfirmWorkout.Size = new System.Drawing.Size(105, 44);
            this.ConfirmWorkout.TabIndex = 11;
            this.ConfirmWorkout.Text = "Confirm";
            this.ConfirmWorkout.UseVisualStyleBackColor = true;
            this.ConfirmWorkout.Visible = false;
            this.ConfirmWorkout.Click += new System.EventHandler(this.ConfirmWorkout_Click);
            // 
            // AddAWorkOutTitle
            // 
            this.AddAWorkOutTitle.AutoSize = true;
            this.AddAWorkOutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAWorkOutTitle.Location = new System.Drawing.Point(124, 9);
            this.AddAWorkOutTitle.Name = "AddAWorkOutTitle";
            this.AddAWorkOutTitle.Size = new System.Drawing.Size(176, 29);
            this.AddAWorkOutTitle.TabIndex = 8;
            this.AddAWorkOutTitle.Text = "Add a Workout:";
            this.AddAWorkOutTitle.Visible = false;
            // 
            // CloseWorkout
            // 
            this.CloseWorkout.Location = new System.Drawing.Point(80, 132);
            this.CloseWorkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseWorkout.Name = "CloseWorkout";
            this.CloseWorkout.Size = new System.Drawing.Size(105, 44);
            this.CloseWorkout.TabIndex = 9;
            this.CloseWorkout.Text = "Close";
            this.CloseWorkout.UseVisualStyleBackColor = true;
            this.CloseWorkout.Visible = false;
            this.CloseWorkout.Click += new System.EventHandler(this.CloseWorkout_Click);
            // 
            // NoItemsInCategory
            // 
            this.NoItemsInCategory.BackColor = System.Drawing.Color.LightBlue;
            this.NoItemsInCategory.Controls.Add(this.NoItemsInCategoryText);
            this.NoItemsInCategory.Controls.Add(this.CloseButtonNoItemsInCategory);
            this.NoItemsInCategory.Location = new System.Drawing.Point(24, 114);
            this.NoItemsInCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoItemsInCategory.Name = "NoItemsInCategory";
            this.NoItemsInCategory.Size = new System.Drawing.Size(437, 118);
            this.NoItemsInCategory.TabIndex = 32;
            this.NoItemsInCategory.Visible = false;
            // 
            // NoItemsInCategoryText
            // 
            this.NoItemsInCategoryText.AutoSize = true;
            this.NoItemsInCategoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoItemsInCategoryText.Location = new System.Drawing.Point(113, 20);
            this.NoItemsInCategoryText.Name = "NoItemsInCategoryText";
            this.NoItemsInCategoryText.Size = new System.Drawing.Size(205, 29);
            this.NoItemsInCategoryText.TabIndex = 8;
            this.NoItemsInCategoryText.Text = "No Item Selected!";
            this.NoItemsInCategoryText.Visible = false;
            // 
            // CloseButtonNoItemsInCategory
            // 
            this.CloseButtonNoItemsInCategory.Location = new System.Drawing.Point(156, 59);
            this.CloseButtonNoItemsInCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseButtonNoItemsInCategory.Name = "CloseButtonNoItemsInCategory";
            this.CloseButtonNoItemsInCategory.Size = new System.Drawing.Size(105, 44);
            this.CloseButtonNoItemsInCategory.TabIndex = 9;
            this.CloseButtonNoItemsInCategory.Text = "Close";
            this.CloseButtonNoItemsInCategory.UseVisualStyleBackColor = true;
            this.CloseButtonNoItemsInCategory.Visible = false;
            this.CloseButtonNoItemsInCategory.Click += new System.EventHandler(this.CloseButtonNoItemsInCategory_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(261, 630);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 38);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // SavedDayText
            // 
            this.SavedDayText.AutoSize = true;
            this.SavedDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedDayText.ForeColor = System.Drawing.Color.Gold;
            this.SavedDayText.Location = new System.Drawing.Point(159, 684);
            this.SavedDayText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SavedDayText.Name = "SavedDayText";
            this.SavedDayText.Size = new System.Drawing.Size(162, 29);
            this.SavedDayText.TabIndex = 34;
            this.SavedDayText.Text = "SAVED DAY!";
            this.SavedDayText.Visible = false;
            // 
            // CaloriesLeftCounter
            // 
            this.CaloriesLeftCounter.AutoSize = true;
            this.CaloriesLeftCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CaloriesLeftCounter.Location = new System.Drawing.Point(263, 180);
            this.CaloriesLeftCounter.Name = "CaloriesLeftCounter";
            this.CaloriesLeftCounter.Size = new System.Drawing.Size(43, 25);
            this.CaloriesLeftCounter.TabIndex = 35;
            this.CaloriesLeftCounter.Text = "test";
            this.CaloriesLeftCounter.Click += new System.EventHandler(this.CaloriesLeftCounter_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(486, 726);
            this.Controls.Add(this.CaloriesLeftCounter);
            this.Controls.Add(this.SavedDayText);
            this.Controls.Add(this.WorkoutAddPanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PopUpPanel);
            this.Controls.Add(this.WorkoutsRemoveButton);
            this.Controls.Add(this.WorkoutsLabel);
            this.Controls.Add(this.SnacksRemoveButton);
            this.Controls.Add(this.DinnerRemoveButton);
            this.Controls.Add(this.LunchRemoveButton);
            this.Controls.Add(this.BreakfastRemoveButton);
            this.Controls.Add(this.SnacksLabel);
            this.Controls.Add(this.DinnerLabel);
            this.Controls.Add(this.LunchLabel);
            this.Controls.Add(this.BreakfastLabel);
            this.Controls.Add(this.WorkoutItems);
            this.Controls.Add(this.SnackItems);
            this.Controls.Add(this.DinnerItems);
            this.Controls.Add(this.LunchItems);
            this.Controls.Add(this.BreakfastItems);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.heightWeightButton);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.WorkoutsButton);
            this.Controls.Add(this.SnacksButton);
            this.Controls.Add(this.DinnerButton);
            this.Controls.Add(this.LunchButton);
            this.Controls.Add(this.CaloriesLeftLabel);
            this.Controls.Add(this.BreakfastButton);
            this.Controls.Add(this.ChooseDateButton);
            this.Controls.Add(this.CalorieCounterTitle);
            this.Controls.Add(this.NoItemsInCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PopUpPanel.ResumeLayout(false);
            this.PopUpPanel.PerformLayout();
            this.WorkoutAddPanel.ResumeLayout(false);
            this.WorkoutAddPanel.PerformLayout();
            this.NoItemsInCategory.ResumeLayout(false);
            this.NoItemsInCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalorieCounterTitle;
        private System.Windows.Forms.Button ChooseDateButton;
        private System.Windows.Forms.Button BreakfastButton;
        private System.Windows.Forms.Label CaloriesLeftLabel;
        private System.Windows.Forms.Button LunchButton;
        private System.Windows.Forms.Button DinnerButton;
        private System.Windows.Forms.Button SnacksButton;
        private System.Windows.Forms.Button WorkoutsButton;
        private System.Windows.Forms.Label heightText;
        private System.Windows.Forms.Label WeightText;
        private System.Windows.Forms.Button heightWeightButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.ListView BreakfastItems;
        private System.Windows.Forms.ListView LunchItems;
        private System.Windows.Forms.ListView DinnerItems;
        private System.Windows.Forms.ListView SnackItems;
        private System.Windows.Forms.ListView WorkoutItems;
        private System.Windows.Forms.Label BreakfastLabel;
        private System.Windows.Forms.Label LunchLabel;
        private System.Windows.Forms.Label DinnerLabel;
        private System.Windows.Forms.Label SnacksLabel;
        private System.Windows.Forms.Button BreakfastRemoveButton;
        private System.Windows.Forms.Button LunchRemoveButton;
        private System.Windows.Forms.Button DinnerRemoveButton;
        private System.Windows.Forms.Button SnacksRemoveButton;
        private System.Windows.Forms.Label WorkoutsLabel;
        private System.Windows.Forms.Button WorkoutsRemoveButton;
        private System.Windows.Forms.Panel PopUpPanel;
        private System.Windows.Forms.ListBox listBoxforPopUp;
        private System.Windows.Forms.Label breakfastItemPopUpText;
        private System.Windows.Forms.Button closepopupboxbutton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel NoItemsInCategory;
        private System.Windows.Forms.Label NoItemsInCategoryText;
        private System.Windows.Forms.Button CloseButtonNoItemsInCategory;
        private System.Windows.Forms.Panel WorkoutAddPanel;
        private System.Windows.Forms.TextBox caloriesBurnedtext;
        private System.Windows.Forms.TextBox typeOfWorkouttext;
        private System.Windows.Forms.Label calorBurnedText;
        private System.Windows.Forms.Label typeWorkoutText;
        private System.Windows.Forms.Button ConfirmWorkout;
        private System.Windows.Forms.Label AddAWorkOutTitle;
        private System.Windows.Forms.Button CloseWorkout;
        private System.Windows.Forms.Label InvalidCalories;
        private System.Windows.Forms.Label WorkoutInvalid;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SavedDayText;
        private System.Windows.Forms.Label CaloriesLeftCounter;
    }
}

