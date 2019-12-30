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
using System.Text.RegularExpressions;
using System.Collections.Specialized;
namespace Mart_Management_System
{
    public partial class AddProduct : Form
    {
        bool cname, cprice, cquantity; //bools to check correct input
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString; //connection string
        public AddProduct()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        //method to load all companies and categories
        private void AddProduct_Load(object sender, EventArgs e)
        {

            loadCatrec();
            loadComrec();

        }
        
       //method to clear all fields
        private void clear()
        {
            //  ID_TXT.Text = "";
            NAME_TXT.Text = "";
            Cat_Combo.Items.Clear();
            Product_Combo.Items.Clear();
            PRICE_TXT.Text = "";
            QUANTITY_TXT.Text = "";
            PRO_BOX.Image = null;


        }

        //method to call insert data

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {

            if (cname && cprice && cquantity && Cat_Combo.SelectedIndex>-1 && Product_Combo.SelectedIndex>-1 && imglocation!="" )
            {
                AddData();
            }
            else
                MessageBox.Show("Please Fill the Form Correctly !");

            //   Regexp(@"^(http://www\.)([\w]+)\.([\w]+)$", textBox2, pictureBox2, lblwebsite, "Web Site");
            // Regexp(@"^(0011)(([ ][0-9]{3}){3})$", PRICE_LBL,, "Phone Number");

            //  Regexp(@"^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$",MANU_DATE,date_lbl, "Date");
            
          
            
        }

        //method to insert data
        private void AddData()
        {

            byte[] images = null;
            FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            using (SqlConnection con = new SqlConnection(cs))
            {
                try{
                con.Open();
                DataSet ds = new DataSet();
                string query = "select * from Product where 0=1";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.Fill(ds, "Product");
                DataRow dr = ds.Tables["Product"].NewRow();

                // dr["pro_id"] = ID_TXT.Text;
                dr["pro_name"] = NAME_TXT.Text;

                //stored procedure to get category id
                    SqlCommand catcmd = new SqlCommand("GetCatid", con);
                    catcmd.CommandType = CommandType.StoredProcedure;
                    catcmd.Parameters.AddWithValue("@catname", Cat_Combo.SelectedItem.ToString());
                    try
                    {
                        
                        SqlDataReader catRdr = catcmd.ExecuteReader();
                        catRdr.Read();
                        dr["pro_cat"] = catRdr["cat_id"];
                        catRdr.Close();
                    }
                        catch(Exception Ex)
                    {
                        MessageBox.Show(Ex.Message.ToString());
                    }


                    //stored procedure to get company id
                    SqlCommand concmd = new SqlCommand("GetCompid", con);
                    concmd.CommandType = CommandType.StoredProcedure;
                    concmd.Parameters.AddWithValue("@compname", Product_Combo.SelectedItem.ToString());
                    try
                    {
                        
                        SqlDataReader comRdr = concmd.ExecuteReader();
                        comRdr.Read();
                        dr["pro_comp"] = comRdr["comp_id"];
                        comRdr.Close();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message.ToString());
                    }
            


                dr["pro_price"] = PRICE_TXT.Text;
                dr["pro_manuf_date"] = MANU_DATE.Text.ToString();
                dr["pro_exp_date"] = EXP_DATE.Text.ToString();
                dr["quantity"] = QUANTITY_TXT.Text;
                dr["image"] = images;
                ds.Tables["Product"].Rows.Add(dr);
                new SqlCommandBuilder(adp);
                adp.Update(ds, "Product");



                MessageBox.Show("Record Inserted !");
                clear();

                loadCatrec();
                loadComrec();

                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

        }

        //this method will load categories
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
                    Cat_Combo.Items.Add(rdr["cat_name"].ToString());
                }
            }


        }

        //this method will load companies
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


        //method to go back
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProductOperations p = new ProductOperations();
            this.Hide();
            p.Show();
        }

        //browse button to upload picture

        string imglocation = "";
        private void BRO_BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (* .png)|*.png|jpg files(* .jpg)|* .jpg|All files(*.*)|*.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                PRO_BOX.ImageLocation = imglocation;
            }


        }

        //regular expression for valdation
       
        public void Regexp(string re, TextBox tb, Label lbl, string s)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {

                lbl.ForeColor = Color.Green;
                if (s == "Name ")
                    cname = true;
                else if (s == "Price ")
                    cprice = true;
                else if (s == "Quantity ")
                    cquantity = true;

                lbl.Visible = false;
                
            }
            else
            {

                lbl.ForeColor = Color.Red;
                lbl.Visible = true;
                lbl.Text = s + " Invalid";
                
            }
        }

        //method to validate price
        private void validatePrice(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", PRICE_TXT, price_error_label, "Price ");
        }

        //method to validate name
        private void validateName(object sender, KeyEventArgs e)
        {

            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, lbl_name, "Name ");

        }
        //method to validate quantity

        private void validatequan(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", QUANTITY_TXT, quantity_error_label, "Quantity ");
        }
    }
}
