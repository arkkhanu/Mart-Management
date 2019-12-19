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

namespace Mart_Management_System
{
    public partial class ViewProduct : Form
    {
        
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        

        public ViewProduct()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        void loaddata()
        {
         
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
           // System.Data.DataSet ds = new System.Data.DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from Product where pro_id=@pro",con);
                sda.SelectCommand.Parameters.AddWithValue("@pro", txt_id.Value);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                    View_Product.DataSource = dt;
                else
                    MessageBox.Show("No product Found !");


            }
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {



        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            ProductOperations p = new ProductOperations();
            this.Hide();
            p.Show();
        }

        private void View_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
