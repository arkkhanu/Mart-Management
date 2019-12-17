using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Mart_Management_System
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            LoginForm ad = new LoginForm();
            ad.Show();
            Visible = false;


        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=DESKTOP-53HPM07\SQLEXPRESS;Initial Catalog=Mart_Management_System;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select  * from Admin where admin_id = @admin_id", con);
            da.SelectCommand.Parameters.AddWithValue("admin_id", ID_TXT.Text);
            try
            {
                da.Fill(dt);
               


            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
         
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Welcome");
                Admin ad = new Admin();
                this.Hide();
                ad.Show();
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
