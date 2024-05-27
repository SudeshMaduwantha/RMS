using RMS.View;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //for accessing MainForm
        static MainForm _obj;
        public static MainForm Instance
        {
            get { if (_obj == null) _obj = new MainForm(); return _obj; }
        }

        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
            _obj = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            AddControls(new CategoryView());
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            AddControls(new TableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new StaffViews());
        }
    }
}
