using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class SysLogin : Form
    {
        public SysLogin()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(usernametxt.Text, passwordtxt.Text) == false)
            {
                guna2MessageDialog1.Show("Invalid Username or Passward!");
                return;
            }
            else
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.ShowDialog();
            }
        }
    }
}
