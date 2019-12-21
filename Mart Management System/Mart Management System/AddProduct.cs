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
using System.IO;

using System.Data;
using System.Collections.Specialized;
namespace Mart_Management_System
{
    public partial class AddProduct : Form
    {
    
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {


            loadCatrec();
            loadComrec();
           
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void AddData()
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DataSet ds = new DataSet();
                string query = "select * from Product where 0=1";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.Fill(ds, "Product");
          
                DataRow dr = ds.Tables["Product"].NewRow();
            
                dr["pro_id"] = ID_TXT.Text;
               dr["pro_name"] = NAME_TXT.Text;
              
                
                    SqlCommand catCmd = new SqlCommand("select cat_id from category where cat_name='" + Cat_Combo.SelectedItem.ToString() + "'", con);
                    SqlDataReader catRdr= catCmd.ExecuteReader();
                    catRdr.Read();
                    dr["pro_cat"] = catRdr["cat_id"];
                    catRdr.Close();

                    SqlCommand comCmd = new SqlCommand("select comp_id from company where comp_name='" +Product_Combo.SelectedItem.ToString() + "'", con);
                    SqlDataReader comRdr = comCmd.ExecuteReader();
                    comRdr.Read();
                    dr["pro_comp"] = comRdr["comp_id"];
                    comRdr.Close();
                
             
                dr["pro_price"] = PRICE_TXT.Text;
                dr["pro_manuf_date"] =MANU_DATE.Text.ToString();
                dr["pro_exp_date"] = EXP_DATE.Text.ToString();
                dr["quantity"] = QUANTITY_TXT.Text;
                dr["image"] = images;
                ds.Tables["Product"].Rows.Add(dr);
                new SqlCommandBuilder(adp);
                adp.Update(ds,"Product");



                MessageBox.Show("Record Inserted !");

            }
        }

        void loadCatrec()
        {
            string query = "select cat_name from Category;";
            SqlConnection con = new SqlConnection(cs);
            

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                Cat_Combo.Items.Add(rdr["cat_name"].ToString());
                while (rdr.Read())
                {
                    Cat_Combo.Items.Add( rdr["cat_name"].ToString());
                }
            }
            

        }

        void loadComrec()
        {
            string query = "select comp_name from Company";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Product_Combo.Items.Add(rdr["comp_name"].ToString());
                while (rdr.Read())
                {
                    Product_Combo.Items.Add(rdr["comp_name"].ToString());
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cat_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ID_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductOperations p = new ProductOperations();
            this.Hide();
            p.Show();
        }

        private void NAME_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PRODUCT_BOX_Click(object sender, EventArgs e)
        {

        }
        string imglocation = "";
        private void BRO_BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter ="png files (* .png)|*.png|jpg files(* .jpg)|* .jpg|All files(*.*)|*.* ";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                PRO_BOX.ImageLocation = imglocation;
            }


        }
    }
}
