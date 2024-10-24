using RoommateAppLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomMate_WinFormsApp
{
    public partial class login : Form
    {
        Form main;

        public login()
        {
            InitializeComponent();
            main = new Form1();
            mainpanel.Visible = true;
            registerpanel.Visible = false;
            forgotpasswordpanel.Visible = false;
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            usernametext.Clear();
            passwordtext.Clear();
            registerpanel.Visible = true;
            mainpanel.Visible = false;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            registerpanel.Visible = false;
            mainpanel.Visible = true;
            forgotpasswordpanel.Visible = false;
        }

        private void forgotbutton_Click(object sender, EventArgs e)
        {
            usernametext.Clear();
            passwordtext.Clear();
            registerpanel.Visible = false;
            mainpanel.Visible = false;
            forgotpasswordpanel.Visible = true;
        }

        private void backbuttonforgot_Click(object sender, EventArgs e)
        {
            registerpanel.Visible = false;
            mainpanel.Visible = true;
            forgotpasswordpanel.Visible = false;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (SQLiteDataAccess.ChangePassword(new AccountLoginInfo(forgotusernametext.Text,
                textBox2.Text, textBox1.Text)))
            {
                registerpanel.Visible = false;
                mainpanel.Visible = true;
                forgotpasswordpanel.Visible = false;

                forgotusernametext.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Error Resetting Password", "Try Again", MessageBoxButtons.OK);
            }

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (SQLiteDataAccess.VerifyLogin(new AccountLoginInfo(usernametext.Text,
                passwordtext.Text)))
            {
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful", "Try Again", MessageBoxButtons.OK);
            }
        }

        private void createaccbutton_Click(object sender, EventArgs e)
        {
            if (usernameregistertext.Text == string.Empty || passwordregistertext.Text == string.Empty || 
                textBox4.Text == string.Empty || nametext.Text == string.Empty || lastnametext.Text == string.Empty)
            {
                MessageBox.Show("All Fields Must Be Answered", "Account Creation Unsuccessful", MessageBoxButtons.OK);
                return;
            }
            if (SQLiteDataAccess.CreateAccount(new AccountLoginInfo(usernameregistertext.Text,
                passwordregistertext.Text, textBox4.Text, nametext.Text, lastnametext.Text)))
            {
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Account Creation Unsuccessful", "Try Again", MessageBoxButtons.OK);
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
