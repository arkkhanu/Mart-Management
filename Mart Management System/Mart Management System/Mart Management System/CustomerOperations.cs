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
    public partial class CustomerOperations : Form
    {
        public CustomerOperations()
        {
            InitializeComponent();
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void CustomerOperations_Load(object sender, EventArgs e)
        {

        }

        private void VIEW_BTN_Click(object sender, EventArgs e)
        {
            CustomerView co = new CustomerView();
            this.Hide();
            co.Show();
        }

        private void DELETE_BTN_Click(object sender, EventArgs e)
        {
            DeleteCustomer c = new DeleteCustomer();
            this.Hide();
            c.Show();
        }

        private void SEARCH_BTN_Click(object sender, EventArgs e)
        {
            UpdateCustomer u = new UpdateCustomer();
            this.Hide();
            u.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CartCustomer cart = new CartCustomer();
            this.Hide();
            cart.Show();
        }
    }
}
