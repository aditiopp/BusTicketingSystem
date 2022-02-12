using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using LoginForm;

namespace badmintonProject
{
    public partial class fLogin : Form
    {
        // open connection
        // Using private only for this signUpForm
        private OleDbConnection conn = new OleDbConnection();
        

        public fLogin()
        {
            InitializeComponent();
            // Call Ms. Access database put in constructor of the class
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\tioyu\Documents\Database2.mdb;Persist Security Info=False;";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye! Have a good day:)", "myBuss Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm ss = new signUpForm();
            ss.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Generate Connection
            conn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0; Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "Database2.mdb; Persist Security Info = False; ";
            conn.Open();
            OleDbCommand myCommand = new OleDbCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "select * from regist where username='" + usernameInput.Text + "' and password='" + passwordInput.Text + "' ";
            OleDbDataReader myRead = myCommand.ExecuteReader();
            int countIndex = 0;
            bool successLogin = false;
            while (myRead.Read())
            {
                countIndex++;
            }
            if (countIndex == 1)
            {
                MessageBox.Show("Username and password is correct", "Information - Login Form", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                successLogin = true;
            }
            else MessageBox.Show("Account Not Found. Please Sign up.", "Warning - Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();

            // Assign user name id
            string userName = usernameInput.Text;
            ClassLogin.UserData myIns = new ClassLogin.UserData();
            myIns._userID = usernameInput.Text;
                       


            // If the account is matched, open main interface
            if (successLogin == true)
            {
                this.Hide();
                mainInterface asd = new mainInterface();
                asd.Show();
            }



        }
    }
}
