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
    public partial class SignUpCustomer : Form
    {
        bool cname, age, pass;
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public SignUpCustomer()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
    
      
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            LoginCustomer cu = new LoginCustomer();
            this.Hide();
            cu.Show();
        }
        private void insertdata()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    DataSet ds = new DataSet();
                    string query = "select * from Customer where 0=1"; //0=1 to get only column names
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);
                    adp.Fill(ds, "Customer");

                    DataRow dr = ds.Tables["Customer"].NewRow();

                    //    dr["cust_id"] = ID_TXT.Text;
                    dr["cust_name"] = NAME_TXT.Text;

                    //getting customer type///
                    string type;
                    if (Male_Radio.Checked)
                        type = Male_Radio.Text.ToString();
                    else
                        type = Female_Radio.Text.ToString();
                    ////////////////////////////
                    ///
                    dr["cust_gender"] = type;
                    dr["cust_age"] = AGE_TXT.Text;



                    dr["cust_address"] = ADDRESS_TXT.Text;
                    dr["cust_email"] = EMAIL_TXT.Text;
                    dr["cust_pass"] = PASSWORD_TXT.Text;


                    ds.Tables["Customer"].Rows.Add(dr);
                    new SqlCommandBuilder(adp);
                    adp.Update(ds, "Customer");

                    MessageBox.Show("Record Inserted !");

                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Please Fill the form Correctly");
            }
            


        }
        public void Regexp(string re, TextBox tb, Label lbl, string s)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {

                lbl.ForeColor = Color.Green;
                if (s == "Name ")
                    cname = true;
                else if (s == "Age ")
                    age = true;
                else if (s == "Password")
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
        private void validatename(object sender, KeyEventArgs e)
        {
            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, name_lbl, "Name ");
        }

        private void validatepass(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", PASSWORD_TXT,pa_lbl , "Password ");
        }

        private void validateAge(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", AGE_TXT, ag_lbl, "Age ");
        }

        private void SignUpCustomer_Load(object sender, EventArgs e)
        {
        
        }

        private void SIGNUP_BUTTON_Click(object sender, EventArgs e)
        {
            if (NAME_TXT.Text!="" && AGE_TXT.Text!="" && ADDRESS_TXT.Text!="" && EMAIL_TXT.Text!="" && PASSWORD_TXT.Text!="" )
            {
                insertdata();
            }
            else
                MessageBox.Show("Please Fill the form Correctly");
        }
    }
}
