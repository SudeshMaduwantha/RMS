using Guna.UI2.WinForms;
using RMS.Model;
using System;
using System.Collections;
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
    public partial class ProductView : SampleView
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "select pID,pName,pPrice,CategoryID,c.catName from products p inner join category c on c.catID = p.CategoryID where pName like '%" + SearchTxt.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvCatID);
            lb.Items.Add(dgvCat);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void TableView_Load(object sender, EventArgs e)
        {

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

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                
                ProductAdd productAdd = new ProductAdd();
                productAdd.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                productAdd.cID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                productAdd.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                productAdd.txtPrice.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPrice"].Value);
                productAdd.cbCat.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvCat"].Value);
                productAdd.ShowDialog();
                GetData();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from products where pID = " + id + "";
                    Hashtable hashtable = new Hashtable();
                    MainClass.Sql(qry, hashtable);
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Delete Successfully!");
                    GetData();
                }


            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ProductAdd productAdd = new ProductAdd();
            productAdd.ShowDialog();
            GetData();
        }
    }

}
