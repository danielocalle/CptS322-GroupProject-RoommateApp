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
        public login()
        {
            InitializeComponent();
        }

        private void introlabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            registerpanel.Visible = true;
            mainpanel.Visible = false;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            registerpanel.Visible = false;
            mainpanel.Visible = true;
            forgotpasswordpanel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void forgotbutton_Click(object sender, EventArgs e)
        {
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
            registerpanel.Visible = false;
            mainpanel.Visible = true;
            forgotpasswordpanel.Visible = false;
        }
    }
}
