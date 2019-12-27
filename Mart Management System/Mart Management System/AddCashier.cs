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
using System.Text.RegularExpressions;

namespace Mart_Management_System
{
    public partial class AddCashier : Form
    {
        bool cname, pass, salary;
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public AddCashier()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        public void Regexp(string re, TextBox tb, Label lbl, string s)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {

                lbl.ForeColor = Color.Green;
                if (s == "Name ")
                    cname = true;
                else if (s == "Salary ")
                    salary = true;
                else if (s == "Password ")
                    pass = true;

                lbl.Visible = false;

            }
            else
            {

                lbl.ForeColor = Color.Red;
                lbl.Visible = true;
                lbl.Text = s + " Invalid";

            }
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

        private void validatesalary(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", SALARY_TXT, sal_lbl, "Salary ");
        }

        private void validatepass(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", PASSWORD_TXT, pass_lbl, "Password ");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            if (cname && salary && HIRE_DATE.Text != "" && pass)
            {
                AddData();
            }
            else
            {
                MessageBox.Show("Please Fill the Form Correctly");
            }
            
        }

        private void validatename(object sender, KeyEventArgs e)
        {
            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, lbl_name, "Name ");
        }
    }
}
