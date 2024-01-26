namespace COSC_31112_Visual_Programming_Final_Project_Group19
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.rdbtnstaff = new System.Windows.Forms.RadioButton();
            this.rdbtnadministrator = new System.Windows.Forms.RadioButton();
            this.txtun = new System.Windows.Forms.TextBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.lblun = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbllogintype = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtnstaff
            // 
            this.rdbtnstaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnstaff.AutoSize = true;
            this.rdbtnstaff.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnstaff.ForeColor = System.Drawing.Color.Black;
            this.rdbtnstaff.Location = new System.Drawing.Point(448, 249);
            this.rdbtnstaff.Name = "rdbtnstaff";
            this.rdbtnstaff.Size = new System.Drawing.Size(69, 32);
            this.rdbtnstaff.TabIndex = 19;
            this.rdbtnstaff.TabStop = true;
            this.rdbtnstaff.Text = "Staff";
            this.rdbtnstaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnstaff.UseVisualStyleBackColor = true;
            // 
            // rdbtnadministrator
            // 
            this.rdbtnadministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbtnadministrator.AutoSize = true;
            this.rdbtnadministrator.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnadministrator.ForeColor = System.Drawing.Color.Black;
            this.rdbtnadministrator.Location = new System.Drawing.Point(549, 249);
            this.rdbtnadministrator.Name = "rdbtnadministrator";
            this.rdbtnadministrator.Size = new System.Drawing.Size(151, 32);
            this.rdbtnadministrator.TabIndex = 18;
            this.rdbtnadministrator.TabStop = true;
            this.rdbtnadministrator.Text = "Administrator";
            this.rdbtnadministrator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnadministrator.UseVisualStyleBackColor = true;
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(448, 326);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(252, 20);
            this.txtun.TabIndex = 21;
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.ForeColor = System.Drawing.Color.Black;
            this.lblpw.Location = new System.Drawing.Point(277, 387);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(102, 28);
            this.lblpw.TabIndex = 17;
            this.lblpw.Text = "Password :";
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(448, 390);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(252, 20);
            this.txtpw.TabIndex = 20;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.ForeColor = System.Drawing.Color.Black;
            this.lblun.Location = new System.Drawing.Point(277, 323);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(108, 28);
            this.lblun.TabIndex = 16;
            this.lblun.Text = "Username :";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(448, 474);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(128, 48);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            this.btnexit.MouseEnter += new System.EventHandler(this.btnexit_MouseEnter);
            this.btnexit.MouseLeave += new System.EventHandler(this.btnexit_MouseLeave);
            // 
            // lbllogintype
            // 
            this.lbllogintype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllogintype.AutoSize = true;
            this.lbllogintype.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogintype.ForeColor = System.Drawing.Color.Black;
            this.lbllogintype.Location = new System.Drawing.Point(277, 253);
            this.lbllogintype.Name = "lbllogintype";
            this.lbllogintype.Size = new System.Drawing.Size(124, 28);
            this.lbllogintype.TabIndex = 15;
            this.lbllogintype.Text = "Log-In Type :";
            this.lbllogintype.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Black;
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(279, 474);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(128, 48);
            this.btnlogin.TabIndex = 22;
            this.btnlogin.Text = "Log-In";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            this.btnlogin.MouseEnter += new System.EventHandler(this.btnlogin_MouseEnter);
            this.btnlogin.MouseLeave += new System.EventHandler(this.btnlogin_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(241, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(240, 323);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(240, 387);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 559);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbllogintype);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.rdbtnadministrator);
            this.Controls.Add(this.rdbtnstaff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm1";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbtnstaff;
        private System.Windows.Forms.RadioButton rdbtnadministrator;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbllogintype;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

