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
    public partial class DeleteCompany : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public DeleteCompany()
        {
            InitializeComponent();
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CompanyOpearations co = new CompanyOpearations();
            this.Hide();
            co.Show();
        }

        private void COMPANY_COMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void loadComp()
        {
            COMPANY_COMBO.Items.Clear();
            string query = "select comp_id from Company";
            SqlConnection con = new SqlConnection(cs);


            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                COMPANY_COMBO.Items.Add(rdr["comp_id"].ToString());
                while (rdr.Read())
                {
                    COMPANY_COMBO.Items.Add(rdr["comp_id"].ToString());
                }
            }

        }
        private void DeleteCompany_Load(object sender, EventArgs e)
        {
            loadComp();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "delete Company where comp_id=@comp_id";
                    con.Open();
                    SqlDataAdapter adp = new SqlDataAdapter(query, con);

                    adp.DeleteCommand = con.CreateCommand();
                    adp.DeleteCommand.CommandText = query;
                    adp.DeleteCommand.Parameters.AddWithValue("@comp_id", COMPANY_COMBO.SelectedItem.ToString());
                    adp.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted !");
                }
                loadComp();
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Please Select Company Id to Delete ");
            }
        }
      
    }
}