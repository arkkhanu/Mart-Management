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
    public partial class DeleteCashier : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public DeleteCashier()
        {
            InitializeComponent();
        }
        void loadCash()
        {
            CASHIER_COMBO.Items.Clear();
            string query = "select cashier_id from Cashier";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                CASHIER_COMBO.Items.Add(rdr["cashier_id"].ToString());
                while (rdr.Read())
                {
                    CASHIER_COMBO.Items.Add(rdr["cashier_id"].ToString());

                }

            }
        }
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CashierOperations co = new CashierOperations();
            this.Hide();
            co.Show();
        }

        private void DeleteCashier_Load(object sender, EventArgs e)
        {
            loadCash();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "delete Cashier where cashier_id=@cashier_id";
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter(query, con);

                adp.DeleteCommand = con.CreateCommand();
                adp.DeleteCommand.CommandText = query;
                adp.DeleteCommand.Parameters.AddWithValue("@cashier_id", CASHIER_COMBO.SelectedItem.ToString());
                adp.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record Deleted !");
            }
            loadCash();
        }
    }
}
