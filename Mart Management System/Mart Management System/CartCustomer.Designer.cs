namespace Mart_Management_System
{
    partial class CartCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.LINE_LBL2 = new System.Windows.Forms.Label();
            this.CUSTOMER_LBL = new System.Windows.Forms.Label();
            this.CUSTOMER_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.lbl_comp = new System.Windows.Forms.Label();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.comp_combo = new System.Windows.Forms.ComboBox();
            this.cat_combo = new System.Windows.Forms.ComboBox();
            this.btn_addPro = new System.Windows.Forms.Button();
            this.pro_list = new System.Windows.Forms.CheckedListBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ph = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.LINE_LBL2);
            this.panel1.Controls.Add(this.CUSTOMER_LBL);
            this.panel1.Controls.Add(this.CUSTOMER_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 130);
            this.panel1.TabIndex = 4;
            // 
            // LINE_LBL
            // 
            this.LINE_LBL.AutoSize = true;
            this.LINE_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL.Location = new System.Drawing.Point(326, 85);
            this.LINE_LBL.Name = "LINE_LBL";
            this.LINE_LBL.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL.TabIndex = 4;
            this.LINE_LBL.Text = "---------------------------------------------------";
            // 
            // LINE_LBL2
            // 
            this.LINE_LBL2.AutoSize = true;
            this.LINE_LBL2.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL2.Location = new System.Drawing.Point(326, 98);
            this.LINE_LBL2.Name = "LINE_LBL2";
            this.LINE_LBL2.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL2.TabIndex = 3;
            this.LINE_LBL2.Text = "---------------------------------------------------";
            // 
            // CUSTOMER_LBL
            // 
            this.CUSTOMER_LBL.AutoSize = true;
            this.CUSTOMER_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMER_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.CUSTOMER_LBL.Location = new System.Drawing.Point(285, 46);
            this.CUSTOMER_LBL.Name = "CUSTOMER_LBL";
            this.CUSTOMER_LBL.Size = new System.Drawing.Size(272, 24);
            this.CUSTOMER_LBL.TabIndex = 2;
            this.CUSTOMER_LBL.Text = "HAVE A HAPPY SHOPPING";
            // 
            // CUSTOMER_BOX
            // 
            this.CUSTOMER_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CUSTOMER_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CUSTOMER_BOX.Image")));
            this.CUSTOMER_BOX.Location = new System.Drawing.Point(664, 46);
            this.CUSTOMER_BOX.Name = "CUSTOMER_BOX";
            this.CUSTOMER_BOX.Size = new System.Drawing.Size(100, 50);
            this.CUSTOMER_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CUSTOMER_BOX.TabIndex = 1;
            this.CUSTOMER_BOX.TabStop = false;
            // 
            // BACK_BOX
            // 
            this.BACK_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.BACK_BOX.Image = ((System.Drawing.Image)(resources.GetObject("BACK_BOX.Image")));
            this.BACK_BOX.Location = new System.Drawing.Point(25, 46);
            this.BACK_BOX.Name = "BACK_BOX";
            this.BACK_BOX.Size = new System.Drawing.Size(100, 50);
            this.BACK_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BACK_BOX.TabIndex = 0;
            this.BACK_BOX.TabStop = false;
            this.BACK_BOX.Click += new System.EventHandler(this.BACK_BOX_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_go);
            this.groupBox1.Controls.Add(this.lbl_comp);
            this.groupBox1.Controls.Add(this.lbl_cat);
            this.groupBox1.Controls.Add(this.comp_combo);
            this.groupBox1.Controls.Add(this.cat_combo);
            this.groupBox1.Location = new System.Drawing.Point(53, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 101);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(95, 71);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 23);
            this.btn_go.TabIndex = 5;
            this.btn_go.Text = "GO";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // lbl_comp
            // 
            this.lbl_comp.AutoSize = true;
            this.lbl_comp.Location = new System.Drawing.Point(10, 44);
            this.lbl_comp.Name = "lbl_comp";
            this.lbl_comp.Size = new System.Drawing.Size(84, 13);
            this.lbl_comp.TabIndex = 3;
            this.lbl_comp.Text = "Select Company";
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Location = new System.Drawing.Point(7, 20);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(82, 13);
            this.lbl_cat.TabIndex = 2;
            this.lbl_cat.Text = "Select Category";
            // 
            // comp_combo
            // 
            this.comp_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comp_combo.FormattingEnabled = true;
            this.comp_combo.Location = new System.Drawing.Point(95, 44);
            this.comp_combo.Name = "comp_combo";
            this.comp_combo.Size = new System.Drawing.Size(155, 21);
            this.comp_combo.TabIndex = 1;
            // 
            // cat_combo
            // 
            this.cat_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cat_combo.FormattingEnabled = true;
            this.cat_combo.Location = new System.Drawing.Point(95, 17);
            this.cat_combo.Name = "cat_combo";
            this.cat_combo.Size = new System.Drawing.Size(155, 21);
            this.cat_combo.TabIndex = 0;
            // 
            // btn_addPro
            // 
            this.btn_addPro.Location = new System.Drawing.Point(369, 402);
            this.btn_addPro.Name = "btn_addPro";
            this.btn_addPro.Size = new System.Drawing.Size(75, 23);
            this.btn_addPro.TabIndex = 7;
            this.btn_addPro.Text = "Add to Cart";
            this.btn_addPro.UseVisualStyleBackColor = true;
            this.btn_addPro.Click += new System.EventHandler(this.btn_addPro_Click);
            // 
            // pro_list
            // 
            this.pro_list.FormattingEnabled = true;
            this.pro_list.Location = new System.Drawing.Point(369, 159);
            this.pro_list.Name = "pro_list";
            this.pro_list.Size = new System.Drawing.Size(190, 184);
            this.pro_list.TabIndex = 8;
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(369, 350);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(100, 20);
            this.phone_box.TabIndex = 9;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(587, 350);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(179, 20);
            this.email_box.TabIndex = 10;
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(123, 350);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(141, 20);
            this.id_box.TabIndex = 11;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(53, 350);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(43, 13);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "Your ID";
            // 
            // lbl_ph
            // 
            this.lbl_ph.AutoSize = true;
            this.lbl_ph.Location = new System.Drawing.Point(288, 353);
            this.lbl_ph.Name = "lbl_ph";
            this.lbl_ph.Size = new System.Drawing.Size(50, 13);
            this.lbl_ph.TabIndex = 13;
            this.lbl_ph.Text = "phone #:";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(499, 353);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(46, 13);
            this.lbl_mail.TabIndex = 14;
            this.lbl_mail.Text = "Email id:";
            // 
            // CartCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(835, 437);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_ph);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.pro_list);
            this.Controls.Add(this.btn_addPro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CartCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartCustomer";
            this.Load += new System.EventHandler(this.CartCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label LINE_LBL2;
        private System.Windows.Forms.Label CUSTOMER_LBL;
        private System.Windows.Forms.PictureBox CUSTOMER_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_comp;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.ComboBox comp_combo;
        private System.Windows.Forms.ComboBox cat_combo;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Button btn_addPro;
        private System.Windows.Forms.CheckedListBox pro_list;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ph;
        private System.Windows.Forms.Label lbl_mail;

    }
}