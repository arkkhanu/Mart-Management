using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
namespace Mart_Management_System
{
    public partial class AddCompany : Form
    {
        bool cname;
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public AddCompany()
        {
            InitializeComponent();
        }
      
        private void NAME_TXT_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void AddComp()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    DataSet ds = new DataSet();
                    string query = "select * from Company where 0=1";
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);
                    adp.Fill(ds, "Company");
                    DataRow dr = ds.Tables["Company"].NewRow();


                    dr["comp_name"] = NAME_TXT.Text;
                    ds.Tables["Company"].Rows.Add(dr);
                    new SqlCommandBuilder(adp);
                    adp.Update(ds, "Company");

                    MessageBox.Show("Record Inserted !");
                    NAME_TXT.Text = "";
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CompanyOpearations a = new CompanyOpearations();
            this.Hide();
            a.Show();
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            if (NAME_TXT.Text != "")
            {
                AddComp();
            }
            else
                MessageBox.Show(" Company Name cannot empty ");
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
        private void Validatename(object sender, KeyEventArgs e)
        {

            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, name_lbl, "Name ");
        }
    }
}
