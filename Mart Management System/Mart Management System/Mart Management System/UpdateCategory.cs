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
    public partial class UpdateCategory : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
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
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from Category", con);
                sda.Fill(dt);
                cat_data.DataSource = dt;


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
    }
}
