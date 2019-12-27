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
using Microsoft.VisualBasic;

namespace Mart_Management_System
{
    public partial class CartCustomer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public CartCustomer()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void CUSTOMER_LBL_Click(object sender, EventArgs e)
        {

        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CustomerOperations cuo = new CustomerOperations();
            this.Hide();
            cuo.Show();
        }

        private void CartCustomer_Load(object sender, EventArgs e)
        {
            loadCatrec();
            loadComrec();
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
                cat_combo.Items.Add(rdr["cat_name"].ToString());
                while (rdr.Read())
                {
                    cat_combo.Items.Add(rdr["cat_name"].ToString());
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
                comp_combo.Items.Add(rdr["comp_name"].ToString());
                while (rdr.Read())
                {
                    comp_combo.Items.Add(rdr["comp_name"].ToString());
                }
            }

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            int cat = -1, comp = -1;

            if (cat_combo.SelectedIndex > -1 && comp_combo.SelectedIndex > -1)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand catCmd = new SqlCommand("select cat_id from category where cat_name='" + cat_combo.SelectedItem.ToString() + "'", con);
                    SqlDataReader catRdr = catCmd.ExecuteReader();
                    catRdr.Read();
                    cat = Int32.Parse(catRdr["cat_id"].ToString());
                    catRdr.Close();

                    SqlCommand comCmd = new SqlCommand("select comp_id from company where comp_name='" + comp_combo.SelectedItem.ToString() + "'", con);
                    SqlDataReader comRdr = comCmd.ExecuteReader();
                    comRdr.Read();
                    comp = Int32.Parse(comRdr["comp_id"].ToString());
                    comRdr.Close();
                }


                //SqlDataAdapter sda;
                //DataTable dt = new DataTable();
                //// System.Data.DataSet ds = new System.Data.DataSet();
                //using (SqlConnection con = new SqlConnection(cs))
                //{
                //    con.Open();
                //    sda = new SqlDataAdapter("select pro_name, pro_price, quantity from Product where pro_comp='" + comp + "' and pro_cat='" + cat + "'", con);

                //    sda.Fill(dt);
                //    if (dt.Rows.Count > 0)
                //        show_pro.DataSource = dt;
                //    else
                //        MessageBox.Show("No product Found !");


                //}

                using (SqlConnection con = new SqlConnection(cs))
                {

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select pro_name, pro_price from Product where pro_comp='" + comp + "' and pro_cat='" + cat + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow item in ds.Tables[0].Rows)
                        {
                            pro_list.Items.Add(item["pro_name"].ToString() + " Rs." + item["pro_price"]);

                        }
                    }
                    else
                        MessageBox.Show("No product Found !");
                }

            }
            else
                MessageBox.Show("Please Select Category And Company First !");
        }
        void clear()
        {
            cat_combo.SelectedIndex = -1;
            comp_combo.SelectedIndex = -1;
            id_box.Text = "";
            phone_box.Text = "";
            email_box.Text = "";
        }

        private void btn_addPro_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {

                    foreach (object item in pro_list.CheckedItems)
                    {
                        DataSet ds = new DataSet();
                        string query = "select * from Cart where 0=1";
                        SqlDataAdapter adp = new SqlDataAdapter(query, con);
                        adp.Fill(ds, "cart");

                        DataRow dr = ds.Tables["cart"].NewRow();

                        string product = "";
                        int price = 0;
                        int quantity = 1;



                        //product contain string i.e only product name i.e string before Rs.
                        product = item.ToString().Substring(0, item.ToString().IndexOf("Rs."));

                        //price contain string after the product name
                        price = Int32.Parse(item.ToString().Substring(product.Length + 3)) * quantity;

                        quantity = Int32.Parse(Interaction.InputBox("Enter Quantity of " + product + " ", "Quantity", "1", -1, -1));


                        dr["product"] = product;
                        dr["price"] = price;
                        dr["quantity"] = quantity;
                        dr["id"] = id_box.Text.ToString();
                        dr["phone"] = phone_box.Text.ToString();
                        dr["email"] = email_box.Text.ToString();

                        ds.Tables["Cart"].Rows.Add(dr);
                        new SqlCommandBuilder(adp);
                        adp.Update(ds, "Cart");


                    }
                    MessageBox.Show("Record Inserted !");
                    clear();

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }

        }
    }
}
