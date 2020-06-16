namespace NutritionCalculator
{
    partial class RegisterPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.heightText = new System.Windows.Forms.MaskedTextBox();
            this.weightText = new System.Windows.Forms.MaskedTextBox();
            this.fninvalid = new System.Windows.Forms.Label();
            this.weinvalid = new System.Windows.Forms.Label();
            this.heinvalid = new System.Windows.Forms.Label();
            this.eminvalid = new System.Windows.Forms.Label();
            this.pwinvalid = new System.Windows.Forms.Label();
            this.uninvalid = new System.Windows.Forms.Label();
            this.lninvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create An Account ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Weight(Pounds):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Height(Feet):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(271, 89);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(330, 34);
            this.firstNameText.TabIndex = 1;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(271, 209);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(330, 34);
            this.passwordText.TabIndex = 4;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(271, 249);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(330, 34);
            this.emailText.TabIndex = 5;
            this.emailText.TextChanged += new System.EventHandler(this.emailText_TextChanged);
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(271, 169);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(330, 34);
            this.usernameText.TabIndex = 3;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(271, 129);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(330, 34);
            this.lastNameText.TabIndex = 2;
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(271, 369);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(106, 46);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(383, 369);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 46);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(495, 369);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 46);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // heightText
            // 
            this.heightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightText.Location = new System.Drawing.Point(272, 289);
            this.heightText.Mask = "0\'00\"";
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(329, 34);
            this.heightText.TabIndex = 6;
            this.heightText.TextChanged += new System.EventHandler(this.heightText_MaskInputRejected);
            // 
            // weightText
            // 
            this.weightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightText.Location = new System.Drawing.Point(272, 329);
            this.weightText.Mask = "000.00";
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(329, 34);
            this.weightText.TabIndex = 7;
            this.weightText.TextChanged += new System.EventHandler(this.weightText_MaskInputRejected);
            // 
            // fninvalid
            // 
            this.fninvalid.AutoSize = true;
            this.fninvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fninvalid.ForeColor = System.Drawing.Color.Red;
            this.fninvalid.Location = new System.Drawing.Point(608, 91);
            this.fninvalid.Name = "fninvalid";
            this.fninvalid.Size = new System.Drawing.Size(140, 29);
            this.fninvalid.TabIndex = 21;
            this.fninvalid.Text = "Invalid Input";
            this.fninvalid.Visible = false;
            this.fninvalid.Click += new System.EventHandler(this.fninvalid_Click);
            // 
            // weinvalid
            // 
            this.weinvalid.AutoSize = true;
            this.weinvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weinvalid.ForeColor = System.Drawing.Color.Red;
            this.weinvalid.Location = new System.Drawing.Point(607, 332);
            this.weinvalid.Name = "weinvalid";
            this.weinvalid.Size = new System.Drawing.Size(140, 29);
            this.weinvalid.TabIndex = 22;
            this.weinvalid.Text = "Invalid Input";
            this.weinvalid.Visible = false;
            // 
            // heinvalid
            // 
            this.heinvalid.AutoSize = true;
            this.heinvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heinvalid.ForeColor = System.Drawing.Color.Red;
            this.heinvalid.Location = new System.Drawing.Point(608, 292);
            this.heinvalid.Name = "heinvalid";
            this.heinvalid.Size = new System.Drawing.Size(140, 29);
            this.heinvalid.TabIndex = 23;
            this.heinvalid.Text = "Invalid Input";
            this.heinvalid.Visible = false;
            // 
            // eminvalid
            // 
            this.eminvalid.AutoSize = true;
            this.eminvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eminvalid.ForeColor = System.Drawing.Color.Red;
            this.eminvalid.Location = new System.Drawing.Point(607, 251);
            this.eminvalid.Name = "eminvalid";
            this.eminvalid.Size = new System.Drawing.Size(140, 29);
            this.eminvalid.TabIndex = 24;
            this.eminvalid.Text = "Invalid Input";
            this.eminvalid.Visible = false;
            // 
            // pwinvalid
            // 
            this.pwinvalid.AutoSize = true;
            this.pwinvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwinvalid.ForeColor = System.Drawing.Color.Red;
            this.pwinvalid.Location = new System.Drawing.Point(607, 209);
            this.pwinvalid.Name = "pwinvalid";
            this.pwinvalid.Size = new System.Drawing.Size(140, 29);
            this.pwinvalid.TabIndex = 25;
            this.pwinvalid.Text = "Invalid Input";
            this.pwinvalid.Visible = false;
            // 
            // uninvalid
            // 
            this.uninvalid.AutoSize = true;
            this.uninvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninvalid.ForeColor = System.Drawing.Color.Red;
            this.uninvalid.Location = new System.Drawing.Point(607, 169);
            this.uninvalid.Name = "uninvalid";
            this.uninvalid.Size = new System.Drawing.Size(140, 29);
            this.uninvalid.TabIndex = 26;
            this.uninvalid.Text = "Invalid Input";
            this.uninvalid.Visible = false;
            // 
            // lninvalid
            // 
            this.lninvalid.AutoSize = true;
            this.lninvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lninvalid.ForeColor = System.Drawing.Color.Red;
            this.lninvalid.Location = new System.Drawing.Point(607, 131);
            this.lninvalid.Name = "lninvalid";
            this.lninvalid.Size = new System.Drawing.Size(140, 29);
            this.lninvalid.TabIndex = 27;
            this.lninvalid.Text = "Invalid Input";
            this.lninvalid.Visible = false;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lninvalid);
            this.Controls.Add(this.uninvalid);
            this.Controls.Add(this.pwinvalid);
            this.Controls.Add(this.eminvalid);
            this.Controls.Add(this.heinvalid);
            this.Controls.Add(this.weinvalid);
            this.Controls.Add(this.fninvalid);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MaskedTextBox heightText;
        private System.Windows.Forms.MaskedTextBox weightText;
        private System.Windows.Forms.Label fninvalid;
        private System.Windows.Forms.Label weinvalid;
        private System.Windows.Forms.Label heinvalid;
        private System.Windows.Forms.Label eminvalid;
        private System.Windows.Forms.Label pwinvalid;
        private System.Windows.Forms.Label uninvalid;
        private System.Windows.Forms.Label lninvalid;
    }
}