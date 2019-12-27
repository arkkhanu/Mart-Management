namespace Mart_Management_System
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIGN_LBL = new System.Windows.Forms.Label();
            this.SIGNUP_LBL = new System.Windows.Forms.Label();
            this.CATEGORY_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.Show_Data = new System.Windows.Forms.GroupBox();
            this.view_data = new System.Windows.Forms.DataGridView();
            this.Update_Box = new System.Windows.Forms.GroupBox();
            this.Age_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.PASS_TXT = new System.Windows.Forms.TextBox();
            this.EMAIL_TXT = new System.Windows.Forms.TextBox();
            this.QUAN_LBL = new System.Windows.Forms.Label();
            this.QUANTITY_TXT = new System.Windows.Forms.TextBox();
            this.PASS_LBL = new System.Windows.Forms.Label();
            this.MANU_LBL = new System.Windows.Forms.Label();
            this.ID_TXT = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.NAME_TXT = new System.Windows.Forms.TextBox();
            this.ADDRESS_TXT = new System.Windows.Forms.TextBox();
            this.PRO_LBL = new System.Windows.Forms.Label();
            this.PR_ID = new System.Windows.Forms.Label();
            this.PRICE_LBL = new System.Windows.Forms.Label();
            this.GENDER = new System.Windows.Forms.TextBox();
            this.AGE_TXT = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CATEGORY_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            this.Show_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).BeginInit();
            this.Update_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.SIGN_LBL);
            this.panel1.Controls.Add(this.SIGNUP_LBL);
            this.panel1.Controls.Add(this.CATEGORY_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 127);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // SIGN_LBL
            // 
            this.SIGN_LBL.AutoSize = true;
            this.SIGN_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.SIGN_LBL.Location = new System.Drawing.Point(388, 82);
            this.SIGN_LBL.Name = "SIGN_LBL";
            this.SIGN_LBL.Size = new System.Drawing.Size(232, 13);
            this.SIGN_LBL.TabIndex = 4;
            this.SIGN_LBL.Text = "---------------------------------------------------------------------------";
            // 
            // SIGNUP_LBL
            // 
            this.SIGNUP_LBL.AutoSize = true;
            this.SIGNUP_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.SIGNUP_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIGNUP_LBL.Location = new System.Drawing.Point(386, 25);
            this.SIGNUP_LBL.Name = "SIGNUP_LBL";
            this.SIGNUP_LBL.Size = new System.Drawing.Size(238, 25);
            this.SIGNUP_LBL.TabIndex = 3;
            this.SIGNUP_LBL.Text = "UPDATE CUSTOMER\r\n";
            // 
            // CATEGORY_BOX
            // 
            this.CATEGORY_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CATEGORY_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CATEGORY_BOX.Image")));
            this.CATEGORY_BOX.Location = new System.Drawing.Point(969, 25);
            this.CATEGORY_BOX.Name = "CATEGORY_BOX";
            this.CATEGORY_BOX.Size = new System.Drawing.Size(127, 70);
            this.CATEGORY_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CATEGORY_BOX.TabIndex = 2;
            this.CATEGORY_BOX.TabStop = false;
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
            this.BACK_BOX.Click += new System.EventHandler(this.BACK_BOX_Click);
            // 
            // Show_Data
            // 
            this.Show_Data.Controls.Add(this.view_data);
            this.Show_Data.Location = new System.Drawing.Point(492, 189);
            this.Show_Data.Name = "Show_Data";
            this.Show_Data.Size = new System.Drawing.Size(604, 246);
            this.Show_Data.TabIndex = 49;
            this.Show_Data.TabStop = false;
            this.Show_Data.Text = "Show Data";
            // 
            // view_data
            // 
            this.view_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_data.Location = new System.Drawing.Point(22, 19);
            this.view_data.Name = "view_data";
            this.view_data.Size = new System.Drawing.Size(576, 212);
            this.view_data.TabIndex = 0;
            this.view_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_data_CellClick);
            this.view_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_data_CellContentClick);
            // 
            // Update_Box
            // 
            this.Update_Box.Controls.Add(this.Age_lbl);
            this.Update_Box.Controls.Add(this.Name_lbl);
            this.Update_Box.Controls.Add(this.PASS_TXT);
            this.Update_Box.Controls.Add(this.EMAIL_TXT);
            this.Update_Box.Controls.Add(this.QUAN_LBL);
            this.Update_Box.Controls.Add(this.QUANTITY_TXT);
            this.Update_Box.Controls.Add(this.PASS_LBL);
            this.Update_Box.Controls.Add(this.MANU_LBL);
            this.Update_Box.Controls.Add(this.ID_TXT);
            this.Update_Box.Controls.Add(this.ID);
            this.Update_Box.Controls.Add(this.NAME_TXT);
            this.Update_Box.Controls.Add(this.ADDRESS_TXT);
            this.Update_Box.Controls.Add(this.PRO_LBL);
            this.Update_Box.Controls.Add(this.PR_ID);
            this.Update_Box.Controls.Add(this.PRICE_LBL);
            this.Update_Box.Controls.Add(this.GENDER);
            this.Update_Box.Controls.Add(this.AGE_TXT);
            this.Update_Box.Controls.Add(this.NAME);
            this.Update_Box.Location = new System.Drawing.Point(1, 147);
            this.Update_Box.Name = "Update_Box";
            this.Update_Box.Size = new System.Drawing.Size(473, 471);
            this.Update_Box.TabIndex = 50;
            this.Update_Box.TabStop = false;
            this.Update_Box.Text = "Update";
            // 
            // Age_lbl
            // 
            this.Age_lbl.AutoSize = true;
            this.Age_lbl.Location = new System.Drawing.Point(371, 203);
            this.Age_lbl.Name = "Age_lbl";
            this.Age_lbl.Size = new System.Drawing.Size(0, 13);
            this.Age_lbl.TabIndex = 50;
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(371, 93);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(0, 13);
            this.Name_lbl.TabIndex = 49;
            // 
            // PASS_TXT
            // 
            this.PASS_TXT.Location = new System.Drawing.Point(172, 359);
            this.PASS_TXT.Name = "PASS_TXT";
            this.PASS_TXT.Size = new System.Drawing.Size(173, 20);
            this.PASS_TXT.TabIndex = 48;
            // 
            // EMAIL_TXT
            // 
            this.EMAIL_TXT.Location = new System.Drawing.Point(172, 305);
            this.EMAIL_TXT.Name = "EMAIL_TXT";
            this.EMAIL_TXT.Size = new System.Drawing.Size(173, 20);
            this.EMAIL_TXT.TabIndex = 47;
            // 
            // QUAN_LBL
            // 
            this.QUAN_LBL.AutoSize = true;
            this.QUAN_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.QUAN_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QUAN_LBL.Location = new System.Drawing.Point(7, 427);
            this.QUAN_LBL.Name = "QUAN_LBL";
            this.QUAN_LBL.Size = new System.Drawing.Size(70, 13);
            this.QUAN_LBL.TabIndex = 35;
            this.QUAN_LBL.Text = "QUANTITY";
            // 
            // QUANTITY_TXT
            // 
            this.QUANTITY_TXT.Location = new System.Drawing.Point(172, 424);
            this.QUANTITY_TXT.Name = "QUANTITY_TXT";
            this.QUANTITY_TXT.Size = new System.Drawing.Size(173, 20);
            this.QUANTITY_TXT.TabIndex = 41;
            // 
            // PASS_LBL
            // 
            this.PASS_LBL.AutoSize = true;
            this.PASS_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PASS_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASS_LBL.Location = new System.Drawing.Point(7, 359);
            this.PASS_LBL.Name = "PASS_LBL";
            this.PASS_LBL.Size = new System.Drawing.Size(78, 13);
            this.PASS_LBL.TabIndex = 31;
            this.PASS_LBL.Text = "PASSWORD\r\n";
            // 
            // MANU_LBL
            // 
            this.MANU_LBL.AutoSize = true;
            this.MANU_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.MANU_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANU_LBL.Location = new System.Drawing.Point(6, 305);
            this.MANU_LBL.Name = "MANU_LBL";
            this.MANU_LBL.Size = new System.Drawing.Size(44, 13);
            this.MANU_LBL.TabIndex = 32;
            this.MANU_LBL.Text = "EMAIL\r\n";
            // 
            // ID_TXT
            // 
            this.ID_TXT.Enabled = false;
            this.ID_TXT.Location = new System.Drawing.Point(172, 35);
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(173, 20);
            this.ID_TXT.TabIndex = 46;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.Control;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(12, 42);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(172, 86);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(173, 20);
            this.NAME_TXT.TabIndex = 29;
            this.NAME_TXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validatename);
            // 
            // ADDRESS_TXT
            // 
            this.ADDRESS_TXT.Location = new System.Drawing.Point(172, 258);
            this.ADDRESS_TXT.Name = "ADDRESS_TXT";
            this.ADDRESS_TXT.Size = new System.Drawing.Size(173, 20);
            this.ADDRESS_TXT.TabIndex = 36;
            // 
            // PRO_LBL
            // 
            this.PRO_LBL.AutoSize = true;
            this.PRO_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PRO_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRO_LBL.Location = new System.Drawing.Point(7, 200);
            this.PRO_LBL.Name = "PRO_LBL";
            this.PRO_LBL.Size = new System.Drawing.Size(32, 26);
            this.PRO_LBL.TabIndex = 33;
            this.PRO_LBL.Text = "AGE\r\n\r\n";
            // 
            // PR_ID
            // 
            this.PR_ID.AutoSize = true;
            this.PR_ID.BackColor = System.Drawing.SystemColors.Control;
            this.PR_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PR_ID.Location = new System.Drawing.Point(7, 145);
            this.PR_ID.Name = "PR_ID";
            this.PR_ID.Size = new System.Drawing.Size(59, 13);
            this.PR_ID.TabIndex = 34;
            this.PR_ID.Text = "GENDER\r\n";
            // 
            // PRICE_LBL
            // 
            this.PRICE_LBL.AutoSize = true;
            this.PRICE_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.PRICE_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRICE_LBL.Location = new System.Drawing.Point(7, 258);
            this.PRICE_LBL.Name = "PRICE_LBL";
            this.PRICE_LBL.Size = new System.Drawing.Size(66, 13);
            this.PRICE_LBL.TabIndex = 30;
            this.PRICE_LBL.Text = "ADDRESS";
            // 
            // GENDER
            // 
            this.GENDER.Enabled = false;
            this.GENDER.Location = new System.Drawing.Point(172, 145);
            this.GENDER.Name = "GENDER";
            this.GENDER.Size = new System.Drawing.Size(173, 20);
            this.GENDER.TabIndex = 40;
            // 
            // AGE_TXT
            // 
            this.AGE_TXT.Enabled = false;
            this.AGE_TXT.Location = new System.Drawing.Point(172, 200);
            this.AGE_TXT.Name = "AGE_TXT";
            this.AGE_TXT.Size = new System.Drawing.Size(173, 20);
            this.AGE_TXT.TabIndex = 39;
            this.AGE_TXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validateage);
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(6, 86);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(42, 13);
            this.NAME.TabIndex = 28;
            this.NAME.Text = "NAME";
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(586, 485);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(214, 34);
            this.UPDATE.TabIndex = 51;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1123, 569);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.Update_Box);
            this.Controls.Add(this.Show_Data);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCustomer";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CATEGORY_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.Show_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_data)).EndInit();
            this.Update_Box.ResumeLayout(false);
            this.Update_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SIGN_LBL;
        private System.Windows.Forms.Label SIGNUP_LBL;
        private System.Windows.Forms.PictureBox CATEGORY_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.GroupBox Show_Data;
        private System.Windows.Forms.DataGridView view_data;
        private System.Windows.Forms.GroupBox Update_Box;
        private System.Windows.Forms.Label QUAN_LBL;
        private System.Windows.Forms.TextBox QUANTITY_TXT;
        private System.Windows.Forms.Label PASS_LBL;
        private System.Windows.Forms.Label MANU_LBL;
        private System.Windows.Forms.TextBox ID_TXT;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox NAME_TXT;
        private System.Windows.Forms.TextBox ADDRESS_TXT;
        private System.Windows.Forms.Label PRO_LBL;
        private System.Windows.Forms.Label PR_ID;
        private System.Windows.Forms.Label PRICE_LBL;
        private System.Windows.Forms.TextBox GENDER;
        private System.Windows.Forms.TextBox AGE_TXT;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.TextBox EMAIL_TXT;
        private System.Windows.Forms.Label Age_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox PASS_TXT;
    }
}