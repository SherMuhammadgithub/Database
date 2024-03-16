using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            UserPassTb.Text = "";
            UserNameTb.Text = "";
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UserNameTb.Text == "" || UserPassTb.Text == "")
            {
                MessageBox.Show("Enter a UserName and Password");
            }
            else if(UserNameTb.Text == "Admin" && UserPassTb.Text == "Admin")
            {
                Employees home = new Employees();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password");
                UserPassTb.Text = "";
                UserNameTb.Text = "";
            }
        }

        private void UserNameTb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
