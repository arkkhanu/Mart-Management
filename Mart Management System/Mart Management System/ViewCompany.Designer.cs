﻿namespace Mart_Management_System
{
    partial class ViewCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.LINE_LBL2 = new System.Windows.Forms.Label();
            this.COMPANY_LBL = new System.Windows.Forms.Label();
            this.LOOK_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.COMPANY_VIEW = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOOK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANY_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.LINE_LBL2);
            this.panel1.Controls.Add(this.COMPANY_LBL);
            this.panel1.Controls.Add(this.LOOK_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 161);
            this.panel1.TabIndex = 1;
            // 
            // LINE_LBL
            // 
            this.LINE_LBL.AutoSize = true;
            this.LINE_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL.Location = new System.Drawing.Point(326, 85);
            this.LINE_LBL.Name = "LINE_LBL";
            this.LINE_LBL.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL.TabIndex = 4;
            this.LINE_LBL.Text = "---------------------------------------------------";
            // 
            // LINE_LBL2
            // 
            this.LINE_LBL2.AutoSize = true;
            this.LINE_LBL2.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL2.Location = new System.Drawing.Point(326, 98);
            this.LINE_LBL2.Name = "LINE_LBL2";
            this.LINE_LBL2.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL2.TabIndex = 3;
            this.LINE_LBL2.Text = "---------------------------------------------------";
            // 
            // COMPANY_LBL
            // 
            this.COMPANY_LBL.AutoSize = true;
            this.COMPANY_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPANY_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.COMPANY_LBL.Location = new System.Drawing.Point(320, 56);
            this.COMPANY_LBL.Name = "COMPANY_LBL";
            this.COMPANY_LBL.Size = new System.Drawing.Size(170, 24);
            this.COMPANY_LBL.TabIndex = 2;
            this.COMPANY_LBL.Text = "VIEW COMPANY";
            // 
            // LOOK_BOX
            // 
            this.LOOK_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.LOOK_BOX.Image = ((System.Drawing.Image)(resources.GetObject("LOOK_BOX.Image")));
            this.LOOK_BOX.Location = new System.Drawing.Point(664, 46);
            this.LOOK_BOX.Name = "LOOK_BOX";
            this.LOOK_BOX.Size = new System.Drawing.Size(100, 50);
            this.LOOK_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOOK_BOX.TabIndex = 1;
            this.LOOK_BOX.TabStop = false;
            // 
            // BACK_BOX
            // 
            this.BACK_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.BACK_BOX.Image = ((System.Drawing.Image)(resources.GetObject("BACK_BOX.Image")));
            this.BACK_BOX.Location = new System.Drawing.Point(25, 46);
            this.BACK_BOX.Name = "BACK_BOX";
            this.BACK_BOX.Size = new System.Drawing.Size(100, 50);
            this.BACK_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BACK_BOX.TabIndex = 0;
            this.BACK_BOX.TabStop = false;
            // 
            // COMPANY_VIEW
            // 
            this.COMPANY_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COMPANY_VIEW.Location = new System.Drawing.Point(1, 157);
            this.COMPANY_VIEW.Name = "COMPANY_VIEW";
            this.COMPANY_VIEW.Size = new System.Drawing.Size(798, 150);
            this.COMPANY_VIEW.TabIndex = 5;
            this.COMPANY_VIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.COMPANY_VIEW_CellContentClick);
            // 
            // ViewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.COMPANY_VIEW);
            this.Controls.Add(this.panel1);
            this.Name = "ViewCompany";
            this.Text = "ViewCompany";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOOK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPANY_VIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label LINE_LBL2;
        private System.Windows.Forms.Label COMPANY_LBL;
        private System.Windows.Forms.PictureBox LOOK_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.DataGridView COMPANY_VIEW;
    }
}