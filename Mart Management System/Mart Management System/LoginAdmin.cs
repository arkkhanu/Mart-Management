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
    public partial class LoginAdmin : Form
    {
        //connection string
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public LoginAdmin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }


        //method to go back
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            LoginForm ad = new LoginForm();
            ad.Show();
            Visible = false;


        }

        //method to call stored procedure to authenticate admin

        private void LOGIN_Click(object sender, EventArgs e)
        {
            //validation
            if(ID_TXT.Text == "")
                MessageBox.Show("Please Enter ID");

            if (PASSWORD_TXT.Text == "")

                MessageBox.Show("Please Enter Password");

            else
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
               
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    //paramertised query with stored procedure
                    da.SelectCommand = new SqlCommand("LoginAdmin", con);
                    da.SelectCommand.Parameters.AddWithValue("@id", ID_TXT.Text);
                    da.SelectCommand.Parameters.AddWithValue("@password", PASSWORD_TXT.Text);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Welcome "+dt.Rows[0].ItemArray[1].ToString()); //itemArray work as column
                            Admin ad = new Admin();
                            this.Hide();
                            ad.Show();
                        }

                        else
                        {
                            MessageBox.Show("Check your userid and password");
                            ID_TXT.Text = "";
                            PASSWORD_TXT.Text = "";
                        }

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message.ToString());
                    }

                    


                }

            }

        }

      
    }
}
