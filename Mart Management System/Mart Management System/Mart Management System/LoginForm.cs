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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_Click(object sender, EventArgs e)
        {
          
            LoginAdmin adlog=new LoginAdmin();
            this.Hide();
            adlog.Show(); // Existing form close 
   
        }
       

        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            
            LoginCustomer cuslog = new LoginCustomer();
            cuslog.Show();
            //this.Dispose();
        }

        private void CASHIER_Click(object sender, EventArgs e)
        {
            
            LoginCashier cashlog = new LoginCashier();
            cashlog.Show();
            //this.Dispose();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void Admin_Box_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
