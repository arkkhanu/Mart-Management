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
    public partial class CategoryOperations : Form
    {
        public CategoryOperations()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        //method to call add category form
        private void ADD_BTN_Click(object sender, EventArgs e)
        {
            AddCategory ad = new AddCategory();
            this.Hide();
            ad.Show();

        }

        //method to go back
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        //method to call delete category form
        private void DELETE_BTN_Click(object sender, EventArgs e)
        {
            DeleteCategory de = new DeleteCategory();
            this.Hide();
            de.Show();
        }

        //method to call view category form

        private void VIEW_BTN_Click(object sender, EventArgs e)
        {
            ViewCategory vi = new ViewCategory();
            this.Hide();
            vi.Show();
        }

        //method to call update category form
        private void SEARCH_BTN_Click(object sender, EventArgs e)
        {
            UpdateCategory cat = new UpdateCategory();
            this.Hide();
            cat.Show();
        }

        
    }
}
