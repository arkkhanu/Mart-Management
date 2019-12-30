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
    public partial class UpdateCustomer : Form
    {
        bool cname, age;
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public UpdateCustomer()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        void loaddata()
        {
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            // System.Data.DataSet ds = new System.Data.DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from Customer", con);
                sda.Fill(dt);
                view_data.DataSource = dt;


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
             

                lbl.Visible = false;

            }
            else
            {

                lbl.ForeColor = Color.Red;
                lbl.Visible = true;
                lbl.Text = s + " Invalid";

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CustomerOperations co = new CustomerOperations();
            this.Hide();
            co.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (NAME_TXT.Text != "" && AGE_TXT.Text != "" && EMAIL_TXT.Text != "" && PASS_TXT.Text != "")
            {
                AddData();
                loaddata();
            }
            else
                MessageBox.Show("Please Fill the form Correctly");
        }

     

        private void view_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (view_data.SelectedRows.Count > 0)
            {
                ID_TXT.Text = view_data.SelectedRows[0].Cells[0].Value.ToString();
                NAME_TXT.Text = view_data.SelectedRows[0].Cells[1].Value.ToString();
                GENDER.Text = view_data.SelectedRows[0].Cells[2].Value.ToString();
                AGE_TXT.Text = view_data.SelectedRows[0].Cells[3].Value.ToString();
                ADDRESS_TXT.Text = view_data.SelectedRows[0].Cells[4].Value.ToString();
                EMAIL_TXT.Text = view_data.SelectedRows[0].Cells[5].Value.ToString();
                PASS_TXT.Text = view_data.SelectedRows[0].Cells[6].Value.ToString();
               
            }
        }

        private void validatename(object sender, KeyEventArgs e)
        {
            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, Name_lbl, "Name ");
        }

        private void validateage(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", AGE_TXT, Age_lbl, "Password ");
        }

        private void AddData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    
                    string query = "update Customer set cust_name='" + NAME_TXT.Text + "', cust_gender='" + GENDER.Text + "', cust_age='" + AGE_TXT.Text + "', cust_address='" + ADDRESS_TXT.Text + "',cust_email='" + EMAIL_TXT.Text + "',cust_pass='" + PASS_TXT.Text + "' where cust_id='" + ID_TXT.Text.ToString() + "'";
                   
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandText = query;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Updated !");
                    }


                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
