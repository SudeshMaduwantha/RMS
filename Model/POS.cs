using Microsoft.Data.SqlClient;
using MigraDoc.DocumentObjectModel.Internals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RMS.Model
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string Ordertype = "";
        public int driverID = 0;
        public string customerName = " ";
        public string customerPhone = " ";
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

        /* private void AddItems(int id, string proID, string name, string cat, string price, Image pimage)
         {
             var w = new ucProduct()
             {
                 PName = name,
                 PPrice = price,
                 PCategory = cat,
                 PImage = pimage,
                 id = Convert.ToInt32(proID)
             };
             ProductPanel.Controls.Add(w);

             w.onSelect += (ss, ee) =>
             {
                 var wdg = (ucProduct)ss;

                 foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                 {
                     // Check if the product already exists in the DataGridView
                     if (Convert.ToInt32(item.Cells["dgvproid"].Value) == wdg.id)
                     {
                         item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                         item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                         double.Parse(item.Cells["dgvPrice"].Value.ToString());
                         return;
                     }
                 }
                 // Add new product to first for Sr# and 2nd 0 from id
                 guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, wdg.PPrice, 1, double.Parse(wdg.PPrice) });
                 GetTotal();
             };
         }*/

        private void AddItems(int id, string proID, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)  // Convert proID to int if necessary
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    // Check if the product already exists in the DataGridView
                    if (Convert.ToInt32(item.Cells["proID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        return;
                    }
                }
                // Add new product to first for Sr# and 2nd 0 from id
                guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, wdg.PPrice, 1, double.Parse(wdg.PPrice) });
                GetTotal();
            };
        }




        // getting product from database

        /* private void LoadProduct()
         {
             string qry = "Select * From products inner join category on catID = CategoryID";
             SqlCommand cmd = new SqlCommand(qry, MainClass.con);
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);

             foreach (DataRow item in dt.Rows)
             {
                 Byte[] imagearray = (byte[])item["pimage"];
                 Image productImage = Image.FromStream(new MemoryStream(imagearray));

                 int id = Convert.ToInt32(item["pID"]);
                 string proID = item["proID"].ToString();
                 string name = item["pName"].ToString();
                 string category = item["catName"].ToString();
                 string price = item["pPrice"].ToString();

                 AddItems(id, proID, name, category, price, productImage);
             }
         }*/

        private void LoadProduct()
        {
            string qry = "Select * From products inner join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pimage"];
                Image productImage = Image.FromStream(new MemoryStream(imagearray));

                int id = Convert.ToInt32(item["pID"]);  // Using pID instead of proID
                string name = item["pName"].ToString();
                string category = item["catName"].ToString();
                string price = item["pPrice"].ToString();

                // Assuming pID is what you intended to use for proID
                AddItems(id, id.ToString(), name, category, price, productImage);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            Ordertype = "Delivery";

            AddCustomer addCustomer = new AddCustomer();
            addCustomer.mainID = MainID;
            addCustomer.orderType = Ordertype;
            addCustomer.ShowDialog();

            if (!string.IsNullOrWhiteSpace(addCustomer.txtName.Text)) // Check for non-empty name
            {
                driverID = addCustomer.driverID;
                lblDriverName.Text = " Customer Name: " + addCustomer.txtName.Text + "  Phone: " + addCustomer.txtPhone.Text + "  Driver: " + addCustomer.cbDriver.Text;
                lblDriverName.Visible = true;
                customerName = addCustomer.txtName.Text;
                customerPhone = addCustomer.txtPhone.Text;
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            Ordertype = "Take Away";

            AddCustomer addCustomer = new AddCustomer();
            addCustomer.mainID = MainID;
            addCustomer.orderType = Ordertype;
            addCustomer.ShowDialog();

            if (!string.IsNullOrWhiteSpace(addCustomer.txtName.Text)) // Check for non-empty name
            {
                driverID = addCustomer.driverID;
                lblDriverName.Text = " Customer Name: " + addCustomer.txtName.Text + "  Phone: " + addCustomer.txtPhone.Text;
                lblDriverName.Visible = true;
                customerName = addCustomer.txtName.Text;
                customerPhone = addCustomer.txtPhone.Text;
            }
        }


        private void BtnDin_Click(object sender, EventArgs e)
        {

            Ordertype = "Din In";
            lblDriverName.Visible = false;
            //Need to create form for table selection and waiter selection
            TableSelect tableSelect = new TableSelect();
            tableSelect.ShowDialog();
            // MainClass.BlurBackground(tableSelect);

            if (tableSelect.TableName != "")
            {
                lblTable.Text = tableSelect.TableName;
                lblTable.Visible = true;

            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }

            WaiterSelect waiterSelect = new WaiterSelect();
            waiterSelect.ShowDialog();
            if (waiterSelect.WaiterName != "")
            {
                lblWaiter.Text = waiterSelect.WaiterName;
                lblWaiter.Visible = true;

            }
            else
            {
                lblWaiter.Text = "";
                lblWaiter.Visible = false;
            }
        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            // Save the data in database
            // Create tables
            // Need to add field to database to store additional info

            string qry1 = "";
            string qry2 = "";

            int detailID = 0;

            if (MainID == 0)
            {
                qry1 = @"Insert into tblMain(aDate, aTime, TableName, WaiterName, status, orderType, total, 
                 received, change,driverID,CustName,CustPhone)
                 Values (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, 
                 @change, @driverID, @CustName, @CustPhone);
                 Select SCOPE_IDENTITY()";
            }
            else // Update
            {
                qry1 = @"Update tblMain Set status = @status, total = @total, received = @received, change = @change
                 where MainID = @ID";
            }

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", Ordertype);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text)); // as we are only saving data for kitchen value will update when payment received
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) // Insert
                {
                    qry2 = @"Insert into tblDetails (MainID, proID, qty, price, amount) 
                     Values (@MainID, @proID, @qty, @price, @amount)";
                }
                else // Update
                {
                    qry2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount
                     where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID); // Corrected to use MainID
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["proID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvqty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value)); // Fixed typo

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteScalar();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }
            }

            guna2MessageDialog1.Show("Saved Successfully!");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            lblDriverName.Text = "";
        }

        public int id = 0;

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillList billList = new BillList();
            billList.ShowDialog();

            if (billList.MainID > 0)
            {
                id = billList.MainID;
                MainID = billList.MainID;
                LoadEntres();
            }
        }

        private void LoadEntres()
        {
            string qry = @"Select * from tblMain m
                   inner join tblDetails d on m.MainID = d.MainID
                   inner join products p on p.pID = d.proID
                   where m.MainID = @MainID";

            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            cmd2.Parameters.AddWithValue("@MainID", id); // Use parameterized query to prevent SQL injection

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("No entries found for the specified ID.");
                return;
            }

            if (dt2.Rows[0]["orderType"].ToString() == "Delivery")
            {
                btnDelivery.Checked = true;
                lblWaiter.Visible = false;
                lblTable.Visible = false;
            }
            else if (dt2.Rows[0]["orderType"].ToString() == "Take Away")
            {
                btnDelivery.Checked = true;
                lblWaiter.Visible = false;
                lblTable.Visible = false;
            }
            else
            {
                btnDelivery.Checked = true;
                lblWaiter.Visible = true;
                lblTable.Visible = true;
            }

            guna2DataGridView1.Rows.Clear();

            foreach (DataRow item in dt2.Rows)
            {
                lblTable.Text = item["TableName"].ToString();
                lblWaiter.Text = item["waiterName"].ToString();
                string detailid = item["DetailID"].ToString();
                string proName = item["pName"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = { 0, detailid, proid, proName, qty, price, amount };
                guna2DataGridView1.Rows.Add(obj);
            }

            GetTotal();
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.MainID = id;
            checkout.amt = Convert.ToDouble(lblTotal.Text);
            checkout.ShowDialog();


            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            string qry1 = "";
            string qry2 = "";

            int detailID = 0;

            if (Ordertype == "")
            {
                guna2MessageDialog1.Show("Please Select Order Type!");
                return;
            }

            if (MainID == 0)// Insert
            {
                qry1 = @"Insert into tblMain(aDate, aTime, TableName, WaiterName, status, orderType, total, 
                 received, change,driverID,CustName,CustPhone)
                 Values (@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, 
                 @change, @driverID, @CustName, @CustPhone);
                 Select SCOPE_IDENTITY()";
            }
            else // Update
            {
                qry1 = @"Update tblMain Set status = @status, total = @total, received = @received, change = @change
                 where MainID = @ID";
            }

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", Ordertype);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);

            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0) // Insert
                {
                    qry2 = @"Insert into tblDetails (MainID, proID, qty, price, amount) 
                     Values (@MainID, @proID, @qty, @price, @amount)";
                }
                else // Update
                {
                    qry2 = @"Update tblDetails Set proID = @proID, qty = @qty, price = @price, amount = @amount
                     where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID); // Corrected to use MainID
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["proID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvqty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value)); // Fixed typo

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                cmd2.ExecuteScalar();
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }
            }

            guna2MessageDialog1.Show("Saved Successfully!");
            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "0.00";
            lblDriverName.Text = "";
        }

    }
}
