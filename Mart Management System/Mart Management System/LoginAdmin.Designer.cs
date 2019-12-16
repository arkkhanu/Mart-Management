namespace Mart_Management_System
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.ADMIN_BOX = new System.Windows.Forms.PictureBox();
            this.LINE_LBL = new System.Windows.Forms.Label();
            this.LINE_LBL2 = new System.Windows.Forms.Label();
            this.LOGIN_LBL = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.ID_TXT = new System.Windows.Forms.TextBox();
            this.PASSWORD_TXT = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADMIN_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LINE_LBL2);
            this.panel1.Controls.Add(this.LINE_LBL);
            this.panel1.Controls.Add(this.ADMIN_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 346);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // 
            // ADMIN_BOX
            // 
            this.ADMIN_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.ADMIN_BOX.Image = ((System.Drawing.Image)(resources.GetObject("ADMIN_BOX.Image")));
            this.ADMIN_BOX.Location = new System.Drawing.Point(47, 148);
            this.ADMIN_BOX.Name = "ADMIN_BOX";
            this.ADMIN_BOX.Size = new System.Drawing.Size(139, 81);
            this.ADMIN_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ADMIN_BOX.TabIndex = 1;
            this.ADMIN_BOX.TabStop = false;
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
            // LOGIN_LBL
            // 
            this.LOGIN_LBL.AutoSize = true;
            this.LOGIN_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_LBL.ForeColor = System.Drawing.SystemColors.Control;
            this.LOGIN_LBL.Location = new System.Drawing.Point(430, 67);
            this.LOGIN_LBL.Name = "LOGIN_LBL";
            this.LOGIN_LBL.Size = new System.Drawing.Size(143, 24);
            this.LOGIN_LBL.TabIndex = 4;
            this.LOGIN_LBL.Text = "LOGIN ADMIN";
            this.LOGIN_LBL.Click += new System.EventHandler(this.label3_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.Control;
            this.ID.Location = new System.Drawing.Point(341, 165);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.ForeColor = System.Drawing.SystemColors.Control;
            this.PASSWORD.Location = new System.Drawing.Point(341, 201);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(78, 13);
            this.PASSWORD.TabIndex = 5;
            this.PASSWORD.Text = "PASSWORD\r\n";
            // 
            // ID_TXT
            // 
            this.ID_TXT.Location = new System.Drawing.Point(422, 162);
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(164, 20);
            this.ID_TXT.TabIndex = 6;
            // 
            // PASSWORD_TXT
            // 
            this.PASSWORD_TXT.Location = new System.Drawing.Point(422, 198);
            this.PASSWORD_TXT.Name = "PASSWORD_TXT";
            this.PASSWORD_TXT.Size = new System.Drawing.Size(164, 20);
            this.PASSWORD_TXT.TabIndex = 7;
            // 
            // LOGIN
            // 
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(443, 270);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(116, 43);
            this.LOGIN.TabIndex = 8;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(743, 341);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.PASSWORD_TXT);
            this.Controls.Add(this.ID_TXT);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.LOGIN_LBL);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADMIN_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ADMIN_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Label LINE_LBL2;
        private System.Windows.Forms.Label LINE_LBL;
        private System.Windows.Forms.Label LOGIN_LBL;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.TextBox ID_TXT;
        private System.Windows.Forms.TextBox PASSWORD_TXT;
        private System.Windows.Forms.Button LOGIN;
    }
}