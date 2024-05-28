﻿using Microsoft.Data.SqlClient;
using MigraDoc.DocumentObjectModel.Internals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Model
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProduct();
        }

        private void AddCategory()
        {
            string qry = "Select * From Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();

                    //Event for click
                    b.Click += new EventHandler(_Click);

                    CategoryPanel.Controls.Add(b);
                }

            }

        }

        private void _Click(object? sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(int id, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = id
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    // Check if the product already exists in the DataGridView
                    if (Convert.ToInt32(item.Cells["dgvid"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        return;
                    }
                }
                // Add new product to DataGridView
                guna2DataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.PName, wdg.PPrice, 1, double.Parse(wdg.PPrice) });
                GetTotal();
            };
        }


        // getting product from database

        private void LoadProduct()
        {
            string qry = "Select * From products inner join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pimage"];
                Image productImage = Image.FromStream(new MemoryStream(imagearray));

                int id = Convert.ToInt32(item["pID"]);
                string name = item["pName"].ToString();
                string category = item["catName"].ToString();
                string price = item["pPrice"].ToString();

                AddItems(id, name, category, price, productImage);
            }
        }


        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(SearchTxt.Text.Trim().ToLower());
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // for serial no
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        /* private void GetTotal()
         {
             double tot = 0;
             lblTotal.Text = "";
             foreach  (DataGridView item in guna2DataGridView1.Rows)
             {
                 tot += double.Parse(item.Cell["dgvAmount"].Value.ToString());
             }

             lblTotal.Text = tot.ToString("N2");
         }*/
        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";

            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                // Ensure the row is not a new row
                if (!item.IsNewRow)
                {
                    tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
                }
            }

            lblTotal.Text = tot.ToString("N2");
        }

    }
}
