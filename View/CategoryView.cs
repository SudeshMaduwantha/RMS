using RMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.View
{
    public partial class CategoryView : SampleView
    {
        public CategoryView()
        {
            InitializeComponent();
        }


        public void GetData()
        {
            string qry = "Select * from category where catName like '%" + SearchTxt.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }


        /* public virtual void btnAdd_Click_1(object sender, EventArgs e)
         {

         }*/


        public void btnAdd_Click_1(object sender, EventArgs e)
        {
            CategoryAdd categoryAdd = new CategoryAdd();
            categoryAdd.ShowDialog();
            GetData();
        }
        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }

}
