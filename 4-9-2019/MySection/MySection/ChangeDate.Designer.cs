namespace MySection
{
    partial class ChangeDate
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
            this.ChooseDate = new System.Windows.Forms.Label();
            this.CancelButtonChangeDate = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // CalorieCounterTitle
            // 
            this.CalorieCounterTitle.AutoSize = true;
            this.CalorieCounterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalorieCounterTitle.Location = new System.Drawing.Point(59, 9);
            this.CalorieCounterTitle.Name = "CalorieCounterTitle";
            this.CalorieCounterTitle.Size = new System.Drawing.Size(300, 32);
            this.CalorieCounterTitle.TabIndex = 1;
            this.CalorieCounterTitle.Text = "SNHU Calorie Counter";
            // 
            // ChooseDate
            // 
            this.ChooseDate.AutoSize = true;
            this.ChooseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDate.Location = new System.Drawing.Point(101, 43);
            this.ChooseDate.Name = "ChooseDate";
            this.ChooseDate.Size = new System.Drawing.Size(203, 32);
            this.ChooseDate.TabIndex = 2;
            this.ChooseDate.Text = "Choose a Date";
            // 
            // CancelButtonChangeDate
            // 
            this.CancelButtonChangeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonChangeDate.Location = new System.Drawing.Point(74, 303);
            this.CancelButtonChangeDate.Name = "CancelButtonChangeDate";
            this.CancelButtonChangeDate.Size = new System.Drawing.Size(128, 42);
            this.CancelButtonChangeDate.TabIndex = 5;
            this.CancelButtonChangeDate.Text = "Cancel";
            this.CancelButtonChangeDate.UseVisualStyleBackColor = true;
            this.CancelButtonChangeDate.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(231, 303);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(128, 42);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(83, 84);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 7;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // ChangeDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(414, 399);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButtonChangeDate);
            this.Controls.Add(this.ChooseDate);
            this.Controls.Add(this.CalorieCounterTitle);
            this.Name = "ChangeDate";
            this.Text = "ChangeDate";
            this.Load += new System.EventHandler(this.ChangeDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CalorieCounterTitle;
        private System.Windows.Forms.Label ChooseDate;
        private System.Windows.Forms.Button CancelButtonChangeDate;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.MonthCalendar Calendar;
    }
}