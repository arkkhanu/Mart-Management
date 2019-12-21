﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Mart_Management_System
{
    public partial class UpdateProduct : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public UpdateProduct()
        {
            InitializeComponent();
        }
        private void IntializeComponent()
        {
            this.view_data.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.view_data_DataError);
        }
        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            loaddata();
           
        }
        void loaddata()
        {
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            view_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view_data.RowTemplate.Height = 200;
           view_data.AllowUserToAddRows = false;
            // System.Data.DataSet ds = new System.Data.DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from Product", con);
                sda.Fill(dt);
                view_data.DataSource = dt;


            }
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)view_data.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;


        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            AddData();
            loaddata();
        }
        
       

       
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            ProductOperations p = new ProductOperations();
            this.Hide();
            p.Show();
        }

        
       
        private void view_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
             //  PRO_BOX.Image.Save(ms, PRO_BOX.Image.RawFormat);
             // byte[] img = ms.ToArray();
            //DataGridViewImageColumn img = new DataGridViewImageColumn;
            //    byte[] img = (byte[])view_data.SelectedRows[0].Cells[8].Value;
            if (view_data.SelectedRows.Count > 0)
            {

                ID_TXT.Text = view_data.SelectedRows[0].Cells[0].Value.ToString();
                NAME_TXT.Text = view_data.SelectedRows[0].Cells[1].Value.ToString();
                PRO_C_ID.Text = view_data.SelectedRows[0].Cells[2].Value.ToString();
                PRO_TXT.Text = view_data.SelectedRows[0].Cells[3].Value.ToString();
                PRICE_TXT.Text = view_data.SelectedRows[0].Cells[4].Value.ToString();
                
                string pattern = "dd-MM-yyyy";
                MANU_DATE.Value = DateTime.ParseExact(view_data.SelectedRows[0].Cells[5].Value.ToString(),pattern,null);
                EXP_DATE.Value = DateTime.ParseExact(view_data.SelectedRows[0].Cells[6].Value.ToString(), pattern, null);

                QUANTITY_TXT.Text = view_data.SelectedRows[0].Cells[7].Value.ToString();
           
                  byte[] data = (byte[])view_data.SelectedRows[0].Cells[8].Value;
                 MemoryStream ms = new MemoryStream(data);
                   PRO_BOX.Image = Image.FromStream(ms);

                //  MemoryStream ms = new MemoryStream();
                //  Bitmap img =(Bitmap)view_data.SelectedRows[0].Cells[8].Value;
                //  PRO_BOX.Image.Save(ms, PRO_BOX.Image.RawFormat);
                // PRO_BOX.Image = Bitmap.FromStream(ms);
                //  MemoryStream ms = new MemoryStream();
                //  PRO_BOX.Image = Image.FromStream(ms);




            }
        }

        private void AddData()
        {
            MemoryStream ms = new MemoryStream();
            PRO_BOX.Image.Save(ms, PRO_BOX.Image.RawFormat);
            byte[] img = ms.ToArray();
            view_data.CurrentRow.Cells[8].Value = img;
        //    byte[] img = null;1
          //  FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
          //  BinaryReader br = new BinaryReader(fs);
          //  img = br.ReadBytes((int)fs.Length);

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
           //     string query = "update product set pro_name='" + NAME_TXT.Text + "', pro_comp='" + Int32.Parse(PRO_C_ID.Text) + "', pro_cat='" + Int32.Parse(PRO_TXT.Text) + "', pro_price='" + PRICE_TXT.Text + "', pro_manuf_date='" + MANU_DATE.Text.ToString() + "', pro_exp_date='" + EXP_DATE.Text.ToString() + "', quantity='" + QUANTITY_TXT.Text + "' where pro_id='" + ID_TXT.Text.ToString() + "'";
               string query = "update product set pro_name='" + NAME_TXT.Text + "', pro_price='" + PRICE_TXT.Text + "', pro_manuf_date='" + MANU_DATE.Text.ToString() + "', pro_exp_date='" + EXP_DATE.Text.ToString() + "', quantity='" + QUANTITY_TXT.Text + "',image='"+img+"' where pro_id='" + ID_TXT.Text.ToString() + "'";
                //  string query = "update product set pro_name='" + NAME_TXT.Text + "', pro_comp='" + Int32.Parse(PRO_C_ID.Text) + "', pro_cat='" + Int32.Parse(PRO_TXT.Text) + "', pro_price='" + PRICE_TXT.Text + "', pro_manuf_date='" + MANU_DATE.Text.ToString() + "', pro_exp_date='" + EXP_DATE.Text.ToString() + "', quantity='" + QUANTITY_TXT.Text + "' where pro_id='" + ID_TXT.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandText = query;
              
                if(cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Record Updated !");
                }
                

            }
        }
        string imglocation = "";
        private void BRO_BTN_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (* .png)|*.png|jpg files(* .jpg)|* .jpg|All files(*.*)|*.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                PRO_BOX.ImageLocation = imglocation;
            }
        }

        private void view_data_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // e.Cancel = true;
            try
            {
                //To handle 'ConstraintException' default error dialog (for example, unique value)
                if ((e.Exception) is System.Data.ConstraintException)
                {
                    // ErrorText glyphs show
                    view_data.Rows[e.RowIndex].ErrorText = "must be unique value";
                    view_data.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "must be unique value";

                    //...or MessageBox show
                    MessageBox.Show(e.Exception.Message, "Error ConstraintException",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Suppress a ConstraintException
                    e.ThrowException = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: dataGridView1_DataError",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
