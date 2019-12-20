namespace Mart_Management_System
{
    partial class UpdateCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIGN_LBL = new System.Windows.Forms.Label();
            this.COMPANY_LBL = new System.Windows.Forms.Label();
            this.COMPANY_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.UPDATE = new System.Windows.Forms.Button();
            this.Show_Data = new System.Windows.Forms.GroupBox();
            this.View_Company = new System.Windows.Forms.DataGridView();
            this.NAME_TXT = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID_TXT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANY_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            this.Show_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.View_Company)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.SIGN_LBL);
            this.panel1.Controls.Add(this.COMPANY_LBL);
            this.panel1.Controls.Add(this.COMPANY_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 127);
            this.panel1.TabIndex = 3;
            // 
            // SIGN_LBL
            // 
            this.SIGN_LBL.AutoSize = true;
            this.SIGN_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.SIGN_LBL.Location = new System.Drawing.Point(317, 82);
            this.SIGN_LBL.Name = "SIGN_LBL";
            this.SIGN_LBL.Size = new System.Drawing.Size(232, 13);
            this.SIGN_LBL.TabIndex = 4;
            this.SIGN_LBL.Text = "---------------------------------------------------------------------------";
            // 
            // COMPANY_LBL
            // 
            this.COMPANY_LBL.AutoSize = true;
            this.COMPANY_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.COMPANY_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPANY_LBL.Location = new System.Drawing.Point(318, 34);
            this.COMPANY_LBL.Name = "COMPANY_LBL";
            this.COMPANY_LBL.Size = new System.Drawing.Size(231, 25);
            this.COMPANY_LBL.TabIndex = 3;
            this.COMPANY_LBL.Text = " UPDATE COMPANY\r\n";
            // 
            // COMPANY_BOX
            // 
            this.COMPANY_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.COMPANY_BOX.Image = ((System.Drawing.Image)(resources.GetObject("COMPANY_BOX.Image")));
            this.COMPANY_BOX.Location = new System.Drawing.Point(743, 25);
            this.COMPANY_BOX.Name = "COMPANY_BOX";
            this.COMPANY_BOX.Size = new System.Drawing.Size(127, 70);
            this.COMPANY_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COMPANY_BOX.TabIndex = 2;
            this.COMPANY_BOX.TabStop = false;
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
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(108, 353);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(84, 34);
            this.UPDATE.TabIndex = 26;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // Show_Data
            // 
            this.Show_Data.Controls.Add(this.View_Company);
            this.Show_Data.Location = new System.Drawing.Point(418, 156);
            this.Show_Data.Name = "Show_Data";
            this.Show_Data.Size = new System.Drawing.Size(431, 191);
            this.Show_Data.TabIndex = 49;
            this.Show_Data.TabStop = false;
            this.Show_Data.Text = "Show Data";
            // 
            // View_Company
            // 
            this.View_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_Company.Location = new System.Drawing.Point(6, 19);
            this.View_Company.Name = "View_Company";
            this.View_Company.Size = new System.Drawing.Size(419, 166);
            this.View_Company.TabIndex = 0;
            this.View_Company.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_Company_CellClick);
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(106, 80);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(172, 20);
            this.NAME_TXT.TabIndex = 19;
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.BackColor = System.Drawing.SystemColors.Control;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(22, 87);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(42, 13);
            this.PASSWORD.TabIndex = 17;
            this.PASSWORD.Text = "NAME";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.Control;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(22, 37);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID_TXT);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.PASSWORD);
            this.groupBox1.Controls.Add(this.NAME_TXT);
            this.groupBox1.Location = new System.Drawing.Point(22, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 140);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update_box";
            // 
            // ID_TXT
            // 
            this.ID_TXT.Location = new System.Drawing.Point(106, 30);
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(172, 20);
            this.ID_TXT.TabIndex = 20;
            // 
            // UpdateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(922, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Show_Data);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateCompany";
            this.Text = "SearchUpdateCompany";
            this.Load += new System.EventHandler(this.UpdateCompany_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANY_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.Show_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.View_Company)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SIGN_LBL;
        private System.Windows.Forms.Label COMPANY_LBL;
        private System.Windows.Forms.PictureBox COMPANY_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.GroupBox Show_Data;
        private System.Windows.Forms.DataGridView View_Company;
        private System.Windows.Forms.TextBox NAME_TXT;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ID_TXT;
    }
}