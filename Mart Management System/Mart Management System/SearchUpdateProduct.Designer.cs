namespace Mart_Management_System
{
    partial class SearchUpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUpdateProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIGN_LBL = new System.Windows.Forms.Label();
            this.PRODUCT_LBL = new System.Windows.Forms.Label();
            this.PRODUCT_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.ID_Combo = new System.Windows.Forms.ComboBox();
            this.NAME = new System.Windows.Forms.Label();
            this.NAME_TXT = new System.Windows.Forms.TextBox();
            this.PRICE_LBL = new System.Windows.Forms.Label();
            this.EX_LBL = new System.Windows.Forms.Label();
            this.MANU_LBL = new System.Windows.Forms.Label();
            this.PRO_LBL = new System.Windows.Forms.Label();
            this.PR_ID = new System.Windows.Forms.Label();
            this.QUAN_LBL = new System.Windows.Forms.Label();
            this.PRICE_TXT = new System.Windows.Forms.TextBox();
            this.MANU_TXT = new System.Windows.Forms.TextBox();
            this.EX_TXT = new System.Windows.Forms.TextBox();
            this.PRO_TXT = new System.Windows.Forms.TextBox();
            this.PRO_C_ID = new System.Windows.Forms.TextBox();
            this.QUANTITY_TXT = new System.Windows.Forms.TextBox();
            this.SEARCH_BUTTON = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCT_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.SIGN_LBL);
            this.panel1.Controls.Add(this.PRODUCT_LBL);
            this.panel1.Controls.Add(this.PRODUCT_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 127);
            this.panel1.TabIndex = 2;
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
            // PRODUCT_LBL
            // 
            this.PRODUCT_LBL.AutoSize = true;
            this.PRODUCT_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PRODUCT_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCT_LBL.Location = new System.Drawing.Point(183, 34);
            this.PRODUCT_LBL.Name = "PRODUCT_LBL";
            this.PRODUCT_LBL.Size = new System.Drawing.Size(374, 25);
            this.PRODUCT_LBL.TabIndex = 3;
            this.PRODUCT_LBL.Text = "SEARCH AND UPDATE PRODUCT\r\n";
            // 
            // PRODUCT_BOX
            // 
            this.PRODUCT_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.PRODUCT_BOX.Image = ((System.Drawing.Image)(resources.GetObject("PRODUCT_BOX.Image")));
            this.PRODUCT_BOX.Location = new System.Drawing.Point(606, 34);
            this.PRODUCT_BOX.Name = "PRODUCT_BOX";
            this.PRODUCT_BOX.Size = new System.Drawing.Size(127, 70);
            this.PRODUCT_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PRODUCT_BOX.TabIndex = 2;
            this.PRODUCT_BOX.TabStop = false;
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
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.Control;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(125, 216);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            // 
            // ID_Combo
            // 
            this.ID_Combo.FormattingEnabled = true;
            this.ID_Combo.Location = new System.Drawing.Point(290, 216);
            this.ID_Combo.Name = "ID_Combo";
            this.ID_Combo.Size = new System.Drawing.Size(173, 21);
            this.ID_Combo.TabIndex = 27;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(125, 274);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(42, 13);
            this.NAME.TabIndex = 28;
            this.NAME.Text = "NAME";
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(290, 267);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(173, 20);
            this.NAME_TXT.TabIndex = 29;
            // 
            // PRICE_LBL
            // 
            this.PRICE_LBL.AutoSize = true;
            this.PRICE_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PRICE_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICE_LBL.Location = new System.Drawing.Point(125, 329);
            this.PRICE_LBL.Name = "PRICE_LBL";
            this.PRICE_LBL.Size = new System.Drawing.Size(44, 13);
            this.PRICE_LBL.TabIndex = 30;
            this.PRICE_LBL.Text = "PRICE";
            // 
            // EX_LBL
            // 
            this.EX_LBL.AutoSize = true;
            this.EX_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.EX_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EX_LBL.Location = new System.Drawing.Point(125, 443);
            this.EX_LBL.Name = "EX_LBL";
            this.EX_LBL.Size = new System.Drawing.Size(89, 13);
            this.EX_LBL.TabIndex = 31;
            this.EX_LBL.Text = "EXPIRY DATE";
            // 
            // MANU_LBL
            // 
            this.MANU_LBL.AutoSize = true;
            this.MANU_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.MANU_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANU_LBL.Location = new System.Drawing.Point(125, 383);
            this.MANU_LBL.Name = "MANU_LBL";
            this.MANU_LBL.Size = new System.Drawing.Size(137, 13);
            this.MANU_LBL.TabIndex = 32;
            this.MANU_LBL.Text = "MANUFACTURE DATE";
            // 
            // PRO_LBL
            // 
            this.PRO_LBL.AutoSize = true;
            this.PRO_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PRO_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRO_LBL.Location = new System.Drawing.Point(125, 502);
            this.PRO_LBL.Name = "PRO_LBL";
            this.PRO_LBL.Size = new System.Drawing.Size(148, 13);
            this.PRO_LBL.TabIndex = 33;
            this.PRO_LBL.Text = "PRODUCT COMPANY ID";
            // 
            // PR_ID
            // 
            this.PR_ID.AutoSize = true;
            this.PR_ID.BackColor = System.Drawing.SystemColors.Control;
            this.PR_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PR_ID.Location = new System.Drawing.Point(129, 564);
            this.PR_ID.Name = "PR_ID";
            this.PR_ID.Size = new System.Drawing.Size(155, 13);
            this.PR_ID.TabIndex = 34;
            this.PR_ID.Text = "PRODUCT CATEGORY ID";
            // 
            // QUAN_LBL
            // 
            this.QUAN_LBL.AutoSize = true;
            this.QUAN_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.QUAN_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUAN_LBL.Location = new System.Drawing.Point(125, 619);
            this.QUAN_LBL.Name = "QUAN_LBL";
            this.QUAN_LBL.Size = new System.Drawing.Size(70, 13);
            this.QUAN_LBL.TabIndex = 35;
            this.QUAN_LBL.Text = "QUANTITY";
            // 
            // PRICE_TXT
            // 
            this.PRICE_TXT.Location = new System.Drawing.Point(290, 329);
            this.PRICE_TXT.Name = "PRICE_TXT";
            this.PRICE_TXT.Size = new System.Drawing.Size(173, 20);
            this.PRICE_TXT.TabIndex = 36;
            // 
            // MANU_TXT
            // 
            this.MANU_TXT.Location = new System.Drawing.Point(290, 383);
            this.MANU_TXT.Name = "MANU_TXT";
            this.MANU_TXT.Size = new System.Drawing.Size(173, 20);
            this.MANU_TXT.TabIndex = 37;
            // 
            // EX_TXT
            // 
            this.EX_TXT.Location = new System.Drawing.Point(290, 436);
            this.EX_TXT.Name = "EX_TXT";
            this.EX_TXT.Size = new System.Drawing.Size(173, 20);
            this.EX_TXT.TabIndex = 38;
            // 
            // PRO_TXT
            // 
            this.PRO_TXT.Location = new System.Drawing.Point(290, 495);
            this.PRO_TXT.Name = "PRO_TXT";
            this.PRO_TXT.Size = new System.Drawing.Size(173, 20);
            this.PRO_TXT.TabIndex = 39;
            // 
            // PRO_C_ID
            // 
            this.PRO_C_ID.Location = new System.Drawing.Point(290, 561);
            this.PRO_C_ID.Name = "PRO_C_ID";
            this.PRO_C_ID.Size = new System.Drawing.Size(173, 20);
            this.PRO_C_ID.TabIndex = 40;
            // 
            // QUANTITY_TXT
            // 
            this.QUANTITY_TXT.Location = new System.Drawing.Point(290, 612);
            this.QUANTITY_TXT.Name = "QUANTITY_TXT";
            this.QUANTITY_TXT.Size = new System.Drawing.Size(173, 20);
            this.QUANTITY_TXT.TabIndex = 41;
            // 
            // SEARCH_BUTTON
            // 
            this.SEARCH_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_BUTTON.Location = new System.Drawing.Point(234, 670);
            this.SEARCH_BUTTON.Name = "SEARCH_BUTTON";
            this.SEARCH_BUTTON.Size = new System.Drawing.Size(84, 34);
            this.SEARCH_BUTTON.TabIndex = 42;
            this.SEARCH_BUTTON.Text = "SEARCH";
            this.SEARCH_BUTTON.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(358, 670);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(84, 34);
            this.UPDATE.TabIndex = 43;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // SearchUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.SEARCH_BUTTON);
            this.Controls.Add(this.QUANTITY_TXT);
            this.Controls.Add(this.PRO_C_ID);
            this.Controls.Add(this.PRO_TXT);
            this.Controls.Add(this.EX_TXT);
            this.Controls.Add(this.MANU_TXT);
            this.Controls.Add(this.PRICE_TXT);
            this.Controls.Add(this.QUAN_LBL);
            this.Controls.Add(this.PR_ID);
            this.Controls.Add(this.PRO_LBL);
            this.Controls.Add(this.MANU_LBL);
            this.Controls.Add(this.EX_LBL);
            this.Controls.Add(this.PRICE_LBL);
            this.Controls.Add(this.NAME_TXT);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID_Combo);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel1);
            this.Name = "SearchUpdateProduct";
            this.Text = "SearchUpdateProduct";
            this.Load += new System.EventHandler(this.SearchUpdateProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRODUCT_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SIGN_LBL;
        private System.Windows.Forms.Label PRODUCT_LBL;
        private System.Windows.Forms.PictureBox PRODUCT_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox ID_Combo;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.TextBox NAME_TXT;
        private System.Windows.Forms.Label PRICE_LBL;
        private System.Windows.Forms.Label EX_LBL;
        private System.Windows.Forms.Label MANU_LBL;
        private System.Windows.Forms.Label PRO_LBL;
        private System.Windows.Forms.Label PR_ID;
        private System.Windows.Forms.Label QUAN_LBL;
        private System.Windows.Forms.TextBox PRICE_TXT;
        private System.Windows.Forms.TextBox MANU_TXT;
        private System.Windows.Forms.TextBox EX_TXT;
        private System.Windows.Forms.TextBox PRO_TXT;
        private System.Windows.Forms.TextBox PRO_C_ID;
        private System.Windows.Forms.TextBox QUANTITY_TXT;
        private System.Windows.Forms.Button SEARCH_BUTTON;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Label label1;
    }
}