namespace badmintonProject
{
    partial class signUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        bool userStringCheck;
        bool userPassCheck = true;
        bool userRepasCheck;
        bool userEmailCheck;
        bool saveOK;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tTagline = new System.Windows.Forms.Label();
            this.tTitleSignUp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.userRepas = new System.Windows.Forms.TextBox();
            this.tLineEmail = new System.Windows.Forms.Label();
            this.tLineReenter = new System.Windows.Forms.Label();
            this.userForm = new System.Windows.Forms.TextBox();
            this.closeSignUp = new System.Windows.Forms.Label();
            this.agreeCheckBox = new System.Windows.Forms.CheckBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.tEmail = new System.Windows.Forms.Label();
            this.tReEnter = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.Label();
            this.tUserName = new System.Windows.Forms.Label();
            this.tSignUp = new System.Windows.Forms.Label();
            this.tLineUsername = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.tLinePassword = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Silver;
            this.panelLeft.Controls.Add(this.tTagline);
            this.panelLeft.Controls.Add(this.tTitleSignUp);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(348, 646);
            this.panelLeft.TabIndex = 0;
            // 
            // tTagline
            // 
            this.tTagline.AutoSize = true;
            this.tTagline.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTagline.ForeColor = System.Drawing.Color.Black;
            this.tTagline.Location = new System.Drawing.Point(80, 430);
            this.tTagline.Name = "tTagline";
            this.tTagline.Size = new System.Drawing.Size(175, 22);
            this.tTagline.TabIndex = 2;
            this.tTagline.Text = "wherever you are";
            // 
            // tTitleSignUp
            // 
            this.tTitleSignUp.AutoSize = true;
            this.tTitleSignUp.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTitleSignUp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tTitleSignUp.Location = new System.Drawing.Point(39, 392);
            this.tTitleSignUp.Name = "tTitleSignUp";
            this.tTitleSignUp.Size = new System.Drawing.Size(277, 36);
            this.tTitleSignUp.TabIndex = 1;
            this.tTitleSignUp.Text = "myBus Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.userEmail);
            this.panelRight.Controls.Add(this.userRepas);
            this.panelRight.Controls.Add(this.tLineEmail);
            this.panelRight.Controls.Add(this.tLineReenter);
            this.panelRight.Controls.Add(this.userForm);
            this.panelRight.Controls.Add(this.closeSignUp);
            this.panelRight.Controls.Add(this.agreeCheckBox);
            this.panelRight.Controls.Add(this.signupButton);
            this.panelRight.Controls.Add(this.tEmail);
            this.panelRight.Controls.Add(this.tReEnter);
            this.panelRight.Controls.Add(this.tPassword);
            this.panelRight.Controls.Add(this.tUserName);
            this.panelRight.Controls.Add(this.tSignUp);
            this.panelRight.Controls.Add(this.tLineUsername);
            this.panelRight.Controls.Add(this.userPassword);
            this.panelRight.Controls.Add(this.tLinePassword);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRight.Location = new System.Drawing.Point(348, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(486, 646);
            this.panelRight.TabIndex = 1;
            // 
            // userEmail
            // 
            this.userEmail.BackColor = System.Drawing.SystemColors.Control;
            this.userEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmail.Location = new System.Drawing.Point(61, 394);
            this.userEmail.Margin = new System.Windows.Forms.Padding(5);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(371, 28);
            this.userEmail.TabIndex = 11;
            // 
            // userRepas
            // 
            this.userRepas.BackColor = System.Drawing.SystemColors.Control;
            this.userRepas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userRepas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRepas.Location = new System.Drawing.Point(61, 320);
            this.userRepas.Margin = new System.Windows.Forms.Padding(5);
            this.userRepas.Name = "userRepas";
            this.userRepas.Size = new System.Drawing.Size(371, 28);
            this.userRepas.TabIndex = 9;
            this.userRepas.UseSystemPasswordChar = true;
            // 
            // tLineEmail
            // 
            this.tLineEmail.AutoSize = true;
            this.tLineEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tLineEmail.Location = new System.Drawing.Point(56, 406);
            this.tLineEmail.Name = "tLineEmail";
            this.tLineEmail.Size = new System.Drawing.Size(378, 20);
            this.tLineEmail.TabIndex = 18;
            this.tLineEmail.Text = "_________________________________________";
            // 
            // tLineReenter
            // 
            this.tLineReenter.AutoSize = true;
            this.tLineReenter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tLineReenter.Location = new System.Drawing.Point(54, 332);
            this.tLineReenter.Name = "tLineReenter";
            this.tLineReenter.Size = new System.Drawing.Size(378, 20);
            this.tLineReenter.TabIndex = 17;
            this.tLineReenter.Text = "_________________________________________";
            // 
            // userForm
            // 
            this.userForm.BackColor = System.Drawing.SystemColors.Control;
            this.userForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userForm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userForm.Location = new System.Drawing.Point(61, 169);
            this.userForm.Margin = new System.Windows.Forms.Padding(5);
            this.userForm.Name = "userForm";
            this.userForm.Size = new System.Drawing.Size(371, 28);
            this.userForm.TabIndex = 5;
            // 
            // closeSignUp
            // 
            this.closeSignUp.AutoSize = true;
            this.closeSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeSignUp.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSignUp.ForeColor = System.Drawing.Color.Crimson;
            this.closeSignUp.Location = new System.Drawing.Point(446, 9);
            this.closeSignUp.Name = "closeSignUp";
            this.closeSignUp.Size = new System.Drawing.Size(28, 30);
            this.closeSignUp.TabIndex = 14;
            this.closeSignUp.Text = "X";
            this.closeSignUp.Click += new System.EventHandler(this.closeSignUp_Click);
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.AutoSize = true;
            this.agreeCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreeCheckBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.agreeCheckBox.Location = new System.Drawing.Point(117, 456);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(258, 25);
            this.agreeCheckBox.TabIndex = 13;
            this.agreeCheckBox.Text = "I Agree Terms and Conditions";
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            this.agreeCheckBox.CheckedChanged += new System.EventHandler(this.agreeCheckBox_CheckedChanged);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(61, 540);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(371, 48);
            this.signupButton.TabIndex = 12;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // tEmail
            // 
            this.tEmail.AutoSize = true;
            this.tEmail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tEmail.Location = new System.Drawing.Point(23, 368);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(76, 24);
            this.tEmail.TabIndex = 10;
            this.tEmail.Text = "E-mail:";
            // 
            // tReEnter
            // 
            this.tReEnter.AutoSize = true;
            this.tReEnter.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tReEnter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tReEnter.Location = new System.Drawing.Point(23, 293);
            this.tReEnter.Name = "tReEnter";
            this.tReEnter.Size = new System.Drawing.Size(203, 24);
            this.tReEnter.TabIndex = 8;
            this.tReEnter.Text = "Re-enter Password:";
            // 
            // tPassword
            // 
            this.tPassword.AutoSize = true;
            this.tPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tPassword.Location = new System.Drawing.Point(23, 218);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(109, 24);
            this.tPassword.TabIndex = 6;
            this.tPassword.Text = "Password:";
            // 
            // tUserName
            // 
            this.tUserName.AutoSize = true;
            this.tUserName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tUserName.Location = new System.Drawing.Point(23, 141);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(127, 24);
            this.tUserName.TabIndex = 4;
            this.tUserName.Text = "User Name:";
            // 
            // tSignUp
            // 
            this.tSignUp.AutoSize = true;
            this.tSignUp.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSignUp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tSignUp.Location = new System.Drawing.Point(20, 40);
            this.tSignUp.Name = "tSignUp";
            this.tSignUp.Size = new System.Drawing.Size(143, 42);
            this.tSignUp.TabIndex = 3;
            this.tSignUp.Text = "Sign Up";
            // 
            // tLineUsername
            // 
            this.tLineUsername.AutoSize = true;
            this.tLineUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tLineUsername.Location = new System.Drawing.Point(58, 182);
            this.tLineUsername.Name = "tLineUsername";
            this.tLineUsername.Size = new System.Drawing.Size(378, 20);
            this.tLineUsername.TabIndex = 15;
            this.tLineUsername.Text = "_________________________________________";
            // 
            // userPassword
            // 
            this.userPassword.BackColor = System.Drawing.SystemColors.Control;
            this.userPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(61, 244);
            this.userPassword.Margin = new System.Windows.Forms.Padding(5);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(371, 28);
            this.userPassword.TabIndex = 7;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // tLinePassword
            // 
            this.tLinePassword.AutoSize = true;
            this.tLinePassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tLinePassword.Location = new System.Drawing.Point(54, 256);
            this.tLinePassword.Name = "tLinePassword";
            this.tLinePassword.Size = new System.Drawing.Size(378, 20);
            this.tLinePassword.TabIndex = 16;
            this.tLinePassword.Text = "_________________________________________";
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 646);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signUpForm";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label tTitleSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label tTagline;
        private System.Windows.Forms.Label tSignUp;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Label tEmail;
        private System.Windows.Forms.TextBox userRepas;
        private System.Windows.Forms.Label tReEnter;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label tPassword;
        private System.Windows.Forms.TextBox userForm;
        private System.Windows.Forms.Label tUserName;
        private System.Windows.Forms.Label closeSignUp;
        private System.Windows.Forms.CheckBox agreeCheckBox;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label tLineUsername;
        private System.Windows.Forms.Label tLinePassword;
        private System.Windows.Forms.Label tLineEmail;
        private System.Windows.Forms.Label tLineReenter;
    }
}