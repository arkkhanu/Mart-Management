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
    public partial class AddCategoru : Form
    {
        bool cname;
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public AddCategoru()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CategoryOperations a = new CategoryOperations();
            this.Hide();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void AddCat()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    DataSet ds = new DataSet();
                    string query = "select * from Category where 0=1";
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);
                    adp.Fill(ds, "Category");
                    DataRow dr = ds.Tables["Category"].NewRow();


                    dr["cat_name"] = NAME_TXT.Text;
                    ds.Tables["Category"].Rows.Add(dr);
                    new SqlCommandBuilder(adp);
                    adp.Update(ds, "Category");

                    MessageBox.Show("Record Inserted !");
                    NAME_TXT.Text = "";
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
        private void AddCategoru_Load(object sender, EventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            if (NAME_TXT.Text != "")
            {
                AddCat();
            }
            else
                MessageBox.Show("Name Cannot empty");
            
        }

        private void validatename(object sender, KeyEventArgs e)
        {

            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, Name_lbl, "Name ");
        }
    }
}
