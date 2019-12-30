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

namespace Mart_Management_System
{
    public partial class DeleteProduct : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public DeleteProduct()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "delete product from product Inner Join Company on Product.pro_comp=Company.comp_id where Company.comp_name=@comp_name and product.pro_name=@pro_name";
                    con.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);

                    adp.DeleteCommand = con.CreateCommand();
                    adp.DeleteCommand.CommandText = query;
                    adp.DeleteCommand.Parameters.AddWithValue("@pro_name", PRODUCT_COMBO.SelectedItem.ToString());
                    adp.DeleteCommand.Parameters.AddWithValue("@comp_name", pro_cat.SelectedItem.ToString());
                    if(adp.DeleteCommand.ExecuteNonQuery()>0)
                    MessageBox.Show("Record Deleted !");

                    else
                    {
                        MessageBox.Show("Product Not Found in Such Company !");
                    }

                }
                loadProd();
                loadComp();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Please Select Combo to Delete");
            }

        }
        void loadProd()
        {
            PRODUCT_COMBO.Items.Clear();
            string query = "select pro_name from Product";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                PRODUCT_COMBO.Items.Add(rdr["pro_name"].ToString());
                while (rdr.Read())
                {
                    PRODUCT_COMBO.Items.Add(rdr["pro_name"].ToString());
                }
            }

        }
        void loadComp()
        {
            pro_cat.SelectedIndex = -1;
            string query = "select comp_name from Company";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                pro_cat.Items.Add(rdr["comp_name"].ToString());
                while (rdr.Read())
                {
                    pro_cat.Items.Add(rdr["comp_name"].ToString());
                }
            }
        }
        private void PRODUCT_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            loadProd();
            loadComp();
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            ProductOperations o = new ProductOperations();
            this.Hide();
            o.Show();
        }
    }
}
