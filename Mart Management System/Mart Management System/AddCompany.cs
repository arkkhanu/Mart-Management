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
namespace Mart_Management_System
{
    public partial class AddCompany : Form
    {
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
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataSet ds = new DataSet();
                string query = "select * from Company where 0=1";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                adp.Fill(ds, "Company");
                DataRow dr = ds.Tables["Company"].NewRow();

                dr["comp_id"] = ID_COMP.Text;
                dr["comp_name"] = NAME_TXT.Text;
                ds.Tables["Company"].Rows.Add(dr);
                new SqlCommandBuilder(adp);
                adp.Update(ds, "Company");

                MessageBox.Show("Record Inserted !");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            AddComp();
        }
    }
}
