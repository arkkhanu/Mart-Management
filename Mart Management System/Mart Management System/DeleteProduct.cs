using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
           
            using(SqlConnection con=new SqlConnection(cs))
            {
                     string query = "delete product where pro_id=@pro_id";
                     con.Open();
                     SqlDataAdapter adp = new SqlDataAdapter(query,con);

                    adp.DeleteCommand = con.CreateCommand();
                    adp.DeleteCommand.CommandText = query;
                    adp.DeleteCommand.Parameters.AddWithValue("@pro_id", PRODUCT_COMBO.SelectedItem.ToString());
                    adp.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted !");
                    
            }
            loadProd();


        }
        void loadProd()
        {
            PRODUCT_COMBO.Items.Clear();
            string query = "select pro_id from Product";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                PRODUCT_COMBO.Items.Add(rdr["pro_id"].ToString());
                while (rdr.Read())
                {
                    PRODUCT_COMBO.Items.Add(rdr["pro_id"].ToString());
                }
            }

        }
        private void PRODUCT_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            loadProd();
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            ProductOperations o = new ProductOperations();
            this.Hide();
            o.Show();
        }
    }
}
