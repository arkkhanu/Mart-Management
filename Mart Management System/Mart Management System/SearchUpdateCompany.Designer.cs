namespace Mart_Management_System
{
    partial class SearchUpdateCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUpdateCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIGN_LBL = new System.Windows.Forms.Label();
            this.COMPANY_LBL = new System.Windows.Forms.Label();
            this.COMPANY_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.ID_COMBO = new System.Windows.Forms.ComboBox();
            this.PASSWORD_TXT = new System.Windows.Forms.TextBox();
            this.SEARCH_BUTTON = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANY_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
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
            // COMPANY_LBL
            // 
            this.COMPANY_LBL.AutoSize = true;
            this.COMPANY_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.COMPANY_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPANY_LBL.Location = new System.Drawing.Point(183, 34);
            this.COMPANY_LBL.Name = "COMPANY_LBL";
            this.COMPANY_LBL.Size = new System.Drawing.Size(378, 25);
            this.COMPANY_LBL.TabIndex = 3;
            this.COMPANY_LBL.Text = "SEARCH AND UPDATE COMPANY\r\n";
            // 
            // COMPANY_BOX
            // 
            this.COMPANY_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.COMPANY_BOX.Image = ((System.Drawing.Image)(resources.GetObject("COMPANY_BOX.Image")));
            this.COMPANY_BOX.Location = new System.Drawing.Point(606, 34);
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
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.SystemColors.Control;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ID.Location = new System.Drawing.Point(235, 225);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.BackColor = System.Drawing.SystemColors.Control;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(235, 284);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(78, 13);
            this.PASSWORD.TabIndex = 17;
            this.PASSWORD.Text = "PASSWORD";
            // 
            // ID_COMBO
            // 
            this.ID_COMBO.FormattingEnabled = true;
            this.ID_COMBO.Location = new System.Drawing.Point(347, 222);
            this.ID_COMBO.Name = "ID_COMBO";
            this.ID_COMBO.Size = new System.Drawing.Size(173, 21);
            this.ID_COMBO.TabIndex = 18;
            // 
            // PASSWORD_TXT
            // 
            this.PASSWORD_TXT.Location = new System.Drawing.Point(347, 277);
            this.PASSWORD_TXT.Name = "PASSWORD_TXT";
            this.PASSWORD_TXT.Size = new System.Drawing.Size(173, 20);
            this.PASSWORD_TXT.TabIndex = 19;
            // 
            // SEARCH_BUTTON
            // 
            this.SEARCH_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH_BUTTON.Location = new System.Drawing.Point(276, 389);
            this.SEARCH_BUTTON.Name = "SEARCH_BUTTON";
            this.SEARCH_BUTTON.Size = new System.Drawing.Size(84, 34);
            this.SEARCH_BUTTON.TabIndex = 25;
            this.SEARCH_BUTTON.Text = "SEARCH";
            this.SEARCH_BUTTON.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(414, 389);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(84, 34);
            this.UPDATE.TabIndex = 26;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            // 
            // SearchUpdateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.SEARCH_BUTTON);
            this.Controls.Add(this.PASSWORD_TXT);
            this.Controls.Add(this.ID_COMBO);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel1);
            this.Name = "SearchUpdateCompany";
            this.Text = "SearchUpdateCompany";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANY_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SIGN_LBL;
        private System.Windows.Forms.Label COMPANY_LBL;
        private System.Windows.Forms.PictureBox COMPANY_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.ComboBox ID_COMBO;
        private System.Windows.Forms.TextBox PASSWORD_TXT;
        private System.Windows.Forms.Button SEARCH_BUTTON;
        private System.Windows.Forms.Button UPDATE;
    }
}