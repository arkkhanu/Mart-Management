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
    public partial class CompanyOpearations : Form
    {
        public CompanyOpearations()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        //method to go back
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        //method to call add company operations
        private void ADD_BTN_Click(object sender, EventArgs e)
        {
            AddCompany a = new AddCompany();
            this.Hide();
            a.Show();
        }

        //method to call delete company operations
        private void DELETE_BTN_Click(object sender, EventArgs e)
        {
            DeleteCompany co = new DeleteCompany();
            this.Hide();
            co.Show();
        }

        //method to call view company operations
        private void VIEW_BTN_Click(object sender, EventArgs e)
        {
            ViewCompany v = new ViewCompany();
            this.Hide();
            v.Show();
        }

        //method to call update company form
        private void UPDATE_BUTTON_Click(object sender, EventArgs e)
        {
            UpdateCompany co = new UpdateCompany();
            this.Hide();
            co.Show();
        }

        
    }
}