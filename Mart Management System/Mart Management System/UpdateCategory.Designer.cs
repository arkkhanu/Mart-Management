namespace Mart_Management_System
{
    partial class UpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIGN_LBL = new System.Windows.Forms.Label();
            this.SIGNUP_LBL = new System.Windows.Forms.Label();
            this.CATEGORY_BOX = new System.Windows.Forms.PictureBox();
            this.BACK_BOX = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.NAME_TXT = new System.Windows.Forms.TextBox();
            this.UPDATE = new System.Windows.Forms.Button();
            this.cat_data = new System.Windows.Forms.DataGridView();
            this.ID_TXT = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CATEGORY_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.SIGN_LBL);
            this.panel1.Controls.Add(this.SIGNUP_LBL);
            this.panel1.Controls.Add(this.CATEGORY_BOX);
            this.panel1.Controls.Add(this.BACK_BOX);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 127);
            this.panel1.TabIndex = 2;
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
            // SIGNUP_LBL
            // 
            this.SIGNUP_LBL.AutoSize = true;
            this.SIGNUP_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.SIGNUP_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIGNUP_LBL.Location = new System.Drawing.Point(240, 34);
            this.SIGNUP_LBL.Name = "SIGNUP_LBL";
            this.SIGNUP_LBL.Size = new System.Drawing.Size(236, 25);
            this.SIGNUP_LBL.TabIndex = 3;
            this.SIGNUP_LBL.Text = "UPDATE CATEGORY";
            // 
            // CATEGORY_BOX
            // 
            this.CATEGORY_BOX.BackColor = System.Drawing.SystemColors.Control;
            this.CATEGORY_BOX.Image = ((System.Drawing.Image)(resources.GetObject("CATEGORY_BOX.Image")));
            this.CATEGORY_BOX.Location = new System.Drawing.Point(812, 25);
            this.CATEGORY_BOX.Name = "CATEGORY_BOX";
            this.CATEGORY_BOX.Size = new System.Drawing.Size(127, 70);
            this.CATEGORY_BOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CATEGORY_BOX.TabIndex = 2;
            this.CATEGORY_BOX.TabStop = false;
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
            this.ID.Location = new System.Drawing.Point(31, 187);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 13);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.BackColor = System.Drawing.SystemColors.Control;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(31, 241);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(42, 13);
            this.NAME.TabIndex = 16;
            this.NAME.Text = "NAME";
            // 
            // NAME_TXT
            // 
            this.NAME_TXT.Location = new System.Drawing.Point(138, 234);
            this.NAME_TXT.Name = "NAME_TXT";
            this.NAME_TXT.Size = new System.Drawing.Size(173, 20);
            this.NAME_TXT.TabIndex = 18;
            this.NAME_TXT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.validatename);
            // 
            // UPDATE
            // 
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(248, 371);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(290, 34);
            this.UPDATE.TabIndex = 25;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // cat_data
            // 
            this.cat_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cat_data.Location = new System.Drawing.Point(567, 168);
            this.cat_data.Name = "cat_data";
            this.cat_data.Size = new System.Drawing.Size(383, 150);
            this.cat_data.TabIndex = 26;
            this.cat_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cat_data_CellClick);
            // 
            // ID_TXT
            // 
            this.ID_TXT.Enabled = false;
            this.ID_TXT.Location = new System.Drawing.Point(138, 187);
            this.ID_TXT.Name = "ID_TXT";
            this.ID_TXT.Size = new System.Drawing.Size(173, 20);
            this.ID_TXT.TabIndex = 27;
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(347, 241);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(0, 13);
            this.Name_lbl.TabIndex = 28;
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.ID_TXT);
            this.Controls.Add(this.cat_data);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.NAME_TXT);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchUpdateCategory";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CATEGORY_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACK_BOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SIGN_LBL;
        private System.Windows.Forms.Label SIGNUP_LBL;
        private System.Windows.Forms.PictureBox CATEGORY_BOX;
        private System.Windows.Forms.PictureBox BACK_BOX;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.TextBox NAME_TXT;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.DataGridView cat_data;
        private System.Windows.Forms.TextBox ID_TXT;
        private System.Windows.Forms.Label Name_lbl;
    }
}