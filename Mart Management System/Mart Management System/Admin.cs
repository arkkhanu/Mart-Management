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
            AddCompany co = new AddCompany();
            this.Hide();
            co.Show();

        }

        private void CATEGORY_BUTTON_Click(object sender, EventArgs e)
        {
            AddCategoru g = new AddCategoru();
            this.Hide();
            g.Show();
        }
    }
}
