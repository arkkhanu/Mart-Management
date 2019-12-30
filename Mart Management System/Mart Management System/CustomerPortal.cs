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
            this.MaximizeBox = false;
        }

        //method to go back
        private void BACK_BOX_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout ?", "Customer",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LoginCustomer lo = new LoginCustomer();
                this.Hide();
                lo.Show();
            }
            
        }

        //method to call add product to cart form
        private void button1_Click(object sender, EventArgs e)
        {
            CartCustomer cart = new CartCustomer();
            this.Hide();
            cart.Show();
        }

        //method to call view customer data form
        private void VIEW_BTN_Click(object sender, EventArgs e)
        {
            ViewCustomer u = new ViewCustomer("customer");
            this.Hide();
            u.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            PurchasedHistory ph = new PurchasedHistory();
            this.Hide();
            ph.Show();
        }

      
    }
}
