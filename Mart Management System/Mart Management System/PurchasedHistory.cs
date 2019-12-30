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
    public partial class PurchasedHistory : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public static string cust_id = "";
        public PurchasedHistory()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        //method to load purchased history

        private void PurchasedHistory_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            // System.Data.DataSet ds = new System.Data.DataSet();
            try
            {

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    sda = new SqlDataAdapter("select customer_id,product_name,date,quantity,totalAmount from Details where customer_id=@cust", con);
                    sda.SelectCommand.Parameters.AddWithValue("@cust", Int32.Parse(cust_id));
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                        history_grid.DataSource = dt;
                    else
                        MessageBox.Show("No History Found !");


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method to go back
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CustomerPortal cp = new CustomerPortal();
            this.Hide();
            cp.Show();
        }
    }
}
