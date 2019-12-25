namespace Mart_Management_System
{
    partial class TransactionOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionOperation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.LINE_LBL2 = new System.Windows.Forms.Label();
            this.CATEGORY_LBL = new System.Windows.Forms.Label();
            this.CHART_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.TRANSACTION_VIEW = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSACTION_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.LINE_LBL2);
            this.panel1.Controls.Add(this.CATEGORY_LBL);
            this.panel1.Controls.Add(this.CHART_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 161);
            this.panel1.TabIndex = 3;
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
            // CATEGORY_LBL
            // 
            this.CATEGORY_LBL.AutoSize = true;
            this.CATEGORY_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CATEGORY_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.CATEGORY_LBL.Location = new System.Drawing.Point(320, 56);
            this.CATEGORY_LBL.Name = "CATEGORY_LBL";
            this.CATEGORY_LBL.Size = new System.Drawing.Size(169, 24);
            this.CATEGORY_LBL.TabIndex = 2;
            this.CATEGORY_LBL.Text = "TRANSACTIONS";
            // 
            // CHART_BOX
            // 
            this.CHART_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CHART_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CHART_BOX.Image")));
            this.CHART_BOX.Location = new System.Drawing.Point(664, 46);
            this.CHART_BOX.Name = "CHART_BOX";
            this.CHART_BOX.Size = new System.Drawing.Size(144, 65);
            this.CHART_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CHART_BOX.TabIndex = 1;
            this.CHART_BOX.TabStop = false;
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
            // TRANSACTION_VIEW
            // 
            this.TRANSACTION_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TRANSACTION_VIEW.Location = new System.Drawing.Point(0, 215);
            this.TRANSACTION_VIEW.Name = "TRANSACTION_VIEW";
            this.TRANSACTION_VIEW.Size = new System.Drawing.Size(853, 150);
            this.TRANSACTION_VIEW.TabIndex = 7;
            // 
            // TransactionOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(854, 404);
            this.Controls.Add(this.TRANSACTION_VIEW);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionOperation";
            this.Text = "TransactionOperation";
            this.Load += new System.EventHandler(this.TransactionOperation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRANSACTION_VIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label LINE_LBL2;
        private System.Windows.Forms.Label CATEGORY_LBL;
        private System.Windows.Forms.PictureBox CHART_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.DataGridView TRANSACTION_VIEW;
    }
}