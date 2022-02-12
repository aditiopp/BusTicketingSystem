using System;
using System.Linq;
using System.Windows.Forms;
/// Include this to have a connection to ms acces database
using System.Data.OleDb;

namespace badmintonProject
{
    public partial class signUpForm : Form
    {
        // open connection
        // Using private only for this signUpForm
        private OleDbConnection conn = new OleDbConnection();

        public signUpForm()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\tioyu\Documents\Database2.mdb;Persist Security Info=False;";
            signupButton.Enabled = false;
        }
        
        private void closeSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin fl = new fLogin();
            fl.Show();
        }
        
        private void signupButton_Click(object sender, EventArgs e)
        {
            // Username conditionals statement
            if (userForm.Text.Length <= 10)
            {
                if (userForm.Text.Contains(" "))
                {
                    MessageBox.Show("Username should be filled without space", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else userStringCheck = true;
            }
            else MessageBox.Show("Maximum username characters is 10", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Password conditionals statement
            if (userPassword.Text.Length >= 8)
            {
                char[] myChar = userPassword.Text.ToCharArray();
                for (int i = 0; i < myChar.Length; i++)
                {
                    if (myChar[i] >= 48 && myChar[i] <= 57) continue;
                    else if (myChar[i] >= 65 && myChar[i] <= 90) continue;
                    else if (myChar[i] >= 97 && myChar[i] <= 122) continue;
                    else
                    {
                        MessageBox.Show("No special character on password", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        userPassCheck = false;
                        break;
                    }
                }
            }
            else MessageBox.Show("Password minimum 8 characters", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Repas conditionals statement
            if (userPassword.Text == userRepas.Text) userRepasCheck = true;
            else MessageBox.Show("Please retype password correctly", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Email conditionals statement
            if (userEmail.Text.Contains('@') && userEmail.Text.Contains('.'))
            {
                userEmailCheck = true;
            }
            else MessageBox.Show("Please input correct email address", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Open Connection
            if (userStringCheck && userPassCheck && userRepasCheck && userEmailCheck)
            {
                conn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "Database2.mdb; Persist Security Info = False; ";
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand();
                myCommand.Connection = conn;
                myCommand.CommandText = "select * from regist where username='" + userForm.Text + "' or email= '" + userEmail.Text + "' ";
                OleDbDataReader myRead = myCommand.ExecuteReader();
                int searchCount = 0;
                while (myRead.Read())
                {
                    searchCount++;
                }
                if (searchCount == 1) MessageBox.Show("Username or email has already taken", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (searchCount > 1) MessageBox.Show("Duplicated data on database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else saveOK = true;
                conn.Close();
            }

            if (saveOK)
            {
                conn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "Database2.mdb; Persist Security Info = False; ";
                conn.Open();
                OleDbCommand myCommand = new OleDbCommand();
                myCommand.Connection = conn;
                myCommand.CommandText = "INSERT INTO regist ([username], [password], [email]) VALUES('" + userForm.Text + "','" + userPassword.Text + "','" + userEmail.Text + "')";
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Data saved. Thank you!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                saveOK = false;
                this.Hide();
                fLogin fl = new fLogin();
                fl.Show();
            }
        }

        private void agreeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            signupButton.Enabled = true;
        }
        
    }
}
