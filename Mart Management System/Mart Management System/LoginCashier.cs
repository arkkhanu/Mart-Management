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
    public partial class LoginCashier : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public LoginCashier()
        {
            InitializeComponent();
        }

        private void ADMIN_BOX_Click(object sender, EventArgs e)
        {

        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginCashier_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_BUTTON_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "Select  * from Cashier where cashier_id = @cashier_id";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(query, con);
                da.SelectCommand.Parameters.AddWithValue("@cashier_id", ID_TXT.Text);
                try
                {
                    da.Fill(dt);



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString());
                }

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Welcome");

                    Cashier cu = new Cashier();
                    this.Hide();
                    cu.Show();
                }
                else
                {
                    MessageBox.Show("Check your username and password");
                    ID_TXT.Text = "";
                    PASSWORD_TXT.Text = "";
                }


            }
        }
    }
}
