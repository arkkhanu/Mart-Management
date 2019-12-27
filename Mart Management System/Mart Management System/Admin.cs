using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Mart_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

       

        private void Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout ?", "Admin",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LoginAdmin ad = new LoginAdmin();
                this.Hide();
                ad.Show();
            }
            
            
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

        private void TRANSACTION_Click(object sender, EventArgs e)
        {
            TransactionOperation op = new TransactionOperation();
            this.Hide();
            op.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
