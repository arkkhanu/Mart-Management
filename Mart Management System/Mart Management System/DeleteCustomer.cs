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
    public partial class DeleteCustomer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public DeleteCustomer()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        void loadCust()
        {
            CUSTOMER_COMBO.Items.Clear();
            string query = "select cust_id from Customer";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                CUSTOMER_COMBO.Items.Add(rdr["cust_id"].ToString());
                while (rdr.Read())
                {
                    CUSTOMER_COMBO.Items.Add(rdr["cust_id"].ToString());
                }
            }

        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
            loadCust();

        }

        private void DELETE_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "delete Customer where cust_id=@cust_id";
                    con.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);

                    adp.DeleteCommand = con.CreateCommand();
                    adp.DeleteCommand.CommandText = query;
                    adp.DeleteCommand.Parameters.AddWithValue("@cust_id", CUSTOMER_COMBO.SelectedItem.ToString());
                    adp.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted !");
                }
                loadCust();
            }
            catch
            {
                MessageBox.Show("Please Select Customer ID to Delete");
            }
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CustomerOperations co = new CustomerOperations();
            this.Hide();
            co.Show();
        }
    }
}
