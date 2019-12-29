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
    public partial class Cashier : Form
    {
        public static string cashier_Id = "";
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        int total_amt = 0;
        string total_quantity = "";
        int updatedQuantity = 0;
        public Cashier()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            loaddata();
            loadCashid();
            loadCustid();
        }

        void loadCashid()
        {
            if (cashier_Id != "")
            {

                CASH_Combo.Items.Add(cashier_Id.ToString());
            }
        }
        void loadCustid()
        {
            string query = "select cust_id from Customer;";
            SqlConnection con = new SqlConnection(cs);
            

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                CUSTOM_COMBO.Items.Add(rdr["cust_id"].ToString());
                while (rdr.Read())
                {
                    CUSTOM_COMBO.Items.Add( rdr["cust_id"].ToString());
                }
            }
        }
        void loaddata()
        {

            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            // System.Data.DataSet ds = new System.Data.DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from cart", con);
                
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                    CASHIER_VIEW.DataSource = dt;
                else
                    MessageBox.Show("Currently No Data to Show !");


            }
        }

        private void CASHIER_VIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CASHIER_VIEW.SelectedRows.Count > 0)
            {
                TRAN_TXT.Text = CASHIER_VIEW.SelectedRows[0].Cells[0].Value.ToString();
                QUANTITY_TXT.Text = CASHIER_VIEW.SelectedRows[0].Cells[3].Value.ToString();
                PRO_TXT.Text = CASHIER_VIEW.SelectedRows[0].Cells[1].Value.ToString();
                PRICE_TXT.Text = CASHIER_VIEW.SelectedRows[0].Cells[2].Value.ToString();
                ttl_amtBox.Text = CASHIER_VIEW.SelectedRows[0].Cells[7].Value.ToString();
    

            }
        }

        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {
            TRAN_TXT.Text = "";
            QUANTITY_TXT.Text = "";
            PRO_TXT.Text = "";
            PRICE_TXT.Text = "";
            CASHIER_NAME.Text = "";
            DATE.Text = "";
            CASH_Combo.SelectedIndex = -1;
            CUSTOM_COMBO.SelectedIndex = -1;
            

        }

        private void SUBMIT_BTN_Click(object sender, EventArgs e)
        {
            if (TRAN_TXT.Text != ""&& QUANTITY_TXT.Text != ""&& PRO_TXT.Text != ""&& PRICE_TXT.Text != "" && CASH_Combo.SelectedIndex>-1 && CUSTOM_COMBO.SelectedIndex>-1)
            {
                adddata();
                updateingQuantity();
            }
            else
                MessageBox.Show("please Fill Complete Form !");
            
            
        }

        private void getQuantityFunction()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("GetQuantity", con);
                da.SelectCommand.Parameters.AddWithValue("@proname", PRO_TXT.Text);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                try
                {
                    con.Open();
                    da.Fill(dt);
                    //dataGridView1.DataSource = dt;
                    for(int i=0; i<dt.Rows.Count; i++)
                    {
                        string quant = dt.Rows[i][0].ToString();
                        total_quantity = quant;
                        break;
                    }
                    int cartquantity = Convert.ToInt32(QUANTITY_TXT.Text);
                    int remaingQuantity = Convert.ToInt32(total_quantity) - cartquantity;
                    updatedQuantity = remaingQuantity;
                    //MessageBox.Show(updatedQuantity.ToString());
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        void adddata()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("cashierwork", con);
            da.InsertCommand.Parameters.AddWithValue("@cashid", Int32.Parse(CASH_Combo.SelectedItem.ToString()));
            da.InsertCommand.Parameters.AddWithValue("@custid", Int32.Parse(CUSTOM_COMBO.SelectedItem.ToString()));
            da.InsertCommand.Parameters.AddWithValue("@cashname",CASHIER_NAME.Text);
            da.InsertCommand.Parameters.AddWithValue("@proname",PRO_TXT.Text);
            da.InsertCommand.Parameters.AddWithValue("@price", PRICE_TXT.Text);
            da.InsertCommand.Parameters.AddWithValue("@quan", QUANTITY_TXT.Text);
            da.InsertCommand.Parameters.AddWithValue("@date", DATE.Text.ToString());
            da.InsertCommand.Parameters.AddWithValue("@trasid", TRAN_TXT.Text);
            da.InsertCommand.Parameters.AddWithValue("@totalamount", ttl_amtBox.Text);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Record Inserted !");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

               
            }
      }
        

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.Show();
        }

        private void BACK_BOX_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout ?", "Admin",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LoginCashier lc = new LoginCashier();
                this.Hide();
                lc.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getQuantityFunction();
        }
        private void updateingQuantity()
        {
            getQuantityFunction();
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("updatedQuantity", con);
                da.SelectCommand.Parameters.AddWithValue("@proname", PRO_TXT.Text);
                da.SelectCommand.Parameters.AddWithValue("@quantityValue", updatedQuantity.ToString());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                try
                {
                    con.Open();
                    da.Fill(dt);
                    string ss1 = "";
                    dataGridView1.DataSource = dt;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string quant = dt.Rows[i][0].ToString();
                        ss1 = quant;
                        break;
                    }
                    //int cartquantity = Convert.ToInt32(QUANTITY_TXT.Text);
                    //int remaingQuantity = Convert.ToInt32(total_quantity) - cartquantity;
                    //updatedQuantity = remaingQuantity;
                    //MessageBox.Show(ss1);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
