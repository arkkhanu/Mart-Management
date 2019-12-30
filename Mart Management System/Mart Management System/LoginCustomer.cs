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
    public partial class LoginCustomer : Form
    {
        //connection string
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public LoginCustomer()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        //method to go back
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            LoginForm c = new LoginForm();
            this.Hide();
            c.Show();
        }

        //method to insert customer data

        private void SIGNUP_Click(object sender, EventArgs e)
        {
            SignUpCustomer cs = new SignUpCustomer();
            this.Hide();
            cs.Show();
        }

       //method to authenticate customer

        private void LOGIN_BUTTON_Click(object sender, EventArgs e)
        {
            //validation
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
                using (SqlConnection con = new SqlConnection(cs))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = new SqlCommand("LoginCustomer", con);
                    da.SelectCommand.Parameters.AddWithValue("@id", ID_TXT.Text);
                    da.SelectCommand.Parameters.AddWithValue("@password", PASSWORD_TXT.Text);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Welcome " + dt.Rows[0].ItemArray[1].ToString());

                            CustomerPortal co = new CustomerPortal();
                            this.Hide();
                            co.Show();
                        }

                        else
                        {
                            MessageBox.Show("Check your username and password");
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
