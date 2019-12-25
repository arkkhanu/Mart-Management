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
    public partial class TransactionOperation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public TransactionOperation()
        {
            InitializeComponent();
        }

        private void TransactionOperation_Load(object sender, EventArgs e)
        {
            loaddata();
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
                    TRANSACTION_VIEW.DataSource = dt;
                else
                    MessageBox.Show("Currently No Data to Show !");


            }
        }
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }
    }
}
