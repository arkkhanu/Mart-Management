﻿namespace Mart_Management_System
{
    partial class CustomersDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.LINE_LBL2 = new System.Windows.Forms.Label();
            this.CUSTOMER_LBL = new System.Windows.Forms.Label();
            this.CUSTOMER_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.NumericUpDown();
            this.ID_LBL = new System.Windows.Forms.Label();
            this.CUSTOMER_VIEW = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.LINE_LBL2);
            this.panel1.Controls.Add(this.CUSTOMER_LBL);
            this.panel1.Controls.Add(this.CUSTOMER_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 161);
            this.panel1.TabIndex = 5;
            // 
            // LINE_LBL
            // 
            this.LINE_LBL.AutoSize = true;
            this.LINE_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL.Location = new System.Drawing.Point(340, 72);
            this.LINE_LBL.Name = "LINE_LBL";
            this.LINE_LBL.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL.TabIndex = 4;
            this.LINE_LBL.Text = "---------------------------------------------------";
            // 
            // LINE_LBL2
            // 
            this.LINE_LBL2.AutoSize = true;
            this.LINE_LBL2.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL2.Location = new System.Drawing.Point(340, 85);
            this.LINE_LBL2.Name = "LINE_LBL2";
            this.LINE_LBL2.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL2.TabIndex = 3;
            this.LINE_LBL2.Text = "---------------------------------------------------";
            // 
            // CUSTOMER_LBL
            // 
            this.CUSTOMER_LBL.AutoSize = true;
            this.CUSTOMER_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSTOMER_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.CUSTOMER_LBL.Location = new System.Drawing.Point(314, 46);
            this.CUSTOMER_LBL.Name = "CUSTOMER_LBL";
            this.CUSTOMER_LBL.Size = new System.Drawing.Size(215, 72);
            this.CUSTOMER_LBL.TabIndex = 2;
            this.CUSTOMER_LBL.Text = "CUSTOMER DETAILS\r\n\r\n\r\n";
            // 
            // CUSTOMER_BOX
            // 
            this.CUSTOMER_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CUSTOMER_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CUSTOMER_BOX.Image")));
            this.CUSTOMER_BOX.Location = new System.Drawing.Point(664, 46);
            this.CUSTOMER_BOX.Name = "CUSTOMER_BOX";
            this.CUSTOMER_BOX.Size = new System.Drawing.Size(144, 65);
            this.CUSTOMER_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CUSTOMER_BOX.TabIndex = 1;
            this.CUSTOMER_BOX.TabStop = false;
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
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(383, 248);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "View";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(371, 193);
            this.txt_id.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(120, 20);
            this.txt_id.TabIndex = 14;
            // 
            // ID_LBL
            // 
            this.ID_LBL.AutoSize = true;
            this.ID_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_LBL.Location = new System.Drawing.Point(240, 195);
            this.ID_LBL.Name = "ID_LBL";
            this.ID_LBL.Size = new System.Drawing.Size(93, 13);
            this.ID_LBL.TabIndex = 13;
            this.ID_LBL.Text = "CUSTOMER ID";
            // 
            // CUSTOMER_VIEW
            // 
            this.CUSTOMER_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CUSTOMER_VIEW.Location = new System.Drawing.Point(2, 296);
            this.CUSTOMER_VIEW.Name = "CUSTOMER_VIEW";
            this.CUSTOMER_VIEW.Size = new System.Drawing.Size(853, 150);
            this.CUSTOMER_VIEW.TabIndex = 16;
            // 
            // CustomersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(855, 481);
            this.Controls.Add(this.CUSTOMER_VIEW);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.ID_LBL);
            this.Controls.Add(this.panel1);
            this.Name = "CustomersDetails";
            this.Text = "CustomersDetails";
            this.Load += new System.EventHandler(this.CustomersDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_VIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label LINE_LBL2;
        private System.Windows.Forms.Label CUSTOMER_LBL;
        private System.Windows.Forms.PictureBox CUSTOMER_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.NumericUpDown txt_id;
        private System.Windows.Forms.Label ID_LBL;
        private System.Windows.Forms.DataGridView CUSTOMER_VIEW;
    }
}