namespace MySection
{
    partial class AdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CalorieAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MealCreatedText = new System.Windows.Forms.Label();
            this.DuplicateMealText = new System.Windows.Forms.Label();
            this.CreateMealButton = new System.Windows.Forms.Button();
            this.CancelMealButton = new System.Windows.Forms.Button();
            this.NoSpacesText = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalorieCounterTitle
            // 
            this.CalorieCounterTitle.AutoSize = true;
            this.CalorieCounterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalorieCounterTitle.Location = new System.Drawing.Point(69, 9);
            this.CalorieCounterTitle.Name = "CalorieCounterTitle";
            this.CalorieCounterTitle.Size = new System.Drawing.Size(300, 32);
            this.CalorieCounterTitle.TabIndex = 1;
            this.CalorieCounterTitle.Text = "SNHU Calorie Counter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Page";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(167, 190);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(224, 22);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CalorieAmountTextBox
            // 
            this.CalorieAmountTextBox.Location = new System.Drawing.Point(167, 237);
            this.CalorieAmountTextBox.Name = "CalorieAmountTextBox";
            this.CalorieAmountTextBox.Size = new System.Drawing.Size(224, 22);
            this.CalorieAmountTextBox.TabIndex = 4;
            this.CalorieAmountTextBox.TextChanged += new System.EventHandler(this.CalorieAmountTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calorie Amount:";
            // 
            // MealCreatedText
            // 
            this.MealCreatedText.AutoSize = true;
            this.MealCreatedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealCreatedText.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.MealCreatedText.Location = new System.Drawing.Point(70, 319);
            this.MealCreatedText.Name = "MealCreatedText";
            this.MealCreatedText.Size = new System.Drawing.Size(297, 29);
            this.MealCreatedText.TabIndex = 7;
            this.MealCreatedText.Text = "Meal Created Successfully";
            this.MealCreatedText.Visible = false;
            this.MealCreatedText.Click += new System.EventHandler(this.MealCreatedText_Click);
            // 
            // DuplicateMealText
            // 
            this.DuplicateMealText.AutoSize = true;
            this.DuplicateMealText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuplicateMealText.ForeColor = System.Drawing.Color.Red;
            this.DuplicateMealText.Location = new System.Drawing.Point(70, 319);
            this.DuplicateMealText.Name = "DuplicateMealText";
            this.DuplicateMealText.Size = new System.Drawing.Size(315, 29);
            this.DuplicateMealText.TabIndex = 8;
            this.DuplicateMealText.Text = "Duplicate Meal: Not Created";
            this.DuplicateMealText.Visible = false;
            this.DuplicateMealText.Click += new System.EventHandler(this.DuplicateMealText_Click);
            // 
            // CreateMealButton
            // 
            this.CreateMealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMealButton.Location = new System.Drawing.Point(75, 275);
            this.CreateMealButton.Name = "CreateMealButton";
            this.CreateMealButton.Size = new System.Drawing.Size(105, 31);
            this.CreateMealButton.TabIndex = 9;
            this.CreateMealButton.Text = "Create";
            this.CreateMealButton.UseVisualStyleBackColor = true;
            this.CreateMealButton.Click += new System.EventHandler(this.CreateMealButton_Click);
            // 
            // CancelMealButton
            // 
            this.CancelMealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelMealButton.Location = new System.Drawing.Point(204, 275);
            this.CancelMealButton.Name = "CancelMealButton";
            this.CancelMealButton.Size = new System.Drawing.Size(105, 31);
            this.CancelMealButton.TabIndex = 10;
            this.CancelMealButton.Text = "Cancel";
            this.CancelMealButton.UseVisualStyleBackColor = true;
            this.CancelMealButton.Click += new System.EventHandler(this.CancelMealButton_Click);
            // 
            // NoSpacesText
            // 
            this.NoSpacesText.AutoSize = true;
            this.NoSpacesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSpacesText.ForeColor = System.Drawing.Color.Red;
            this.NoSpacesText.Location = new System.Drawing.Point(158, 171);
            this.NoSpacesText.Name = "NoSpacesText";
            this.NoSpacesText.Size = new System.Drawing.Size(136, 17);
            this.NoSpacesText.TabIndex = 11;
            this.NoSpacesText.Text = "No Spaces in Name!";
            this.NoSpacesText.Visible = false;
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.ItemHeight = 16;
            this.CategoryBox.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snacks"});
            this.CategoryBox.Location = new System.Drawing.Point(167, 90);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(120, 68);
            this.CategoryBox.TabIndex = 12;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category:";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(425, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.NoSpacesText);
            this.Controls.Add(this.CancelMealButton);
            this.Controls.Add(this.CreateMealButton);
            this.Controls.Add(this.DuplicateMealText);
            this.Controls.Add(this.MealCreatedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalorieAmountTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalorieCounterTitle);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalorieCounterTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CalorieAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MealCreatedText;
        private System.Windows.Forms.Label DuplicateMealText;
        private System.Windows.Forms.Button CreateMealButton;
        private System.Windows.Forms.Button CancelMealButton;
        private System.Windows.Forms.Label NoSpacesText;
        private System.Windows.Forms.ListBox CategoryBox;
        private System.Windows.Forms.Label label4;
    }
}