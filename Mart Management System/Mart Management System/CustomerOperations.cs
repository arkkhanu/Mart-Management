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
            this.MaximizeBox = false;
        }

        //method to go back
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
                Admin lc = new Admin();
                this.Hide();
                lc.Show();
            

        }
        //method to call view customer form

        private void VIEW_BTN_Click(object sender, EventArgs e)
        {
            ViewCustomer co = new ViewCustomer("admin");
            this.Hide();
            co.Show();
        }

        //method to call delete customer form
        private void DELETE_BTN_Click(object sender, EventArgs e)
        {
            DeleteCustomer c = new DeleteCustomer();
            this.Hide();
            c.Show();
        }

        //method to call update customer form
        private void SEARCH_BTN_Click(object sender, EventArgs e)
        {
            UpdateCustomer u = new UpdateCustomer();
            this.Hide();
            u.Show();
        }

        //method to call update customer form
        private void button1_Click(object sender, EventArgs e)
        {
            CartCustomer cart = new CartCustomer();
            this.Hide();
            cart.Show();
        }

        
    }
}
