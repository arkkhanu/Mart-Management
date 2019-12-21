namespace Mart_Management_System
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.COMPANY_LBL = new System.Windows.Forms.Label();
            this.PRODUCT_BOX = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.PRICE_LBL = new System.Windows.Forms.Label();
            this.MANU_LBL = new System.Windows.Forms.Label();
            this.EX_LBL = new System.Windows.Forms.Label();
            this.PRO_LBL = new System.Windows.Forms.Label();
            this.PR_ID = new System.Windows.Forms.Label();
            this.QUAN_LBL = new System.Windows.Forms.Label();
            this.NAME_TXT = new System.Windows.Forms.TextBox();
            this.PRICE_TXT = new System.Windows.Forms.TextBox();
            this.QUANTITY_TXT = new System.Windows.Forms.TextBox();
            this.ADD_BUTTON = new System.Windows.Forms.Button();
            this.MANU_DATE = new System.Windows.Forms.DateTimePicker();
            this.EXP_DATE = new System.Windows.Forms.DateTimePicker();
            this.ID_TXT = new System.Windows.Forms.TextBox();
            this.Cat_Combo = new System.Windows.Forms.ComboBox();
            this.Product_Combo = new System.Windows.Forms.ComboBox();
            this.PRO_BOX = new System.Windows.Forms.PictureBox();
            this.BRO_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCT_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRO_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.COMPANY_LBL);
            this.panel1.Controls.Add(this.PRODUCT_BOX);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 134);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(321, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "---------------------------------------------------";
            // 
            // LINE_LBL
            // 
            this.LINE_LBL.AutoSize = true;
            this.LINE_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL.Location = new System.Drawing.Point(321, 61);
            this.LINE_LBL.Name = "LINE_LBL";
            this.LINE_LBL.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL.TabIndex = 5;
            this.LINE_LBL.Text = "---------------------------------------------------";
            // 
            // COMPANY_LBL
            // 
            this.COMPANY_LBL.AutoSize = true;
            this.COMPANY_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPANY_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.COMPANY_LBL.Location = new System.Drawing.Point(320, 34);
            this.COMPANY_LBL.Name = "COMPANY_LBL";
            this.COMPANY_LBL.Size = new System.Drawing.Size(156, 24);
            this.COMPANY_LBL.TabIndex = 3;
            this.COMPANY_LBL.Text = "ADD PRODUCT";
            // 
            // PRODUCT_BOX
            // 
            this.PRODUCT_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.PRODUCT_BOX.Image = ((System.Drawing.Image)(resources.GetObject("PRODUCT_BOX.Image")));
            this.PRODUCT_BOX.Location = new System.Drawing.Point(672, 44);
            this.PRODUCT_BOX.Name = "PRODUCT_BOX";
            this.PRODUCT_BOX.Size = new System.Drawing.Size(106, 65);
            this.PRODUCT_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PRODUCT_BOX.TabIndex = 1;
            this.PRODUCT_BOX.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.Control;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(69, 212);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(69, 264);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(42, 13);
            this.NAME.TabIndex = 29;
            this.NAME.Text = "NAME";
            // 
            // PRICE_LBL
            // 
            this.PRICE_LBL.AutoSize = true;
            this.PRICE_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PRICE_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICE_LBL.Location = new System.Drawing.Point(69, 434);
            this.PRICE_LBL.Name = "PRICE_LBL";
            this.PRICE_LBL.Size = new System.Drawing.Size(44, 13);
            this.PRICE_LBL.TabIndex = 31;
            this.PRICE_LBL.Text = "PRICE";
            // 
            // MANU_LBL
            // 
            this.MANU_LBL.AutoSize = true;
            this.MANU_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.MANU_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANU_LBL.Location = new System.Drawing.Point(69, 499);
            this.MANU_LBL.Name = "MANU_LBL";
            this.MANU_LBL.Size = new System.Drawing.Size(137, 13);
            this.MANU_LBL.TabIndex = 33;
            this.MANU_LBL.Text = "MANUFACTURE DATE";
            // 
            // EX_LBL
            // 
            this.EX_LBL.AutoSize = true;
            this.EX_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.EX_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EX_LBL.Location = new System.Drawing.Point(69, 561);
            this.EX_LBL.Name = "EX_LBL";
            this.EX_LBL.Size = new System.Drawing.Size(89, 13);
            this.EX_LBL.TabIndex = 34;
            this.EX_LBL.Text = "EXPIRY DATE";
            // 
            // PRO_LBL
            // 
            this.PRO_LBL.AutoSize = true;
            this.PRO_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PRO_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRO_LBL.Location = new System.Drawing.Point(69, 378);
            this.PRO_LBL.Name = "PRO_LBL";
            this.PRO_LBL.Size = new System.Drawing.Size(131, 13);
            this.PRO_LBL.TabIndex = 35;
            this.PRO_LBL.Text = "PRODUCT COMPANY";
            // 
            // PR_ID
            // 
            this.PR_ID.AutoSize = true;
            this.PR_ID.BackColor = System.Drawing.SystemColors.Control;
            this.PR_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PR_ID.Location = new System.Drawing.Point(69, 323);
            this.PR_ID.Name = "PR_ID";
            this.PR_ID.Size = new System.Drawing.Size(138, 13);
            this.PR_ID.TabIndex = 36;
            this.PR_ID.Text = "PRODUCT CATEGORY";
            // 
            // QUAN_LBL
            // 
            this.QUAN_LBL.AutoSize = true;
            this.QUAN_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.QUAN_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUAN_LBL.Location = new System.Drawing.Point(69, 605);
            this.QUAN_LBL.Name = "QUAN_LBL";
            this.QUAN_LBL.Size = new System.Drawing.Size(70, 13);
            this.QUAN_LBL.TabIndex = 37;
            this.QUAN_LBL.Text = "QUANTITY";
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(248, 261);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(173, 20);
            this.NAME_TXT.TabIndex = 39;
            this.NAME_TXT.TextChanged += new System.EventHandler(this.NAME_TXT_TextChanged);
            // 
            // PRICE_TXT
            // 
            this.PRICE_TXT.Location = new System.Drawing.Point(252, 431);
            this.PRICE_TXT.Name = "PRICE_TXT";
            this.PRICE_TXT.Size = new System.Drawing.Size(173, 20);
            this.PRICE_TXT.TabIndex = 40;
            // 
            // QUANTITY_TXT
            // 
            this.QUANTITY_TXT.Location = new System.Drawing.Point(252, 602);
            this.QUANTITY_TXT.Name = "QUANTITY_TXT";
            this.QUANTITY_TXT.Size = new System.Drawing.Size(173, 20);
            this.QUANTITY_TXT.TabIndex = 45;
            // 
            // ADD_BUTTON
            // 
            this.ADD_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_BUTTON.Location = new System.Drawing.Point(350, 674);
            this.ADD_BUTTON.Name = "ADD_BUTTON";
            this.ADD_BUTTON.Size = new System.Drawing.Size(84, 34);
            this.ADD_BUTTON.TabIndex = 46;
            this.ADD_BUTTON.Text = "ADD";
            this.ADD_BUTTON.UseVisualStyleBackColor = true;
            this.ADD_BUTTON.Click += new System.EventHandler(this.ADD_BUTTON_Click);
            // 
            // MANU_DATE
            // 
            this.MANU_DATE.CustomFormat = "dd-MM-yyyy";
            this.MANU_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MANU_DATE.Location = new System.Drawing.Point(248, 493);
            this.MANU_DATE.Name = "MANU_DATE";
            this.MANU_DATE.Size = new System.Drawing.Size(173, 20);
            this.MANU_DATE.TabIndex = 48;
            // 
            // EXP_DATE
            // 
            this.EXP_DATE.CustomFormat = "dd-MM-yyyy";
            this.EXP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EXP_DATE.Location = new System.Drawing.Point(248, 554);
            this.EXP_DATE.Name = "EXP_DATE";
            this.EXP_DATE.Size = new System.Drawing.Size(173, 20);
            this.EXP_DATE.TabIndex = 49;
            // 
            // ID_TXT
            // 
            this.ID_TXT.Location = new System.Drawing.Point(248, 205);
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(173, 20);
            this.ID_TXT.TabIndex = 50;
            this.ID_TXT.TextChanged += new System.EventHandler(this.ID_TXT_TextChanged);
            // 
            // Cat_Combo
            // 
            this.Cat_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cat_Combo.FormattingEnabled = true;
            this.Cat_Combo.Location = new System.Drawing.Point(248, 315);
            this.Cat_Combo.Name = "Cat_Combo";
            this.Cat_Combo.Size = new System.Drawing.Size(173, 21);
            this.Cat_Combo.TabIndex = 51;
            this.Cat_Combo.SelectedIndexChanged += new System.EventHandler(this.Cat_Combo_SelectedIndexChanged);
            // 
            // Product_Combo
            // 
            this.Product_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product_Combo.FormattingEnabled = true;
            this.Product_Combo.Location = new System.Drawing.Point(248, 375);
            this.Product_Combo.Name = "Product_Combo";
            this.Product_Combo.Size = new System.Drawing.Size(173, 21);
            this.Product_Combo.TabIndex = 52;
            // 
            // PRO_BOX
            // 
            this.PRO_BOX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PRO_BOX.Location = new System.Drawing.Point(553, 305);
            this.PRO_BOX.Name = "PRO_BOX";
            this.PRO_BOX.Size = new System.Drawing.Size(148, 146);
            this.PRO_BOX.TabIndex = 53;
            this.PRO_BOX.TabStop = false;
            // 
            // BRO_BTN
            // 
            this.BRO_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRO_BTN.Location = new System.Drawing.Point(584, 499);
            this.BRO_BTN.Name = "BRO_BTN";
            this.BRO_BTN.Size = new System.Drawing.Size(84, 34);
            this.BRO_BTN.TabIndex = 54;
            this.BRO_BTN.Text = "BROWSE";
            this.BRO_BTN.UseVisualStyleBackColor = true;
            this.BRO_BTN.Click += new System.EventHandler(this.BRO_BTN_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.BRO_BTN);
            this.Controls.Add(this.PRO_BOX);
            this.Controls.Add(this.Product_Combo);
            this.Controls.Add(this.Cat_Combo);
            this.Controls.Add(this.ID_TXT);
            this.Controls.Add(this.EXP_DATE);
            this.Controls.Add(this.MANU_DATE);
            this.Controls.Add(this.ADD_BUTTON);
            this.Controls.Add(this.QUANTITY_TXT);
            this.Controls.Add(this.PRICE_TXT);
            this.Controls.Add(this.NAME_TXT);
            this.Controls.Add(this.QUAN_LBL);
            this.Controls.Add(this.PR_ID);
            this.Controls.Add(this.PRO_LBL);
            this.Controls.Add(this.EX_LBL);
            this.Controls.Add(this.MANU_LBL);
            this.Controls.Add(this.PRICE_LBL);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCT_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRO_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label COMPANY_LBL;
        private System.Windows.Forms.PictureBox PRODUCT_BOX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label PRICE_LBL;
        private System.Windows.Forms.Label MANU_LBL;
        private System.Windows.Forms.Label EX_LBL;
        private System.Windows.Forms.Label PRO_LBL;
        private System.Windows.Forms.Label PR_ID;
        private System.Windows.Forms.Label QUAN_LBL;
        private System.Windows.Forms.TextBox NAME_TXT;
        private System.Windows.Forms.TextBox PRICE_TXT;
        private System.Windows.Forms.TextBox QUANTITY_TXT;
        private System.Windows.Forms.Button ADD_BUTTON;
        private System.Windows.Forms.DateTimePicker MANU_DATE;
        private System.Windows.Forms.DateTimePicker EXP_DATE;
        private System.Windows.Forms.TextBox ID_TXT;
        private System.Windows.Forms.ComboBox Cat_Combo;
        private System.Windows.Forms.ComboBox Product_Combo;
        private System.Windows.Forms.PictureBox PRO_BOX;
        private System.Windows.Forms.Button BRO_BTN;
    }
}