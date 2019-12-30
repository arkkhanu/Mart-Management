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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox=false;
        }

        
        //method to call admin login page

        private void ADMIN_Click(object sender, EventArgs e)
        {
             
            LoginAdmin adlog=new LoginAdmin();
            this.Hide();
            adlog.Show(); // Existing form close 
   
        }

        //method to call customer login page


        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            
            LoginCustomer cuslog = new LoginCustomer();
            this.Hide();
            cuslog.Show();
            
        }

        //method to call cashier login page

        private void CASHIER_Click(object sender, EventArgs e)
        {
            
            LoginCashier cashlog = new LoginCashier();
            this.Hide();
            cashlog.Show();
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
