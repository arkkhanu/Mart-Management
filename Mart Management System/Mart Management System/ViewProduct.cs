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
                sda = new SqlDataAdapter("select * from Product",con);
                sda.Fill(dt);
                View_Product.DataSource = dt;


            }
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {


            loaddata();



        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            ProductOperations p = new ProductOperations();
            this.Hide();
            p.Show();
        }
    }
}
