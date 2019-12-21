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
            View_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            View_Product.RowTemplate.Height = 200;
            View_Product.AllowUserToAddRows = false;

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
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)View_Product.Columns[8];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
             


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

        private void View_Product_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                //To handle 'ConstraintException' default error dialog (for example, unique value)
                if ((e.Exception) is System.Data.ConstraintException)
                {
                    // ErrorText glyphs show
                    View_Product.Rows[e.RowIndex].ErrorText = "must be unique value";
                    View_Product.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "must be unique value";

                    //...or MessageBox show
                    MessageBox.Show(e.Exception.Message, "Error ConstraintException",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Suppress a ConstraintException
                    e.ThrowException = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: dataGridView1_DataError",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
