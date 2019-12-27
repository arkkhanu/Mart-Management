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
    public partial class CashierOperations : Form
    {
        public CashierOperations()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();


        }

        private void ADD_BTN_Click(object sender, EventArgs e)
        {
            AddCashier ad = new AddCashier();
            this.Hide();
            ad.Show();
        }

        private void DELETE_BTN_Click(object sender, EventArgs e)
        {
            DeleteCashier de = new DeleteCashier();
            this.Hide();
            de.Show();
        }

        private void VIEW_BTN_Click(object sender, EventArgs e)
        {
            ViewCashier ci = new ViewCashier();
            this.Hide();
            ci.Show();
        }

        private void SEARCH_BTN_Click(object sender, EventArgs e)
        {
            UpdateCashier co = new UpdateCashier();
            this.Hide();
            co.Show();
        }

        private void CashierOperations_Load(object sender, EventArgs e)
        {

        }
    }
}
