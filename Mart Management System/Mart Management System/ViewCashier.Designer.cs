﻿namespace Mart_Management_System
{
    partial class ViewCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.LINE_LBL2 = new System.Windows.Forms.Label();
            this.CASHIER_LBL = new System.Windows.Forms.Label();
            this.LOOK_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.CASHIER_VIEW = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.NumericUpDown();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOOK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.LINE_LBL2);
            this.panel1.Controls.Add(this.CASHIER_LBL);
            this.panel1.Controls.Add(this.LOOK_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 161);
            this.panel1.TabIndex = 2;
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
            // CASHIER_LBL
            // 
            this.CASHIER_LBL.AutoSize = true;
            this.CASHIER_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CASHIER_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.CASHIER_LBL.Location = new System.Drawing.Point(320, 56);
            this.CASHIER_LBL.Name = "CASHIER_LBL";
            this.CASHIER_LBL.Size = new System.Drawing.Size(157, 24);
            this.CASHIER_LBL.TabIndex = 2;
            this.CASHIER_LBL.Text = "VIEW CASHIER";
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
            this.BACK_BOX.Click += new System.EventHandler(this.BACK_BOX_Click);
            // 
            // CASHIER_VIEW
            // 
            this.CASHIER_VIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CASHIER_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CASHIER_VIEW.Location = new System.Drawing.Point(12, 288);
            this.CASHIER_VIEW.Name = "CASHIER_VIEW";
            this.CASHIER_VIEW.Size = new System.Drawing.Size(785, 150);
            this.CASHIER_VIEW.TabIndex = 6;
            this.CASHIER_VIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.COMPANY_VIEW_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(383, 234);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "View";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(435, 193);
            this.txt_id.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(120, 20);
            this.txt_id.TabIndex = 13;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(196, 193);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(210, 18);
            this.lbl_id.TabIndex = 12;
            this.lbl_id.Text = "Enter Cashier ID to Search";
            // 
            // ViewCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.CASHIER_VIEW);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCashier";
            this.Load += new System.EventHandler(this.ViewCashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOOK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label LINE_LBL2;
        private System.Windows.Forms.Label CASHIER_LBL;
        private System.Windows.Forms.PictureBox LOOK_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.DataGridView CASHIER_VIEW;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.NumericUpDown txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}