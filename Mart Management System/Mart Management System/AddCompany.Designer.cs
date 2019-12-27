namespace Mart_Management_System
{
    partial class AddCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.COMPANY_LBL = new System.Windows.Forms.Label();
            this.COMPANY_BOX = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.NAME_TXT = new System.Windows.Forms.TextBox();
            this.ADD_BUTTON = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANY_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.COMPANY_LBL);
            this.panel1.Controls.Add(this.COMPANY_BOX);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 134);
            this.panel1.TabIndex = 2;
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
            this.COMPANY_LBL.Size = new System.Drawing.Size(160, 24);
            this.COMPANY_LBL.TabIndex = 3;
            this.COMPANY_LBL.Text = "ADD COMPANY";
            // 
            // COMPANY_BOX
            // 
            this.COMPANY_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.COMPANY_BOX.Image = ((System.Drawing.Image)(resources.GetObject("COMPANY_BOX.Image")));
            this.COMPANY_BOX.Location = new System.Drawing.Point(672, 44);
            this.COMPANY_BOX.Name = "COMPANY_BOX";
            this.COMPANY_BOX.Size = new System.Drawing.Size(106, 65);
            this.COMPANY_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.COMPANY_BOX.TabIndex = 1;
            this.COMPANY_BOX.TabStop = false;
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
            this.ID.Location = new System.Drawing.Point(233, 230);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "ID";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.BackColor = System.Drawing.SystemColors.Control;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(233, 278);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(42, 13);
            this.PASSWORD.TabIndex = 18;
            this.PASSWORD.Text = "NAME";
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(335, 278);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(173, 20);
            this.NAME_TXT.TabIndex = 20;
            this.NAME_TXT.TextChanged += new System.EventHandler(this.NAME_TXT_TextChanged);
            this.NAME_TXT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Validatename);
            // 
            // ADD_BUTTON
            // 
            this.ADD_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_BUTTON.Location = new System.Drawing.Point(375, 358);
            this.ADD_BUTTON.Name = "ADD_BUTTON";
            this.ADD_BUTTON.Size = new System.Drawing.Size(84, 34);
            this.ADD_BUTTON.TabIndex = 34;
            this.ADD_BUTTON.Text = "ADD";
            this.ADD_BUTTON.UseVisualStyleBackColor = true;
            this.ADD_BUTTON.Click += new System.EventHandler(this.ADD_BUTTON_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_id.Location = new System.Drawing.Point(332, 228);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(187, 15);
            this.lbl_id.TabIndex = 57;
            this.lbl_id.Text = "*Will generate automatically";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(544, 285);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(0, 13);
            this.name_lbl.TabIndex = 58;
            // 
            // AddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.ADD_BUTTON);
            this.Controls.Add(this.NAME_TXT);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompany";
            this.Load += new System.EventHandler(this.AddCompany_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANY_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label COMPANY_LBL;
        private System.Windows.Forms.PictureBox COMPANY_BOX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.TextBox NAME_TXT;
        private System.Windows.Forms.Button ADD_BUTTON;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label name_lbl;
    }
}