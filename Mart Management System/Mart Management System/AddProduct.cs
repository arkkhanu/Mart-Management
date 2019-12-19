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
            //DataSet ds = new DataSet();
            //AddCategoru cs = new AddCategoru();
            //Cat_Combo.DataSource = ds.Tables["Category"];
            //Cat_Combo.DisplayMember = ("cat_id");
            //Cat_Combo.ValueMember = ("cat_id");
            //AddCompany ss = new AddCompany();
            //Product_Combo.DataSource = ds.Tables["Company"];
            //Product_Combo.DisplayMember = ("comp_id");
            //Product_Combo.ValueMember = ("comp_id");


            loadCatrec();
            loadComrec();
           
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
               dr["pro_comp"] = Int32.Parse(Product_Combo.SelectedItem.ToString());
                dr["pro_cat"] = Int32.Parse( Cat_Combo.SelectedItem.ToString());
             
                dr["pro_price"] = PRICE_TXT.Text;
                dr["pro_manuf_date"] =MANU_DATE.Text.ToString();
                dr["pro_exp_date"] = EXP_DATE.Text.ToString();
                dr["quantity"] = QUANTITY_TXT.Text;
                ds.Tables["Product"].Rows.Add(dr);
                new SqlCommandBuilder(adp);
                adp.Update(ds,"Product");



                MessageBox.Show("Record Inserted !");

            }
        }

        void loadCatrec()
        {
            string query = "select cat_id from Category;";
            SqlConnection con = new SqlConnection(cs);
            

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                Cat_Combo.Items.Add(rdr["cat_id"].ToString());
                while (rdr.Read())
                {
                    Cat_Combo.Items.Add(rdr["cat_id"].ToString());
                }
            }
            

        }

        void loadComrec()
        {
            string query = "select comp_id from Company";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Product_Combo.Items.Add(rdr["comp_id"].ToString());
                while (rdr.Read())
                {
                    Product_Combo.Items.Add(rdr["comp_id"].ToString());
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cat_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ID_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductOperations p = new ProductOperations();
            this.Hide();
            p.Show();
        }

        private void NAME_TXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
