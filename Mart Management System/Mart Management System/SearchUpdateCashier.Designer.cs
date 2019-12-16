namespace Mart_Management_System
{
    partial class SearchUpdateCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUpdateCashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIGN_LBL = new System.Windows.Forms.Label();
            this.SIGNUP_LBL = new System.Windows.Forms.Label();
            this.CASHIER_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.PASSWORD_TXT = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.Label();
            this.NAME_TXT = new System.Windows.Forms.TextBox();
            this.SALARY = new System.Windows.Forms.Label();
            this.SALARY_TXT = new System.Windows.Forms.TextBox();
            this.HIREDATE = new System.Windows.Forms.Label();
            this.HIREDATE_TXT = new System.Windows.Forms.TextBox();
            this.SEARCH_BUTTON = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.ID_Combo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.SIGN_LBL);
            this.panel1.Controls.Add(this.SIGNUP_LBL);
            this.panel1.Controls.Add(this.CASHIER_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 127);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // SIGNUP_LBL
            // 
            this.SIGNUP_LBL.AutoSize = true;
            this.SIGNUP_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.SIGNUP_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIGNUP_LBL.Location = new System.Drawing.Point(183, 34);
            this.SIGNUP_LBL.Name = "SIGNUP_LBL";
            this.SIGNUP_LBL.Size = new System.Drawing.Size(363, 25);
            this.SIGNUP_LBL.TabIndex = 3;
            this.SIGNUP_LBL.Text = "SEARCH AND UPDATE CASHIER";
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
            this.CASHIER_BOX.Click += new System.EventHandler(this.CUSTOMER_BOX_Click);
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
            this.ID.Location = new System.Drawing.Point(190, 200);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.BackColor = System.Drawing.SystemColors.Control;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(190, 247);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(78, 13);
            this.PASSWORD.TabIndex = 15;
            this.PASSWORD.Text = "PASSWORD";
            // 
            // PASSWORD_TXT
            // 
            this.PASSWORD_TXT.Location = new System.Drawing.Point(285, 240);
            this.PASSWORD_TXT.Name = "PASSWORD_TXT";
            this.PASSWORD_TXT.Size = new System.Drawing.Size(173, 20);
            this.PASSWORD_TXT.TabIndex = 16;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(190, 297);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(42, 13);
            this.NAME.TabIndex = 17;
            this.NAME.Text = "NAME";
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(285, 294);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(173, 20);
            this.NAME_TXT.TabIndex = 18;
            // 
            // SALARY
            // 
            this.SALARY.AutoSize = true;
            this.SALARY.BackColor = System.Drawing.SystemColors.Control;
            this.SALARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALARY.Location = new System.Drawing.Point(190, 355);
            this.SALARY.Name = "SALARY";
            this.SALARY.Size = new System.Drawing.Size(55, 13);
            this.SALARY.TabIndex = 19;
            this.SALARY.Text = "SALARY";
            // 
            // SALARY_TXT
            // 
            this.SALARY_TXT.Location = new System.Drawing.Point(285, 348);
            this.SALARY_TXT.Name = "SALARY_TXT";
            this.SALARY_TXT.Size = new System.Drawing.Size(173, 20);
            this.SALARY_TXT.TabIndex = 20;
            // 
            // HIREDATE
            // 
            this.HIREDATE.AutoSize = true;
            this.HIREDATE.BackColor = System.Drawing.SystemColors.Control;
            this.HIREDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HIREDATE.Location = new System.Drawing.Point(190, 408);
            this.HIREDATE.Name = "HIREDATE";
            this.HIREDATE.Size = new System.Drawing.Size(70, 13);
            this.HIREDATE.TabIndex = 21;
            this.HIREDATE.Text = "HIREDATE";
            // 
            // HIREDATE_TXT
            // 
            this.HIREDATE_TXT.Location = new System.Drawing.Point(285, 405);
            this.HIREDATE_TXT.Name = "HIREDATE_TXT";
            this.HIREDATE_TXT.Size = new System.Drawing.Size(173, 20);
            this.HIREDATE_TXT.TabIndex = 22;
            // 
            // SEARCH_BUTTON
            // 
            this.SEARCH_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_BUTTON.Location = new System.Drawing.Point(256, 459);
            this.SEARCH_BUTTON.Name = "SEARCH_BUTTON";
            this.SEARCH_BUTTON.Size = new System.Drawing.Size(84, 34);
            this.SEARCH_BUTTON.TabIndex = 23;
            this.SEARCH_BUTTON.Text = "SEARCH";
            this.SEARCH_BUTTON.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(446, 459);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(84, 34);
            this.UPDATE.TabIndex = 24;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            // 
            // ID_Combo
            // 
            this.ID_Combo.FormattingEnabled = true;
            this.ID_Combo.Location = new System.Drawing.Point(285, 192);
            this.ID_Combo.Name = "ID_Combo";
            this.ID_Combo.Size = new System.Drawing.Size(173, 21);
            this.ID_Combo.TabIndex = 26;
            // 
            // SearchUpdateCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(793, 505);
            this.Controls.Add(this.ID_Combo);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.SEARCH_BUTTON);
            this.Controls.Add(this.HIREDATE_TXT);
            this.Controls.Add(this.HIREDATE);
            this.Controls.Add(this.SALARY_TXT);
            this.Controls.Add(this.SALARY);
            this.Controls.Add(this.NAME_TXT);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.PASSWORD_TXT);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel1);
            this.Name = "SearchUpdateCashier";
            this.Text = "SearchUpdateCashier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SIGN_LBL;
        private System.Windows.Forms.Label SIGNUP_LBL;
        private System.Windows.Forms.PictureBox CASHIER_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.TextBox PASSWORD_TXT;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.TextBox NAME_TXT;
        private System.Windows.Forms.Label SALARY;
        private System.Windows.Forms.TextBox SALARY_TXT;
        private System.Windows.Forms.Label HIREDATE;
        private System.Windows.Forms.TextBox HIREDATE_TXT;
        private System.Windows.Forms.Button SEARCH_BUTTON;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.ComboBox ID_Combo;
    }
}