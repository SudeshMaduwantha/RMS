﻿using Guna.UI2.WinForms;
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
    public partial class TableView : SampleView
    {
        public TableView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select * from tables where tName like '%" + SearchTxt.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void TableView_Load(object sender, EventArgs e)
        {

            GetData();
        }

        public void btnAdd_Click_1(object sender, EventArgs e)
        {
            // TableAdd tableAdd = new TableAdd();
            //tableAdd.ShowDialog();
            //GetData();
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

                TableAdd tableAdd = new TableAdd();
                tableAdd.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                tableAdd.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                tableAdd.ShowDialog();
                GetData();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from tables where tID = " + id + "";
                    Hashtable hashtable = new Hashtable();
                    MainClass.Sql(qry, hashtable);
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Delete Successfully!");
                    GetData();
                }


            }
        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {
            TableAdd tableAdd = new TableAdd();
            tableAdd.ShowDialog();
            GetData();
        }
    }
}
