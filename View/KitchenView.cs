using Microsoft.Data.SqlClient;
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
    public partial class KitchenView : Form
    {
        public KitchenView()
        {
            InitializeComponent();
        }

        private void KitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"Select * from tblMain where status = 'Pending'";

            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                FlowLayoutPanel p1 = new FlowLayoutPanel
                {
                    AutoSize = true,
                    Width = 230,
                    Height = 350,
                    FlowDirection = FlowDirection.TopDown,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10, 10, 10, 10)
                };

                FlowLayoutPanel p2 = new FlowLayoutPanel
                {
                    BackColor = Color.FromArgb(50, 55, 89),
                    AutoSize = true,
                    Width = 230,
                    Height = 125,
                    FlowDirection = FlowDirection.TopDown,
                    Margin = new Padding(0, 0, 0, 0)
                };

                Label lb1 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 10, 3, 0),
                    AutoSize = true,
                    Text = "Table: " + dt1.Rows[i]["TableName"].ToString()
                };

                Label lb2 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true,
                    Text = "Waiter Name: " + dt1.Rows[i]["WaiterName"].ToString()
                };

                Label lb3 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true,
                    Text = "Order Time: " + dt1.Rows[i]["aTime"].ToString()
                };

                Label lb4 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 10),
                    AutoSize = true,
                    Text = "Order Type: " + dt1.Rows[i]["orderType"].ToString()
                };

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);

                p1.Controls.Add(p2);

                // now add products

                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["MainID"].ToString());

                string qry2 = @"Select * from tblMain m
                                inner join tblDetails d on m.MainID = d.MainID
                                inner join products p on p.pID = d.proID
                                where m.MainID = " + mid + "";


                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lb5 = new Label
                    {
                        ForeColor = Color.Black,
                        Margin = new Padding(10, 5, 3, 0),
                        AutoSize = true,
                        Text = "Waiter Name: " + dt1.Rows[i]["WaiterName"].ToString()
                    };

                    int no = j + 1;
                    lb5.Text = " " + no + " " + dt2.Rows[j]["pName"].ToString() + " " + dt2.Rows[j]["qty"].ToString();

                    p1.Controls.Add(lb5);
                }

                // Add button to change the order status

                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.AutoRoundedCorners = true;
                b.Size = new Size(100, 35);
                b.FillColor = Color.FromArgb(241, 85, 126);
                b.Margin = new Padding(30, 5, 3, 10);
                b.Text = "Complete";
                b.Tag = dt1.Rows[i]["MainID"].ToString(); //Store the id

                b.Click += new EventHandler(b_click);
                p1.Controls.Add(b);

                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void b_click(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString());

            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            if(guna2MessageDialog1.Show("Are you want to delete? ") == DialogResult.Yes)
            {
                string qry = @"Update tblMain set status = 'Completed' where MainID =@ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if(MainClass.Sql(qry,ht)>0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Saved Successfully!");

                }

                GetOrders();

            }

        }
    }
}
