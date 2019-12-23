using System;
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
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Mart_Management_System
{
    public partial class UpdateProduct : Form
    {
        bool cname, cprice, cquantity;
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
            view_data.RowTemplate.Height = 150;
           view_data.AllowUserToAddRows = false;
            // System.Data.DataSet ds = new System.Data.DataSet();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                sda = new SqlDataAdapter("select * from Product", con);
                sda.Fill(dt);
                view_data.DataSource = dt;
               
                
            }
           // DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
          //  imageColumn = (DataGridViewImageColumn)view_data.Columns[8];
          //  imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;




        }

        private void UPDATE_Click(object sender, EventArgs e)
        {

            if (cname && cprice && cquantity  && imglocation != "")
            {
                AddData();
                loaddata();
            }
            else
                MessageBox.Show("Please Fill the Form Correctly !");
           
        }

        
       

       
        private void BACK_BOX_Click(object sender, EventArgs e)
        {
            ProductOperations p = new ProductOperations();
            this.Hide();
            p.Show();
        }

        public void Regexp(string re, TextBox tb, Label lbl, string s)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {

                lbl.ForeColor = Color.Green;
                if (s == "Name ")
                    cname = true;
                else if (s == "Price ")
                    cprice = true;
                else if (s == "Quantity ")
                    cquantity = true;

                lbl.Visible = false;

            }
            else
            {

                lbl.ForeColor = Color.Red;
                lbl.Visible = true;
                lbl.Text = s + " Invalid";

            }
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
                ms.Write(data, 0, data.Length);
                ms.Position = 0;
                PRO_BOX.Image = Image.FromStream(ms);

                //MemoryStream ms = new MemoryStream();
                //Bitmap img = (Bitmap)view_data.CurrentRow.Cells[0].Value;
                //img.Save(ms, ImageFormat.Jpeg);
                //PRO_BOX.Image = Image.FromStream(ms);





                // PRO_BOX.Image = (Image)view_data.SelectedRows[0].Cells[8].Value;
                // MemoryStream ms = new MemoryStream();
                //Bitmap img = (Bitmap)view_data.CurrentRow.Cells[0].Value ;
                //  img.Save(ms,PRO_BOX.Image.RawFormat );
                // PRO_BOX.Image =Image.FromStream(ms);
                //  MemoryStream ms = new MemoryStream();
                //  PRO_BOX.Image = Image.FromStream(ms);




            }
        }
       

        private void AddData()
        {
            int Count = 0;
            System.Data.DataSet ds = new System.Data.DataSet();

            byte[] images = null;
            FileStream Stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            //MemoryStream ms = new MemoryStream();
            //PRO_BOX.Image.Save(ms, PRO_BOX.Image.RawFormat);
            //byte[] img = ms.ToArray();
            //view_data.CurrentRow.Cells[8].Value = img;
            
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd;
                string Query = "update Product set pro_name=@pro_name,pro_price=@pro_price,pro_manuf_date=@pro_manuf_date,pro_exp_date=@pro_exp_date,quantity=@quantity,image=@image where pro_id=@pro_id ";

                con.Open();
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@pro_id", ID_TXT.Text);
                cmd.Parameters.AddWithValue("@pro_name", NAME_TXT.Text);
              //  cmd.Parameters.AddWithValue("@pro_comp", Int32.Parse(PRO_C_ID.Text));
             //   cmd.Parameters.AddWithValue("@pro_cat", Int32.Parse(PRO_TXT.Text));
                cmd.Parameters.AddWithValue("@pro_price", PRICE_TXT.Text);
                cmd.Parameters.AddWithValue("@pro_manuf_date", MANU_DATE.Text.ToString());
                cmd.Parameters.AddWithValue("@pro_exp_date", EXP_DATE.Text.ToString());
                cmd.Parameters.AddWithValue("@quantity", QUANTITY_TXT.Text);
                cmd.Parameters.AddWithValue("@image", images);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated");


            }
            PRO_BOX.Image = null;




            //byte[] img = null;
            //  FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            //  BinaryReader br = new BinaryReader(fs);
            //  img = br.ReadBytes((int)fs.Length);

            //MemoryStream ms = new MemoryStream();
            //try
            //{
            //    PRO_BOX.Image.Save(ms, PRO_BOX.Image.RawFormat);
            //    byte[] img = ms.ToArray();
            //    view_data.CurrentRow.Cells[8].Value = img;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //using (SqlConnection con = new SqlConnection(cs))
            //{
            //    con.Open();
            //    //     string query = "update product set pro_name='" + NAME_TXT.Text + "', pro_comp='" + Int32.Parse(PRO_C_ID.Text) + "', pro_cat='" + Int32.Parse(PRO_TXT.Text) + "', pro_price='" + PRICE_TXT.Text + "', pro_manuf_date='" + MANU_DATE.Text.ToString() + "', pro_exp_date='" + EXP_DATE.Text.ToString() + "', quantity='" + QUANTITY_TXT.Text + "' where pro_id='" + ID_TXT.Text.ToString() + "'";
            //    string query = "update product set pro_name='" + NAME_TXT.Text + "', pro_price='" + PRICE_TXT.Text + "', pro_manuf_date='" + MANU_DATE.Text.ToString() + "', pro_exp_date='" + EXP_DATE.Text.ToString() + "', quantity='" + QUANTITY_TXT.Text + "',image='" + PRO_BOX.Image + "' where pro_id='" + ID_TXT.Text.ToString() + "'";
            //    //  string query = "update product set pro_name='" + NAME_TXT.Text + "', pro_comp='" + Int32.Parse(PRO_C_ID.Text) + "', pro_cat='" + Int32.Parse(PRO_TXT.Text) + "', pro_price='" + PRICE_TXT.Text + "', pro_manuf_date='" + MANU_DATE.Text.ToString() + "', pro_exp_date='" + EXP_DATE.Text.ToString() + "', quantity='" + QUANTITY_TXT.Text + "' where pro_id='" + ID_TXT.Text.ToString() + "'";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.CommandText = query;

            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Record Updated !");
            //    }


            //}
        }
        string imglocation = "";

        private void validatename(object sender, KeyEventArgs e)
        {
            Regexp(@"^[a-zA-Z\s]+$", NAME_TXT, price_error_label, "Name ");
        }

        private void validateprice(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", PRICE_TXT, price_error_label, "Price ");
        }

        private void validatequantity(object sender, KeyEventArgs e)
        {
            Regexp(@"^[0-9]+$", QUANTITY_TXT, quantity_error_label, "Quantity ");
        }

        private void quantity_error_label_Click(object sender, EventArgs e)
        {

        }

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
