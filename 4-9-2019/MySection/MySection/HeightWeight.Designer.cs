namespace MySection
{
    partial class HeightWeight
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
            this.ChooseHeightWeight = new System.Windows.Forms.Label();
            this.CalorieCounterTitle = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButtonHW = new System.Windows.Forms.Button();
            this.HeightText = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.weightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.heinvalid = new System.Windows.Forms.Label();
            this.weinvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseHeightWeight
            // 
            this.ChooseHeightWeight.AutoSize = true;
            this.ChooseHeightWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseHeightWeight.Location = new System.Drawing.Point(159, 52);
            this.ChooseHeightWeight.Name = "ChooseHeightWeight";
            this.ChooseHeightWeight.Size = new System.Drawing.Size(255, 29);
            this.ChooseHeightWeight.TabIndex = 4;
            this.ChooseHeightWeight.Text = "Choose Height/Weight";
            // 
            // CalorieCounterTitle
            // 
            this.CalorieCounterTitle.AutoSize = true;
            this.CalorieCounterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalorieCounterTitle.Location = new System.Drawing.Point(134, 20);
            this.CalorieCounterTitle.Name = "CalorieCounterTitle";
            this.CalorieCounterTitle.Size = new System.Drawing.Size(300, 32);
            this.CalorieCounterTitle.TabIndex = 3;
            this.CalorieCounterTitle.Text = "SNHU Calorie Counter";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(297, 221);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(128, 42);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButtonHW
            // 
            this.CancelButtonHW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButtonHW.Location = new System.Drawing.Point(140, 221);
            this.CancelButtonHW.Name = "CancelButtonHW";
            this.CancelButtonHW.Size = new System.Drawing.Size(128, 42);
            this.CancelButtonHW.TabIndex = 7;
            this.CancelButtonHW.Text = "Cancel";
            this.CancelButtonHW.UseVisualStyleBackColor = true;
            this.CancelButtonHW.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // HeightText
            // 
            this.HeightText.AutoSize = true;
            this.HeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightText.Location = new System.Drawing.Point(48, 116);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(106, 32);
            this.HeightText.TabIndex = 9;
            this.HeightText.Text = "Height:";
            this.HeightText.Click += new System.EventHandler(this.HeightText_Click);
            // 
            // WeightText
            // 
            this.WeightText.AutoSize = true;
            this.WeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightText.Location = new System.Drawing.Point(42, 171);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(112, 32);
            this.WeightText.TabIndex = 10;
            this.WeightText.Text = "Weight:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightTextBox.Location = new System.Drawing.Point(159, 116);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.heightTextBox.Mask = "0\'00\"";
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(255, 34);
            this.heightTextBox.TabIndex = 13;
            this.heightTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.heightTextBox_MaskInputRejected);
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_MaskInputRejected);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(159, 171);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.weightTextBox.Mask = "000.00";
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(255, 34);
            this.weightTextBox.TabIndex = 14;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_MaskInputRejected);
            // 
            // heinvalid
            // 
            this.heinvalid.AutoSize = true;
            this.heinvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heinvalid.ForeColor = System.Drawing.Color.Red;
            this.heinvalid.Location = new System.Drawing.Point(419, 117);
            this.heinvalid.Name = "heinvalid";
            this.heinvalid.Size = new System.Drawing.Size(168, 32);
            this.heinvalid.TabIndex = 24;
            this.heinvalid.Text = "Invalid Input";
            this.heinvalid.Visible = false;
            this.heinvalid.Click += new System.EventHandler(this.heinvalid_Click);
            // 
            // weinvalid
            // 
            this.weinvalid.AutoSize = true;
            this.weinvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weinvalid.ForeColor = System.Drawing.Color.Red;
            this.weinvalid.Location = new System.Drawing.Point(419, 171);
            this.weinvalid.Name = "weinvalid";
            this.weinvalid.Size = new System.Drawing.Size(168, 32);
            this.weinvalid.TabIndex = 25;
            this.weinvalid.Text = "Invalid Input";
            this.weinvalid.Visible = false;
            // 
            // HeightWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(601, 339);
            this.Controls.Add(this.weinvalid);
            this.Controls.Add(this.heinvalid);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButtonHW);
            this.Controls.Add(this.ChooseHeightWeight);
            this.Controls.Add(this.CalorieCounterTitle);
            this.Name = "HeightWeight";
            this.Text = "HeightWeight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseHeightWeight;
        private System.Windows.Forms.Label CalorieCounterTitle;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButtonHW;
        private System.Windows.Forms.Label HeightText;
        private System.Windows.Forms.Label WeightText;
        private System.Windows.Forms.MaskedTextBox heightTextBox;
        private System.Windows.Forms.MaskedTextBox weightTextBox;
        private System.Windows.Forms.Label heinvalid;
        private System.Windows.Forms.Label weinvalid;
    }
}