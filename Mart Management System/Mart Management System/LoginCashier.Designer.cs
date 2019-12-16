namespace Mart_Management_System
{
    partial class LoginCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LINE_LBL2 = new System.Windows.Forms.Label();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.CASHIER_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.LOGIN_LBL = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.ID_TXT = new System.Windows.Forms.TextBox();
            this.PASSWORD_TXT = new System.Windows.Forms.TextBox();
            this.LOGIN_BUTTON = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LINE_LBL2);
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.CASHIER_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 368);
            this.panel1.TabIndex = 1;
            // 
            // LINE_LBL2
            // 
            this.LINE_LBL2.AutoSize = true;
            this.LINE_LBL2.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL2.Location = new System.Drawing.Point(44, 261);
            this.LINE_LBL2.Name = "LINE_LBL2";
            this.LINE_LBL2.Size = new System.Drawing.Size(142, 13);
            this.LINE_LBL2.TabIndex = 3;
            this.LINE_LBL2.Text = "---------------------------------------------";
            // 
            // LINE_LBL
            // 
            this.LINE_LBL.AutoSize = true;
            this.LINE_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LINE_LBL.Location = new System.Drawing.Point(44, 248);
            this.LINE_LBL.Name = "LINE_LBL";
            this.LINE_LBL.Size = new System.Drawing.Size(142, 13);
            this.LINE_LBL.TabIndex = 2;
            this.LINE_LBL.Text = "---------------------------------------------";
            // 
            // CASHIER_BOX
            // 
            this.CASHIER_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CASHIER_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CASHIER_BOX.Image")));
            this.CASHIER_BOX.Location = new System.Drawing.Point(47, 148);
            this.CASHIER_BOX.Name = "CASHIER_BOX";
            this.CASHIER_BOX.Size = new System.Drawing.Size(139, 81);
            this.CASHIER_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CASHIER_BOX.TabIndex = 1;
            this.CASHIER_BOX.TabStop = false;
            this.CASHIER_BOX.Click += new System.EventHandler(this.ADMIN_BOX_Click);
            // 
            // BACK_BOX
            // 
            this.BACK_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.BACK_BOX.Image = ((System.Drawing.Image)(resources.GetObject("BACK_BOX.Image")));
            this.BACK_BOX.Location = new System.Drawing.Point(12, 12);
            this.BACK_BOX.Name = "BACK_BOX";
            this.BACK_BOX.Size = new System.Drawing.Size(67, 43);
            this.BACK_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BACK_BOX.TabIndex = 0;
            this.BACK_BOX.TabStop = false;
            this.BACK_BOX.Click += new System.EventHandler(this.BACK_BOX_Click);
            // 
            // LOGIN_LBL
            // 
            this.LOGIN_LBL.AutoSize = true;
            this.LOGIN_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LOGIN_LBL.Location = new System.Drawing.Point(488, 65);
            this.LOGIN_LBL.Name = "LOGIN_LBL";
            this.LOGIN_LBL.Size = new System.Drawing.Size(167, 24);
            this.LOGIN_LBL.TabIndex = 5;
            this.LOGIN_LBL.Text = "LOGIN CASHIER";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.Control;
            this.ID.Location = new System.Drawing.Point(403, 170);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.ForeColor = System.Drawing.SystemColors.Control;
            this.PASSWORD.Location = new System.Drawing.Point(403, 211);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(78, 13);
            this.PASSWORD.TabIndex = 7;
            this.PASSWORD.Text = "PASSWORD\r\n";
            // 
            // ID_TXT
            // 
            this.ID_TXT.Location = new System.Drawing.Point(491, 163);
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(164, 20);
            this.ID_TXT.TabIndex = 8;
            // 
            // PASSWORD_TXT
            // 
            this.PASSWORD_TXT.Location = new System.Drawing.Point(491, 211);
            this.PASSWORD_TXT.Name = "PASSWORD_TXT";
            this.PASSWORD_TXT.Size = new System.Drawing.Size(164, 20);
            this.PASSWORD_TXT.TabIndex = 9;
            // 
            // LOGIN_BUTTON
            // 
            this.LOGIN_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_BUTTON.Location = new System.Drawing.Point(515, 279);
            this.LOGIN_BUTTON.Name = "LOGIN_BUTTON";
            this.LOGIN_BUTTON.Size = new System.Drawing.Size(116, 43);
            this.LOGIN_BUTTON.TabIndex = 10;
            this.LOGIN_BUTTON.Text = "LOGIN";
            this.LOGIN_BUTTON.UseVisualStyleBackColor = true;
            // 
            // LoginCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(826, 353);
            this.Controls.Add(this.LOGIN_BUTTON);
            this.Controls.Add(this.PASSWORD_TXT);
            this.Controls.Add(this.ID_TXT);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.LOGIN_LBL);
            this.Controls.Add(this.panel1);
            this.Name = "LoginCashier";
            this.Text = "LoginCashier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CASHIER_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LINE_LBL2;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.PictureBox CASHIER_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Label LOGIN_LBL;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.TextBox ID_TXT;
        private System.Windows.Forms.TextBox PASSWORD_TXT;
        private System.Windows.Forms.Button LOGIN_BUTTON;
    }
}