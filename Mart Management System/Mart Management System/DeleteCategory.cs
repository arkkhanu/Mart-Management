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
    public partial class DeleteCategory : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public DeleteCategory()
        {
            InitializeComponent();
        }
        void loadCat()
        {
            CATEGORY_COMBO.Items.Clear();
            string query = "select cat_id from Category";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                CATEGORY_COMBO.Items.Add(rdr["cat_id"].ToString());
                while (rdr.Read())
                {
                    CATEGORY_COMBO.Items.Add(rdr["cat_id"].ToString());

                }

            }
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CategoryOperations co = new CategoryOperations();
            this.Hide();
            co.Show();
        }

        private void DeleteCategory_Load(object sender, EventArgs e)
        {
            loadCat();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "delete Category where cat_id=@cat_id";
                    con.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);

                    adp.DeleteCommand = con.CreateCommand();
                    adp.DeleteCommand.CommandText = query;
                    adp.DeleteCommand.Parameters.AddWithValue("@cat_id", CATEGORY_COMBO.SelectedItem.ToString());
                    adp.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted !");
                }
                loadCat();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Please Select Category to Delete");
            }
        }
    }
}
