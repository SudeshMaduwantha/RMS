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

namespace RMS.Model
{
    public partial class CategoryAdd : SampleAdd
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if(id == 0)
            {
                qry = "Insert into category Values(@Name)";

            }
            else
            {
                qry ="Update category Set catName = @Name where catID =@id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name",txtName.Text);

            if(MainClass.Sql(qry,ht)>0)
            {
                MessageBox.Show("Saved Successfully!");
                id = 0;
                txtName.Focus();
            }
        }
    }
}
