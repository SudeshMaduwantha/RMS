using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Model
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        public string orderType = "";
        public int mainID = 0;
        public string cusName = " ";

        public int driverID = 0;
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            if (orderType == "Take Away")
            {
                lblDriver.Visible = false;
                cbDriver.Visible = false;
            }

            string qry = "Select staffID 'id',sName 'name'  from staff where sRole = 'Driver'";
            MainClass.CBFill(qry, cbDriver);

            if (mainID > 0)
            {
                cbDriver.SelectedValue = driverID;
            }
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverID = Convert.ToInt32(cbDriver.SelectedIndex);
        }
    }
}
