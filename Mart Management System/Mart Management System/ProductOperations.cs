﻿using System;
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
    public partial class ProductOperations : Form
    {
        public ProductOperations()
        {
            InitializeComponent();
        }

        private void ADD_BTN_Click(object sender, EventArgs e)
        {
            AddProduct ad = new AddProduct();
            this.Hide();
            ad.Show();
        }

        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            Admin op = new Admin();
            this.Hide();
            op.Show();
        }
    }
}
