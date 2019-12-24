namespace Mart_Management_System
{
    partial class UpdateCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCashier));
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
            this.UPDATE = new System.Windows.Forms.Button();
            this.UPDATE_RECORD = new System.Windows.Forms.GroupBox();
            this.HIREDATE_TXT = new System.Windows.Forms.DateTimePicker();
            this.ID_TXT = new System.Windows.Forms.TextBox();
            this.Show_Data = new System.Windows.Forms.GroupBox();
            this.View_Cashier = new System.Windows.Forms.DataGridView();
            this.UPDATE_BTN = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.sal_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            this.UPDATE_RECORD.SuspendLayout();
            this.Show_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_Cashier)).BeginInit();
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
            this.SIGNUP_LBL.Location = new System.Drawing.Point(260, 34);
            this.SIGNUP_LBL.Name = "SIGNUP_LBL";
            this.SIGNUP_LBL.Size = new System.Drawing.Size(216, 25);
            this.SIGNUP_LBL.TabIndex = 3;
            this.SIGNUP_LBL.Text = " UPDATE CASHIER";
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
            this.BACK_BOX.Click += new System.EventHandler(this.BACK_BOX_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.Control;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(6, 40);
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
            this.PASSWORD.Location = new System.Drawing.Point(6, 259);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(78, 13);
            this.PASSWORD.TabIndex = 15;
            this.PASSWORD.Text = "PASSWORD";
            // 
            // PASSWORD_TXT
            // 
            this.PASSWORD_TXT.Location = new System.Drawing.Point(102, 256);
            this.PASSWORD_TXT.Name = "PASSWORD_TXT";
            this.PASSWORD_TXT.Size = new System.Drawing.Size(172, 20);
            this.PASSWORD_TXT.TabIndex = 16;
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(6, 95);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(42, 13);
            this.NAME.TabIndex = 17;
            this.NAME.Text = "NAME";
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(102, 92);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(172, 20);
            this.NAME_TXT.TabIndex = 18;
            this.NAME_TXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validatename);
            // 
            // SALARY
            // 
            this.SALARY.AutoSize = true;
            this.SALARY.BackColor = System.Drawing.SystemColors.Control;
            this.SALARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALARY.Location = new System.Drawing.Point(6, 155);
            this.SALARY.Name = "SALARY";
            this.SALARY.Size = new System.Drawing.Size(55, 13);
            this.SALARY.TabIndex = 19;
            this.SALARY.Text = "SALARY";
            // 
            // SALARY_TXT
            // 
            this.SALARY_TXT.Location = new System.Drawing.Point(102, 148);
            this.SALARY_TXT.Name = "SALARY_TXT";
            this.SALARY_TXT.Size = new System.Drawing.Size(172, 20);
            this.SALARY_TXT.TabIndex = 20;
            // 
            // HIREDATE
            // 
            this.HIREDATE.AutoSize = true;
            this.HIREDATE.BackColor = System.Drawing.SystemColors.Control;
            this.HIREDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HIREDATE.Location = new System.Drawing.Point(6, 204);
            this.HIREDATE.Name = "HIREDATE";
            this.HIREDATE.Size = new System.Drawing.Size(70, 13);
            this.HIREDATE.TabIndex = 21;
            this.HIREDATE.Text = "HIREDATE";
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(263, 299);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(83, 34);
            this.UPDATE.TabIndex = 24;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            // 
            // UPDATE_RECORD
            // 
            this.UPDATE_RECORD.Controls.Add(this.pass_lbl);
            this.UPDATE_RECORD.Controls.Add(this.sal_lbl);
            this.UPDATE_RECORD.Controls.Add(this.name_lbl);
            this.UPDATE_RECORD.Controls.Add(this.HIREDATE_TXT);
            this.UPDATE_RECORD.Controls.Add(this.ID_TXT);
            this.UPDATE_RECORD.Controls.Add(this.ID);
            this.UPDATE_RECORD.Controls.Add(this.PASSWORD_TXT);
            this.UPDATE_RECORD.Controls.Add(this.PASSWORD);
            this.UPDATE_RECORD.Controls.Add(this.UPDATE);
            this.UPDATE_RECORD.Controls.Add(this.NAME);
            this.UPDATE_RECORD.Controls.Add(this.HIREDATE);
            this.UPDATE_RECORD.Controls.Add(this.NAME_TXT);
            this.UPDATE_RECORD.Controls.Add(this.SALARY_TXT);
            this.UPDATE_RECORD.Controls.Add(this.SALARY);
            this.UPDATE_RECORD.Location = new System.Drawing.Point(27, 155);
            this.UPDATE_RECORD.Name = "UPDATE_RECORD";
            this.UPDATE_RECORD.Size = new System.Drawing.Size(368, 293);
            this.UPDATE_RECORD.TabIndex = 27;
            this.UPDATE_RECORD.TabStop = false;
            this.UPDATE_RECORD.Text = "UPDATE";
            // 
            // HIREDATE_TXT
            // 
            this.HIREDATE_TXT.CustomFormat = "dd-MM-yyyy";
            this.HIREDATE_TXT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HIREDATE_TXT.Location = new System.Drawing.Point(102, 204);
            this.HIREDATE_TXT.Name = "HIREDATE_TXT";
            this.HIREDATE_TXT.Size = new System.Drawing.Size(172, 20);
            this.HIREDATE_TXT.TabIndex = 26;
            // 
            // ID_TXT
            // 
            this.ID_TXT.Enabled = false;
            this.ID_TXT.Location = new System.Drawing.Point(102, 31);
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(172, 20);
            this.ID_TXT.TabIndex = 25;
            // 
            // Show_Data
            // 
            this.Show_Data.Controls.Add(this.View_Cashier);
            this.Show_Data.Location = new System.Drawing.Point(412, 172);
            this.Show_Data.Name = "Show_Data";
            this.Show_Data.Size = new System.Drawing.Size(453, 191);
            this.Show_Data.TabIndex = 50;
            this.Show_Data.TabStop = false;
            this.Show_Data.Text = "Show Data";
            // 
            // View_Cashier
            // 
            this.View_Cashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Cashier.Location = new System.Drawing.Point(22, 14);
            this.View_Cashier.Name = "View_Cashier";
            this.View_Cashier.Size = new System.Drawing.Size(403, 166);
            this.View_Cashier.TabIndex = 0;
            this.View_Cashier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_Cashier_CellClick);
            this.View_Cashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_Cashier_CellContentClick);
            // 
            // UPDATE_BTN
            // 
            this.UPDATE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE_BTN.Location = new System.Drawing.Point(527, 414);
            this.UPDATE_BTN.Name = "UPDATE_BTN";
            this.UPDATE_BTN.Size = new System.Drawing.Size(123, 34);
            this.UPDATE_BTN.TabIndex = 51;
            this.UPDATE_BTN.Text = "UPDATE";
            this.UPDATE_BTN.UseVisualStyleBackColor = true;
            this.UPDATE_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(295, 95);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(0, 13);
            this.name_lbl.TabIndex = 27;
            // 
            // sal_lbl
            // 
            this.sal_lbl.AutoSize = true;
            this.sal_lbl.Location = new System.Drawing.Point(295, 155);
            this.sal_lbl.Name = "sal_lbl";
            this.sal_lbl.Size = new System.Drawing.Size(0, 13);
            this.sal_lbl.TabIndex = 28;
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Location = new System.Drawing.Point(295, 263);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(0, 13);
            this.pass_lbl.TabIndex = 29;
            // 
            // UpdateCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(901, 510);
            this.Controls.Add(this.UPDATE_BTN);
            this.Controls.Add(this.Show_Data);
            this.Controls.Add(this.UPDATE_RECORD);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateCashier";
            this.Text = "SearchUpdateCashier";
            this.Load += new System.EventHandler(this.UpdateCashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.UPDATE_RECORD.ResumeLayout(false);
            this.UPDATE_RECORD.PerformLayout();
            this.Show_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_Cashier)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.GroupBox UPDATE_RECORD;
        private System.Windows.Forms.GroupBox Show_Data;
        private System.Windows.Forms.DataGridView View_Cashier;
        private System.Windows.Forms.Button UPDATE_BTN;
        private System.Windows.Forms.TextBox ID_TXT;
        private System.Windows.Forms.DateTimePicker HIREDATE_TXT;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label sal_lbl;
    }
}