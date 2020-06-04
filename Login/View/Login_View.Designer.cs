namespace Project.View
{
    partial class Login_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_View));
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.Password_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.Usernamer_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.LabelPassword = new MetroFramework.Controls.MetroLabel();
            this.LabelUsername = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(351, 550);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(137, 23);
            this.LoginButton.TabIndex = 23;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Password_TextBox
            // 
            // 
            // 
            // 
            this.Password_TextBox.CustomButton.Image = null;
            this.Password_TextBox.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.Password_TextBox.CustomButton.Name = "";
            this.Password_TextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Password_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password_TextBox.CustomButton.TabIndex = 1;
            this.Password_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password_TextBox.CustomButton.UseSelectable = true;
            this.Password_TextBox.CustomButton.Visible = false;
            this.Password_TextBox.Lines = new string[0];
            this.Password_TextBox.Location = new System.Drawing.Point(453, 424);
            this.Password_TextBox.MaxLength = 32767;
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '●';
            this.Password_TextBox.PromptText = "Enter your password";
            this.Password_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password_TextBox.SelectedText = "";
            this.Password_TextBox.SelectionLength = 0;
            this.Password_TextBox.SelectionStart = 0;
            this.Password_TextBox.ShortcutsEnabled = true;
            this.Password_TextBox.Size = new System.Drawing.Size(200, 30);
            this.Password_TextBox.TabIndex = 22;
            this.Password_TextBox.UseSelectable = true;
            this.Password_TextBox.UseSystemPasswordChar = true;
            this.Password_TextBox.WaterMark = "Enter your password";
            this.Password_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Usernamer_TextBox
            // 
            // 
            // 
            // 
            this.Usernamer_TextBox.CustomButton.Image = null;
            this.Usernamer_TextBox.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.Usernamer_TextBox.CustomButton.Name = "";
            this.Usernamer_TextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Usernamer_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Usernamer_TextBox.CustomButton.TabIndex = 1;
            this.Usernamer_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Usernamer_TextBox.CustomButton.UseSelectable = true;
            this.Usernamer_TextBox.CustomButton.Visible = false;
            this.Usernamer_TextBox.Lines = new string[0];
            this.Usernamer_TextBox.Location = new System.Drawing.Point(453, 363);
            this.Usernamer_TextBox.MaxLength = 32767;
            this.Usernamer_TextBox.Name = "Usernamer_TextBox";
            this.Usernamer_TextBox.PasswordChar = '\0';
            this.Usernamer_TextBox.PromptText = "Enter your username";
            this.Usernamer_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Usernamer_TextBox.SelectedText = "";
            this.Usernamer_TextBox.SelectionLength = 0;
            this.Usernamer_TextBox.SelectionStart = 0;
            this.Usernamer_TextBox.ShortcutsEnabled = true;
            this.Usernamer_TextBox.Size = new System.Drawing.Size(200, 30);
            this.Usernamer_TextBox.TabIndex = 21;
            this.Usernamer_TextBox.UseSelectable = true;
            this.Usernamer_TextBox.WaterMark = "Enter your username";
            this.Usernamer_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Usernamer_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(349, 429);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(66, 20);
            this.LabelPassword.TabIndex = 20;
            this.LabelPassword.Text = "Password";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(349, 368);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(73, 20);
            this.LabelUsername.TabIndex = 19;
            this.LabelUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(506, 550);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(137, 23);
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "Exit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Login_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Usernamer_TextBox);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login_View";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_View_Form_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroTextBox Password_TextBox;
        private MetroFramework.Controls.MetroTextBox Usernamer_TextBox;
        private MetroFramework.Controls.MetroLabel LabelPassword;
        private MetroFramework.Controls.MetroLabel LabelUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}