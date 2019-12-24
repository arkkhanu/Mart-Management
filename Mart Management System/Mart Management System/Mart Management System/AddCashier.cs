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
    public partial class AddCashier : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public AddCashier()
        {
            InitializeComponent();
        }
        private void AddData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataSet ds = new DataSet();
                string query = "select * from Cashier where 0=1";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.Fill(ds, "Cashier");

                DataRow dr = ds.Tables["Cashier"].NewRow();

                dr["cashier_id"] = ID_TXT.Text.ToString();
                dr["cashier_name"] = NAME_TXT.Text;
           

                dr["cashier_sal"] = SALARY_TXT.Text;
                dr["cashier_hidate"] = HIRE_DATE.Text.ToString();
       
                dr["cashier_pass"] = PASSWORD_TXT.Text.ToString();
                ds.Tables["Cashier"].Rows.Add(dr);
                new SqlCommandBuilder(adp);
                adp.Update(ds, "Cashier");



                MessageBox.Show("Record Inserted !");

            }
        }

        private void AddCashier_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CashierOperations co = new CashierOperations();
            this.Hide();
            co.Show();
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            AddData();
        }
    }
}
