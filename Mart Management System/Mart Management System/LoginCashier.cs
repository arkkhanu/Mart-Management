﻿using System;
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
            LoginForm lo = new LoginForm();
            this.Hide();
            lo.Show();
        }

        private void LoginCashier_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_BUTTON_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {

                if (ID_TXT.Text == "")
                {
                    MessageBox.Show("Please Enter ID");
                }
                if (PASSWORD_TXT.Text == "")
                {
                    MessageBox.Show("Please Enter Password");
                }
                else
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = new SqlCommand("LoginCashier", con);
                    da.SelectCommand.Parameters.AddWithValue("@id", ID_TXT.Text);
                    da.SelectCommand.Parameters.AddWithValue("@password", PASSWORD_TXT.Text);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Welcome");

                            Cashier cu = new Cashier();
                            this.Hide();
                            cu.Show();
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
