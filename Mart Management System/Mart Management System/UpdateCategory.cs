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
    public partial class UpdateCategory : Form
    {
        bool cname;
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public UpdateCategory()
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


                lbl.Visible = false;

            }
            else
            {

                lbl.ForeColor = Color.Red;
                lbl.Visible = true;
                lbl.Text = s + " Invalid";

            }
        }
        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (NAME_TXT.Text != "")
            {
                AddData();
                LoadData();
            }
            else
                MessageBox.Show("Please Fill the Form Correctly");
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
           LoadData();
        }

        private void AddData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string query = "update category set cat_name='" + NAME_TXT.Text + "' where cat_id='" + ID_TXT.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandText = query;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Updated !");
                }


            }
        }
        void LoadData()
        {
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            // System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    sda = new SqlDataAdapter("select * from Category", con);
                    sda.Fill(dt);
                    cat_data.DataSource = dt;


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
         }

        private void cat_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cat_data.SelectedRows.Count > 0)
            {
                ID_TXT.Text = cat_data.SelectedRows[0].Cells[0].Value.ToString();
                NAME_TXT.Text = cat_data.SelectedRows[0].Cells[1].Value.ToString();
               
            }
        }

        private void validatename(object sender, KeyEventArgs e)
        {
            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, Name_lbl, "Name ");
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CategoryOperations co = new CategoryOperations();
            this.Hide();
            co.Show();
        }
    }
}
