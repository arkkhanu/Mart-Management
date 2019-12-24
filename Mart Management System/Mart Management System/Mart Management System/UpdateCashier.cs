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
    public partial class UpdateCashier : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public UpdateCashier()
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
                sda = new SqlDataAdapter("select * from Cashier", con);
                sda.Fill(dt);
                View_Cashier.DataSource = dt;


            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CUSTOMER_BOX_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
            loaddata();

        }

        private void UpdateCashier_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void View_Cashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void AddData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                //     string query = "update product set pro_name='" + NAME_TXT.Text + "', pro_comp='" + Int32.Parse(PRO_C_ID.Text) + "', pro_cat='" + Int32.Parse(PRO_TXT.Text) + "', pro_price='" + PRICE_TXT.Text + "', pro_manuf_date='" + MANU_DATE.Text.ToString() + "', pro_exp_date='" + EXP_DATE.Text.ToString() + "', quantity='" + QUANTITY_TXT.Text + "' where pro_id='" + ID_TXT.Text.ToString() + "'";
                string query = "update Cashier set cashier_name='" + NAME_TXT.Text + "', cashier_sal='" + SALARY_TXT.Text + "', cashier_hidate='" + HIREDATE_TXT.Text.ToString() + "', cashier_pass='" + PASSWORD_TXT.Text + "'";
                //  string query = "update product set pro_name='" + NAME_TXT.Text + "', pro_comp='" + Int32.Parse(PRO_C_ID.Text) + "', pro_cat='" + Int32.Parse(PRO_TXT.Text) + "', pro_price='" + PRICE_TXT.Text + "', pro_manuf_date='" + MANU_DATE.Text.ToString() + "', pro_exp_date='" + EXP_DATE.Text.ToString() + "', quantity='" + QUANTITY_TXT.Text + "' where pro_id='" + ID_TXT.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandText = query;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Updated !");
                }


            }
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            CashierOperations co = new CashierOperations();
            this.Hide();
            co.Show();
        }

        private void View_Cashier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (View_Cashier.SelectedRows.Count > 0)
            {
                ID_TXT.Text = View_Cashier.SelectedRows[0].Cells[0].Value.ToString();
                NAME_TXT.Text = View_Cashier.SelectedRows[0].Cells[1].Value.ToString();
                SALARY_TXT.Text = View_Cashier.SelectedRows[0].Cells[2].Value.ToString();
                string pattern = "dd-MM-yyyy";
                HIREDATE_TXT.Value = DateTime.ParseExact(View_Cashier.SelectedRows[0].Cells[3].Value.ToString(), pattern, null);
                PASSWORD_TXT.Text = View_Cashier.SelectedRows[0].Cells[4].Value.ToString();

            }

        }
    }
}
