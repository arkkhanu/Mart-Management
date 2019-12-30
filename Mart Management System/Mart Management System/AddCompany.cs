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
    public partial class AddCompany : Form
    {
        bool cname; //bool to check correct name
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString; //connection string
        public AddCompany()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
      
        //method to add company
        private void AddComp()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    DataSet ds = new DataSet();
                    string query = "select * from Company where 0=1"; //this will load column names
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);
                    adp.Fill(ds, "Company");
                    DataRow dr = ds.Tables["Company"].NewRow();

                    dr["category_id"] = Insertcat();
                    dr["comp_name"] = NAME_TXT.Text;
                    ds.Tables["Company"].Rows.Add(dr);
                    new SqlCommandBuilder(adp);
                    adp.Update(ds, "Company");

                    MessageBox.Show("Record Inserted !");
                    NAME_TXT.Text = "";
                    cat_combo.SelectedIndex = -1;
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        //method to go back
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CompanyOpearations a = new CompanyOpearations();
            this.Hide();
            a.Show();
        }

       //method to call insert function

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            if (NAME_TXT.Text != "")
            {
                AddComp();
            }
            else
                MessageBox.Show(" Company Name cannot empty ");
        }

        //Regular expression for validation
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
        //method to check correct name
        private void Validatename(object sender, KeyEventArgs e)
        {

            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, name_lbl, "Name ");
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {
            loadCat();
        }

        //method to load categories
        void loadCat()
        {
            string query = "select cat_name from Category;";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                cat_combo.Items.Add(rdr["cat_name"].ToString());
                while (rdr.Read())
                {
                    cat_combo.Items.Add(rdr["cat_name"].ToString());
                }
            }

           

        }

        //method to insert id of selected company
        int Insertcat()
        {
            int cat_id=0;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                //stored procedure to get category id
                SqlCommand catcmd = new SqlCommand("GetCatid", con);
                catcmd.CommandType = CommandType.StoredProcedure;
                catcmd.Parameters.AddWithValue("@catname", cat_combo.SelectedItem.ToString());
                try
                {

                    SqlDataReader catRdr = catcmd.ExecuteReader();
                    catRdr.Read();
                    cat_id = Int32.Parse(catRdr["cat_id"].ToString());
                    catRdr.Close();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString());
                }
                
            }
            return cat_id;
        }
    }
}
