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
    public partial class SearchUpdateProduct : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public SearchUpdateProduct()
        {
            InitializeComponent();
        }

        private void SearchUpdateProduct_Load(object sender, EventArgs e)
        {
            load();
           
        }
        void load()
        {
            string query = "select pro_id from Product;";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                ID_Combo.Items.Add(rdr["pro_id"].ToString());
                while (rdr.Read())
                {
                    ID_Combo.Items.Add(rdr["pro_id"].ToString());
                }
            }


        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }
        int Count = 0;
        System.Data.DataSet ds = new System.Data.DataSet();
        private void UpdateRecord()
        {
           
            
           

            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Product SET pro_name=@a2,pro_price=@a5,pro_manu_date=@a6,pro_exp_date=@a7,quantity=@a8 where @id=pro_id", con);

                    //  cmd.Parameters.Add("a1", ID_Combo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("a2", NAME.Text);
                    cmd.Parameters.AddWithValue("a5", PRICE_TXT.Text);
                    cmd.Parameters.AddWithValue("a6", MANU_DATE.Text.ToString());
                    cmd.Parameters.AddWithValue("a7", EXP_DATE.Text.ToString());
                    cmd.Parameters.AddWithValue("a8", QUANTITY_TXT.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated");
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                
               

            }

        }

        private void ID_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            ProductOperations p = new ProductOperations();
            this.Hide();
            p.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
