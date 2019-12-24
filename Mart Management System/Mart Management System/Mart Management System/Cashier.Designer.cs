namespace Mart_Management_System
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIGN_LBL = new System.Windows.Forms.Label();
            this.CASHIER_LBL = new System.Windows.Forms.Label();
            this.CASHIER_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.NAME = new System.Windows.Forms.Label();
            this.CASHIER_ID = new System.Windows.Forms.Label();
            this.CASH_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CUSTOM_COMBO = new System.Windows.Forms.ComboBox();
            this.CASHIER_NAME = new System.Windows.Forms.TextBox();
            this.DATE_LBL = new System.Windows.Forms.Label();
            this.DATE_TXT = new System.Windows.Forms.TextBox();
            this.TRAN_LBL = new System.Windows.Forms.Label();
            this.TRAN_TXT = new System.Windows.Forms.TextBox();
            this.PRODUCTNAME = new System.Windows.Forms.Label();
            this.PRO_TXT = new System.Windows.Forms.TextBox();
            this.PRICE_LBL = new System.Windows.Forms.Label();
            this.PRICE_TXT = new System.Windows.Forms.TextBox();
            this.QUANTITY = new System.Windows.Forms.Label();
            this.QUANTITY_TXT = new System.Windows.Forms.TextBox();
            this.CASHIER_VIEW = new System.Windows.Forms.DataGridView();
            this.SUBMIT_BTN = new System.Windows.Forms.Button();
            this.CLEAR_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.SIGN_LBL);
            this.panel1.Controls.Add(this.CASHIER_LBL);
            this.panel1.Controls.Add(this.CASHIER_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 127);
            this.panel1.TabIndex = 3;
            // 
            // SIGN_LBL
            // 
            this.SIGN_LBL.AutoSize = true;
            this.SIGN_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.SIGN_LBL.Location = new System.Drawing.Point(244, 82);
            this.SIGN_LBL.Name = "SIGN_LBL";
            this.SIGN_LBL.Size = new System.Drawing.Size(232, 13);
            this.SIGN_LBL.TabIndex = 4;
            this.SIGN_LBL.Text = "---------------------------------------------------------------------------";
            // 
            // CASHIER_LBL
            // 
            this.CASHIER_LBL.AutoSize = true;
            this.CASHIER_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.CASHIER_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CASHIER_LBL.Location = new System.Drawing.Point(311, 34);
            this.CASHIER_LBL.Name = "CASHIER_LBL";
            this.CASHIER_LBL.Size = new System.Drawing.Size(111, 25);
            this.CASHIER_LBL.TabIndex = 3;
            this.CASHIER_LBL.Text = "CASHIER";
            // 
            // CASHIER_BOX
            // 
            this.CASHIER_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CASHIER_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CASHIER_BOX.Image")));
            this.CASHIER_BOX.Location = new System.Drawing.Point(606, 34);
            this.CASHIER_BOX.Name = "CASHIER_BOX";
            this.CASHIER_BOX.Size = new System.Drawing.Size(127, 70);
            this.CASHIER_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CASHIER_BOX.TabIndex = 2;
            this.CASHIER_BOX.TabStop = false;
            // 
            // BACK_BOX
            // 
            this.BACK_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.BACK_BOX.Image = ((System.Drawing.Image)(resources.GetObject("BACK_BOX.Image")));
            this.BACK_BOX.Location = new System.Drawing.Point(21, 34);
            this.BACK_BOX.Name = "BACK_BOX";
            this.BACK_BOX.Size = new System.Drawing.Size(100, 50);
            this.BACK_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BACK_BOX.TabIndex = 1;
            this.BACK_BOX.TabStop = false;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(11, 179);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(93, 13);
            this.NAME.TabIndex = 29;
            this.NAME.Text = "CUSTOMER ID";
            // 
            // CASHIER_ID
            // 
            this.CASHIER_ID.AutoSize = true;
            this.CASHIER_ID.BackColor = System.Drawing.SystemColors.Control;
            this.CASHIER_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CASHIER_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CASHIER_ID.Location = new System.Drawing.Point(12, 148);
            this.CASHIER_ID.Name = "CASHIER_ID";
            this.CASHIER_ID.Size = new System.Drawing.Size(78, 13);
            this.CASHIER_ID.TabIndex = 31;
            this.CASHIER_ID.Text = "CASHIER ID";
            // 
            // CASH_Combo
            // 
            this.CASH_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CASH_Combo.FormattingEnabled = true;
            this.CASH_Combo.Location = new System.Drawing.Point(158, 140);
            this.CASH_Combo.Name = "CASH_Combo";
            this.CASH_Combo.Size = new System.Drawing.Size(173, 21);
            this.CASH_Combo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(417, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "CASHIER NAME";
            // 
            // CUSTOM_COMBO
            // 
            this.CUSTOM_COMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CUSTOM_COMBO.FormattingEnabled = true;
            this.CUSTOM_COMBO.Location = new System.Drawing.Point(158, 179);
            this.CUSTOM_COMBO.Name = "CUSTOM_COMBO";
            this.CUSTOM_COMBO.Size = new System.Drawing.Size(173, 21);
            this.CUSTOM_COMBO.TabIndex = 34;
            // 
            // CASHIER_NAME
            // 
            this.CASHIER_NAME.Location = new System.Drawing.Point(550, 140);
            this.CASHIER_NAME.Name = "CASHIER_NAME";
            this.CASHIER_NAME.Size = new System.Drawing.Size(173, 20);
            this.CASHIER_NAME.TabIndex = 35;
            // 
            // DATE_LBL
            // 
            this.DATE_LBL.AutoSize = true;
            this.DATE_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.DATE_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_LBL.Location = new System.Drawing.Point(11, 215);
            this.DATE_LBL.Name = "DATE_LBL";
            this.DATE_LBL.Size = new System.Drawing.Size(40, 13);
            this.DATE_LBL.TabIndex = 37;
            this.DATE_LBL.Text = "DATE";
            // 
            // DATE_TXT
            // 
            this.DATE_TXT.Location = new System.Drawing.Point(158, 215);
            this.DATE_TXT.Name = "DATE_TXT";
            this.DATE_TXT.Size = new System.Drawing.Size(173, 20);
            this.DATE_TXT.TabIndex = 38;
            // 
            // TRAN_LBL
            // 
            this.TRAN_LBL.AutoSize = true;
            this.TRAN_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.TRAN_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRAN_LBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TRAN_LBL.Location = new System.Drawing.Point(414, 187);
            this.TRAN_LBL.Name = "TRAN_LBL";
            this.TRAN_LBL.Size = new System.Drawing.Size(112, 13);
            this.TRAN_LBL.TabIndex = 39;
            this.TRAN_LBL.Text = "TRANSACTION ID";
            // 
            // TRAN_TXT
            // 
            this.TRAN_TXT.Enabled = false;
            this.TRAN_TXT.Location = new System.Drawing.Point(550, 187);
            this.TRAN_TXT.Name = "TRAN_TXT";
            this.TRAN_TXT.Size = new System.Drawing.Size(173, 20);
            this.TRAN_TXT.TabIndex = 40;
            // 
            // PRODUCTNAME
            // 
            this.PRODUCTNAME.AutoSize = true;
            this.PRODUCTNAME.BackColor = System.Drawing.SystemColors.Control;
            this.PRODUCTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCTNAME.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PRODUCTNAME.Location = new System.Drawing.Point(11, 253);
            this.PRODUCTNAME.Name = "PRODUCTNAME";
            this.PRODUCTNAME.Size = new System.Drawing.Size(106, 13);
            this.PRODUCTNAME.TabIndex = 43;
            this.PRODUCTNAME.Text = "PRODUCT NAME";
            // 
            // PRO_TXT
            // 
            this.PRO_TXT.Enabled = false;
            this.PRO_TXT.Location = new System.Drawing.Point(158, 250);
            this.PRO_TXT.Name = "PRO_TXT";
            this.PRO_TXT.Size = new System.Drawing.Size(173, 20);
            this.PRO_TXT.TabIndex = 44;
            // 
            // PRICE_LBL
            // 
            this.PRICE_LBL.AutoSize = true;
            this.PRICE_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PRICE_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICE_LBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PRICE_LBL.Location = new System.Drawing.Point(11, 295);
            this.PRICE_LBL.Name = "PRICE_LBL";
            this.PRICE_LBL.Size = new System.Drawing.Size(44, 13);
            this.PRICE_LBL.TabIndex = 45;
            this.PRICE_LBL.Text = "PRICE";
            // 
            // PRICE_TXT
            // 
            this.PRICE_TXT.Enabled = false;
            this.PRICE_TXT.Location = new System.Drawing.Point(158, 295);
            this.PRICE_TXT.Name = "PRICE_TXT";
            this.PRICE_TXT.Size = new System.Drawing.Size(173, 20);
            this.PRICE_TXT.TabIndex = 46;
            // 
            // QUANTITY
            // 
            this.QUANTITY.AutoSize = true;
            this.QUANTITY.BackColor = System.Drawing.SystemColors.Control;
            this.QUANTITY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUANTITY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QUANTITY.Location = new System.Drawing.Point(414, 222);
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.Size = new System.Drawing.Size(70, 13);
            this.QUANTITY.TabIndex = 47;
            this.QUANTITY.Text = "QUANTITY";
            // 
            // QUANTITY_TXT
            // 
            this.QUANTITY_TXT.Enabled = false;
            this.QUANTITY_TXT.Location = new System.Drawing.Point(550, 222);
            this.QUANTITY_TXT.Name = "QUANTITY_TXT";
            this.QUANTITY_TXT.Size = new System.Drawing.Size(173, 20);
            this.QUANTITY_TXT.TabIndex = 48;
            // 
            // CASHIER_VIEW
            // 
            this.CASHIER_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CASHIER_VIEW.Location = new System.Drawing.Point(2, 331);
            this.CASHIER_VIEW.Name = "CASHIER_VIEW";
            this.CASHIER_VIEW.Size = new System.Drawing.Size(777, 150);
            this.CASHIER_VIEW.TabIndex = 52;
            this.CASHIER_VIEW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CASHIER_VIEW_CellClick);
            // 
            // SUBMIT_BTN
            // 
            this.SUBMIT_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT_BTN.Location = new System.Drawing.Point(420, 487);
            this.SUBMIT_BTN.Name = "SUBMIT_BTN";
            this.SUBMIT_BTN.Size = new System.Drawing.Size(84, 34);
            this.SUBMIT_BTN.TabIndex = 54;
            this.SUBMIT_BTN.Text = "SUBMIT";
            this.SUBMIT_BTN.UseVisualStyleBackColor = true;
            this.SUBMIT_BTN.Click += new System.EventHandler(this.SUBMIT_BTN_Click);
            // 
            // CLEAR_BTN
            // 
            this.CLEAR_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR_BTN.Location = new System.Drawing.Point(299, 487);
            this.CLEAR_BTN.Name = "CLEAR_BTN";
            this.CLEAR_BTN.Size = new System.Drawing.Size(84, 34);
            this.CLEAR_BTN.TabIndex = 55;
            this.CLEAR_BTN.Text = "CLEAR";
            this.CLEAR_BTN.UseVisualStyleBackColor = true;
            this.CLEAR_BTN.Click += new System.EventHandler(this.CLEAR_BTN_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(805, 528);
            this.Controls.Add(this.CLEAR_BTN);
            this.Controls.Add(this.SUBMIT_BTN);
            this.Controls.Add(this.CASHIER_VIEW);
            this.Controls.Add(this.QUANTITY_TXT);
            this.Controls.Add(this.QUANTITY);
            this.Controls.Add(this.PRICE_TXT);
            this.Controls.Add(this.PRICE_LBL);
            this.Controls.Add(this.PRO_TXT);
            this.Controls.Add(this.PRODUCTNAME);
            this.Controls.Add(this.TRAN_TXT);
            this.Controls.Add(this.TRAN_LBL);
            this.Controls.Add(this.DATE_TXT);
            this.Controls.Add(this.DATE_LBL);
            this.Controls.Add(this.CASHIER_NAME);
            this.Controls.Add(this.CUSTOM_COMBO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CASH_Combo);
            this.Controls.Add(this.CASHIER_ID);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_VIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SIGN_LBL;
        private System.Windows.Forms.Label CASHIER_LBL;
        private System.Windows.Forms.PictureBox CASHIER_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label CASHIER_ID;
        private System.Windows.Forms.ComboBox CASH_Combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CUSTOM_COMBO;
        private System.Windows.Forms.TextBox CASHIER_NAME;
        private System.Windows.Forms.Label DATE_LBL;
        private System.Windows.Forms.TextBox DATE_TXT;
        private System.Windows.Forms.Label TRAN_LBL;
        private System.Windows.Forms.TextBox TRAN_TXT;
        private System.Windows.Forms.Label PRODUCTNAME;
        private System.Windows.Forms.TextBox PRO_TXT;
        private System.Windows.Forms.Label PRICE_LBL;
        private System.Windows.Forms.TextBox PRICE_TXT;
        private System.Windows.Forms.Label QUANTITY;
        private System.Windows.Forms.TextBox QUANTITY_TXT;
        private System.Windows.Forms.DataGridView CASHIER_VIEW;
        private System.Windows.Forms.Button SUBMIT_BTN;
        private System.Windows.Forms.Button CLEAR_BTN;
    }
}