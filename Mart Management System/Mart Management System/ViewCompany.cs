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
    public partial class ViewCompany : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public ViewCompany()
        {
            InitializeComponent();
        }
        void loaddata()
        {

            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            // System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    sda = new SqlDataAdapter("select * from Company where comp_id=@comp", con);
                    sda.SelectCommand.Parameters.AddWithValue("@comp", txt_id.Value);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                        COMPANY_VIEW.DataSource = dt;
                    else
                        MessageBox.Show("No Company Found !");


                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void COMPANY_VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CompanyOpearations co = new CompanyOpearations();
            this.Hide();
            co.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void ViewCompany_Load(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
