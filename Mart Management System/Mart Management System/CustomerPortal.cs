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
    public partial class CustomerPortal : Form
    {
        public CustomerPortal()
        {
            InitializeComponent();
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            LoginCustomer lo = new LoginCustomer();
            this.Hide();
            lo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CartCustomer cart = new CartCustomer();
            this.Hide();
            cart.Show();
        }

        private void VIEW_BTN_Click(object sender, EventArgs e)
        {
            CustomerView u = new CustomerView();
            this.Hide();
            u.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
