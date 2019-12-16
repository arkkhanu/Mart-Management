namespace Mart_Management_System
{
    partial class DeleteCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CROSS_BOX = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.CUSTOMER_LBL = new System.Windows.Forms.Label();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.ID_LBL = new System.Windows.Forms.Label();
            this.COMPANY_COMBO = new System.Windows.Forms.ComboBox();
            this.DELETE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CROSS_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.CROSS_BOX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.CUSTOMER_LBL);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 151);
            this.panel1.TabIndex = 2;
            // 
            // CROSS_BOX
            // 
            this.CROSS_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CROSS_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CROSS_BOX.Image")));
            this.CROSS_BOX.Location = new System.Drawing.Point(474, 46);
            this.CROSS_BOX.Name = "CROSS_BOX";
            this.CROSS_BOX.Size = new System.Drawing.Size(100, 50);
            this.CROSS_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CROSS_BOX.TabIndex = 7;
            this.CROSS_BOX.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(224, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "---------------------------------------------------";
            // 
            // LINE_LBL
            // 
            this.LINE_LBL.AutoSize = true;
            this.LINE_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL.Location = new System.Drawing.Point(224, 69);
            this.LINE_LBL.Name = "LINE_LBL";
            this.LINE_LBL.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL.TabIndex = 5;
            this.LINE_LBL.Text = "---------------------------------------------------";
            // 
            // CUSTOMER_LBL
            // 
            this.CUSTOMER_LBL.AutoSize = true;
            this.CUSTOMER_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMER_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.CUSTOMER_LBL.Location = new System.Drawing.Point(223, 46);
            this.CUSTOMER_LBL.Name = "CUSTOMER_LBL";
            this.CUSTOMER_LBL.Size = new System.Drawing.Size(198, 24);
            this.CUSTOMER_LBL.TabIndex = 3;
            this.CUSTOMER_LBL.Text = "DELETE COMPANY";
            // 
            // BACK_BOX
            // 
            this.BACK_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.BACK_BOX.Image = ((System.Drawing.Image)(resources.GetObject("BACK_BOX.Image")));
            this.BACK_BOX.Location = new System.Drawing.Point(12, 46);
            this.BACK_BOX.Name = "BACK_BOX";
            this.BACK_BOX.Size = new System.Drawing.Size(100, 50);
            this.BACK_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BACK_BOX.TabIndex = 1;
            this.BACK_BOX.TabStop = false;
            // 
            // ID_LBL
            // 
            this.ID_LBL.AutoSize = true;
            this.ID_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_LBL.Location = new System.Drawing.Point(155, 285);
            this.ID_LBL.Name = "ID_LBL";
            this.ID_LBL.Size = new System.Drawing.Size(84, 13);
            this.ID_LBL.TabIndex = 13;
            this.ID_LBL.Text = "COMPANY ID";
            // 
            // COMPANY_COMBO
            // 
            this.COMPANY_COMBO.FormattingEnabled = true;
            this.COMPANY_COMBO.Location = new System.Drawing.Point(264, 282);
            this.COMPANY_COMBO.Name = "COMPANY_COMBO";
            this.COMPANY_COMBO.Size = new System.Drawing.Size(121, 21);
            this.COMPANY_COMBO.TabIndex = 16;
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Location = new System.Drawing.Point(250, 379);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(116, 43);
            this.DELETE.TabIndex = 17;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            // 
            // DeleteCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.COMPANY_COMBO);
            this.Controls.Add(this.ID_LBL);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteCompany";
            this.Text = "DeleteCompany";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CROSS_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CROSS_BOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label CUSTOMER_LBL;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Label ID_LBL;
        private System.Windows.Forms.ComboBox COMPANY_COMBO;
        private System.Windows.Forms.Button DELETE;
    }
}