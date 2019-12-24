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
    public partial class AddCategoru : Form
    {
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

        private void AddCat()
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
        private void AddCategoru_Load(object sender, EventArgs e)
        {

        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            AddCat();
        }
    }
}
