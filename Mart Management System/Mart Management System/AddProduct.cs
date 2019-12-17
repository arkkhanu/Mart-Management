using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

using System.Data;
using System.Collections.Specialized;
namespace Mart_Management_System
{
    public partial class AddProduct : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            AddCategoru cs = new AddCategoru();
            Cat_Combo.DataSource = ds.Tables["Category"];
            Cat_Combo.DisplayMember = ("cat_id");
            Cat_Combo.ValueMember = ("cat_id");
            AddCompany ss = new AddCompany();
            Product_Combo.DataSource = ds.Tables["Company"];
            Product_Combo.DisplayMember = ("comp_id");
            Product_Combo.ValueMember = ("comp_id");
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void AddData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataSet ds = new DataSet();
                string query = "select * from Product where 0=1";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.Fill(ds, "Product");
          
                DataRow dr = ds.Tables["Product"].NewRow();
            
                dr["pro_id"] = ID_TXT.Text;
               dr["pro_name"] = NAME.Text;
              
             
                dr["pro_price"] = PRICE_TXT.Text;
              dr["pro_manuf_date"] = MANU_DATE;
                dr["pro_exp_date"] = EXP_DATE;
                dr["quantity"] = QUANTITY_TXT.Text;
                ds.Tables["Product"].Rows.Add(dr);
                new SqlCommandBuilder(adp);
                adp.Update(ds,"Product");



                MessageBox.Show("Record Inserted !");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
