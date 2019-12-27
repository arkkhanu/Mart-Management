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
    public partial class ViewCashier : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public ViewCashier()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        void loaddata()
        {

            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            // System.Data.DataSet ds = new System.Data.DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from Cashier where cashier_id=@cashier", con);
                sda.SelectCommand.Parameters.AddWithValue("@cashier", txt_id.Value);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                    CASHIER_VIEW.DataSource = dt;
                else
                    MessageBox.Show("No Cashier Found !");


            }
        }

        private void COMPANY_VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CashierOperations co = new CashierOperations();
            this.Hide();
            co.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void ViewCashier_Load(object sender, EventArgs e)
        {

        }
    }
}
