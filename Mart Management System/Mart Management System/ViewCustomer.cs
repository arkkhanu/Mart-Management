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
    public partial class ViewCustomer : Form
    {
        string caller;
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public ViewCustomer()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        public ViewCustomer(string c)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            caller = c;
        }
        void loaddata()
        {
            
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            // System.Data.DataSet ds = new System.Data.DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from Customer where cust_id=@cust", con);
                sda.SelectCommand.Parameters.AddWithValue("@cust", txt_id.Value);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                    CUSTOMER_VIEW.DataSource = dt;
                else
                    MessageBox.Show("No customer Found !");


            }
        }
        private void CATEGORY_LBL_Click(object sender, EventArgs e)
        {

        }

        private void CustomerView_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            if (caller == "admin")
            {
                CustomerOperations co = new CustomerOperations();
                this.Hide();
                co.Show();
            }
            else if (caller == "customer")
            {
                CustomerPortal cu = new CustomerPortal();
                this.Hide();
                cu.Show();
            }
        }
    }
}
