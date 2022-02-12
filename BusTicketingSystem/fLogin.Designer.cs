using LoginForm;

namespace badmintonProject
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.tUsername = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.tUserLogin = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.tCopyright = new System.Windows.Forms.Label();
            this.tDonthave = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Label();
            this.tWelcome = new System.Windows.Forms.Label();
            this.tBadminton = new System.Windows.Forms.Label();
            this.pLogin = new System.Windows.Forms.PictureBox();
            this.closeLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tUsername
            // 
            this.tUsername.AutoSize = true;
            this.tUsername.Location = new System.Drawing.Point(68, 175);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(95, 21);
            this.tUsername.TabIndex = 1;
            this.tUsername.Text = "user name:";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(169, 173);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(216, 27);
            this.usernameInput.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(264, 261);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(121, 34);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // tUserLogin
            // 
            this.tUserLogin.AutoSize = true;
            this.tUserLogin.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserLogin.Location = new System.Drawing.Point(12, 134);
            this.tUserLogin.Name = "tUserLogin";
            this.tUserLogin.Size = new System.Drawing.Size(125, 30);
            this.tUserLogin.TabIndex = 5;
            this.tUserLogin.Text = "user login";
            // 
            // tPassword
            // 
            this.tPassword.AutoSize = true;
            this.tPassword.Location = new System.Drawing.Point(75, 216);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(88, 21);
            this.tPassword.TabIndex = 6;
            this.tPassword.Text = "password:";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(169, 215);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(216, 27);
            this.passwordInput.TabIndex = 7;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // tCopyright
            // 
            this.tCopyright.AutoSize = true;
            this.tCopyright.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCopyright.Location = new System.Drawing.Point(644, 375);
            this.tCopyright.Name = "tCopyright";
            this.tCopyright.Size = new System.Drawing.Size(78, 17);
            this.tCopyright.TabIndex = 8;
            this.tCopyright.Text = "© aditiopp:)";
            // 
            // tDonthave
            // 
            this.tDonthave.AutoSize = true;
            this.tDonthave.Location = new System.Drawing.Point(12, 371);
            this.tDonthave.Name = "tDonthave";
            this.tDonthave.Size = new System.Drawing.Size(203, 21);
            this.tDonthave.TabIndex = 9;
            this.tDonthave.Text = "Don\'t have an account?";
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.Color.DarkViolet;
            this.signUp.Location = new System.Drawing.Point(220, 372);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(63, 19);
            this.signUp.TabIndex = 10;
            this.signUp.Text = "SignUp";
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // tWelcome
            // 
            this.tWelcome.AutoSize = true;
            this.tWelcome.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tWelcome.Location = new System.Drawing.Point(133, 9);
            this.tWelcome.Name = "tWelcome";
            this.tWelcome.Size = new System.Drawing.Size(187, 36);
            this.tWelcome.TabIndex = 11;
            this.tWelcome.Text = "Welcome to";
            // 
            // tBadminton
            // 
            this.tBadminton.AutoSize = true;
            this.tBadminton.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBadminton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tBadminton.Location = new System.Drawing.Point(90, 45);
            this.tBadminton.Name = "tBadminton";
            this.tBadminton.Size = new System.Drawing.Size(277, 36);
            this.tBadminton.TabIndex = 12;
            this.tBadminton.Text = "myBus Application";
            // 
            // pLogin
            // 
            this.pLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pLogin.Image = ((System.Drawing.Image)(resources.GetObject("pLogin.Image")));
            this.pLogin.Location = new System.Drawing.Point(413, 0);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(318, 401);
            this.pLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogin.TabIndex = 4;
            this.pLogin.TabStop = false;
            // 
            // closeLogin
            // 
            this.closeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLogin.FlatAppearance.BorderSize = 0;
            this.closeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLogin.Image = ((System.Drawing.Image)(resources.GetObject("closeLogin.Image")));
            this.closeLogin.Location = new System.Drawing.Point(696, 4);
            this.closeLogin.Name = "closeLogin";
            this.closeLogin.Size = new System.Drawing.Size(31, 31);
            this.closeLogin.TabIndex = 13;
            this.closeLogin.UseVisualStyleBackColor = true;
            this.closeLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // fLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 401);
            this.Controls.Add(this.closeLogin);
            this.Controls.Add(this.tBadminton);
            this.Controls.Add(this.tWelcome);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.tDonthave);
            this.Controls.Add(this.tCopyright);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tUserLogin);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.tUsername);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tUsername;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox pLogin;
        private System.Windows.Forms.Label tUserLogin;
        private System.Windows.Forms.Label tPassword;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label tCopyright;
        private System.Windows.Forms.Label tDonthave;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.Label tWelcome;
        private System.Windows.Forms.Label tBadminton;
        private System.Windows.Forms.Button closeLogin;
    }
}

