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
    public partial class ViewCategory : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public ViewCategory()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            try
            {
                SqlDataAdapter sda;
                DataTable dt = new DataTable();
                // System.Data.DataSet ds = new System.Data.DataSet();
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    sda = new SqlDataAdapter("select * from Category where cat_id=@cat", con);
                    sda.SelectCommand.Parameters.AddWithValue("@cat", txt_id.Value);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                        CATEGORY_VIEW.DataSource = dt;
                    else
                        MessageBox.Show("No Category Found !");


                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void ViewCategory_Load(object sender, EventArgs e)
        {
            
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CategoryOperations co = new CategoryOperations();
            this.Hide();
            co.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
