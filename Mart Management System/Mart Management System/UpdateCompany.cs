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
    public partial class UpdateCompany : Form
    {
        bool cname;
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public UpdateCompany()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            // System.Data.DataSet ds = new System.Data.DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from Company", con);
                sda.Fill(dt);
                View_Company.DataSource = dt;


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


                lbl.Visible = false;

            }
            else
            {

                lbl.ForeColor = Color.Red;
                lbl.Visible = true;
                lbl.Text = s + " Invalid";

            }
        }


        private void UpdateCompany_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void AddData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = "update Company set comp_name='" + NAME_TXT.Text + "' where comp_id='" + ID_TXT.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandText = query;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Updated !");
                    }


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Please Fill the form Correctly");
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            AddData();
            loaddata();
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CompanyOpearations co = new CompanyOpearations();
            this.Hide();
            co.Show();
        }

        private void View_Company_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (View_Company.SelectedRows.Count > 0)
            {
                ID_TXT.Text = View_Company.SelectedRows[0].Cells[0].Value.ToString();
                NAME_TXT.Text = View_Company.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void validatename(object sender, KeyEventArgs e)
        {
            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, Name_lbl, "Name ");
        }
    }
}
