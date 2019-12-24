using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mart_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            LoginAdmin ad = new LoginAdmin();
            this.Hide();
            ad.Show();
        }

        private void PRODUCT_BUTTON_Click(object sender, EventArgs e)
        {
            ProductOperations op = new ProductOperations();
            this.Hide();
            op.Show();
        }

        private void COMPANY_BUTTON_Click(object sender, EventArgs e)
        {
            CompanyOpearations co = new CompanyOpearations();
            this.Hide();
            co.Show();

        }

        private void CATEGORY_BUTTON_Click(object sender, EventArgs e)
        {
            CategoryOperations g = new CategoryOperations();
            this.Hide();
            g.Show();
        }

        private void CASHIER_BUTTON_Click(object sender, EventArgs e)
        {
            CashierOperations co = new CashierOperations();
            this.Hide();
            co.Show();
        }

        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            CustomerOperations cu = new CustomerOperations();
            this.Hide();
            cu.Show();
        }
    }
}
