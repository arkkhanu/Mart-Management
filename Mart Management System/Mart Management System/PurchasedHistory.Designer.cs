namespace Mart_Management_System
{
    partial class PurchasedHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasedHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.LINE_LBL2 = new System.Windows.Forms.Label();
            this.CUSTOMER_LBL = new System.Windows.Forms.Label();
            this.CUSTOMER_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.history_grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.history_grid)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 161);
            this.panel1.TabIndex = 5;
            // 
            // LINE_LBL
            // 
            this.LINE_LBL.AutoSize = true;
            this.LINE_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL.Location = new System.Drawing.Point(315, 83);
            this.LINE_LBL.Name = "LINE_LBL";
            this.LINE_LBL.Size = new System.Drawing.Size(160, 13);
            this.LINE_LBL.TabIndex = 4;
            this.LINE_LBL.Text = "---------------------------------------------------";
            // 
            // LINE_LBL2
            // 
            this.LINE_LBL2.AutoSize = true;
            this.LINE_LBL2.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL2.Location = new System.Drawing.Point(315, 96);
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
            this.CUSTOMER_LBL.Location = new System.Drawing.Point(285, 46);
            this.CUSTOMER_LBL.Name = "CUSTOMER_LBL";
            this.CUSTOMER_LBL.Size = new System.Drawing.Size(212, 24);
            this.CUSTOMER_LBL.TabIndex = 2;
            this.CUSTOMER_LBL.Text = "CUSTOMER PORTAL\r\n";
            // 
            // CUSTOMER_BOX
            // 
            this.CUSTOMER_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CUSTOMER_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CUSTOMER_BOX.Image")));
            this.CUSTOMER_BOX.Location = new System.Drawing.Point(664, 46);
            this.CUSTOMER_BOX.Name = "CUSTOMER_BOX";
            this.CUSTOMER_BOX.Size = new System.Drawing.Size(100, 50);
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
            // history_grid
            // 
            this.history_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.history_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history_grid.Location = new System.Drawing.Point(1, 158);
            this.history_grid.Name = "history_grid";
            this.history_grid.Size = new System.Drawing.Size(801, 201);
            this.history_grid.TabIndex = 6;
            // 
            // PurchasedHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.history_grid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PurchasedHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasedHistory";
            this.Load += new System.EventHandler(this.PurchasedHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTOMER_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.history_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label LINE_LBL2;
        private System.Windows.Forms.Label CUSTOMER_LBL;
        private System.Windows.Forms.PictureBox CUSTOMER_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.DataGridView history_grid;


    }
}