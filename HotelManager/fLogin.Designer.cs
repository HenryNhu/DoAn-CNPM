namespace HotelManager
{
    partial class fLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbPassWord = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExit_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu:";
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txbUserName.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txbUserName.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txbUserName.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txbUserName.BorderThickness = 1;
            this.txbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUserName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbUserName.isPassword = false;
            this.txbUserName.Location = new System.Drawing.Point(172, 46);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(211, 28);
            this.txbUserName.TabIndex = 0;
            this.txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbPassWord
            // 
            this.txbPassWord.BackColor = System.Drawing.SystemColors.Window;
            this.txbPassWord.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txbPassWord.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txbPassWord.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txbPassWord.BorderThickness = 1;
            this.txbPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassWord.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPassWord.isPassword = true;
            this.txbPassWord.Location = new System.Drawing.Point(172, 99);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(211, 28);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassWord_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(734, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 19;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Đăng Nhập";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(169, 474);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(208, 40);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnExit_
            // 
            this.btnExit_.ActiveBorderThickness = 1;
            this.btnExit_.ActiveCornerRadius = 20;
            this.btnExit_.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnExit_.ActiveForecolor = System.Drawing.Color.Black;
            this.btnExit_.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnExit_.BackColor = System.Drawing.Color.White;
            this.btnExit_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit_.BackgroundImage")));
            this.btnExit_.ButtonText = "Thoát";
            this.btnExit_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExit_.IdleBorderThickness = 1;
            this.btnExit_.IdleCornerRadius = 20;
            this.btnExit_.IdleFillColor = System.Drawing.Color.White;
            this.btnExit_.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit_.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnExit_.Location = new System.Drawing.Point(384, 474);
            this.btnExit_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit_.Name = "btnExit_";
            this.btnExit_.Size = new System.Drawing.Size(208, 40);
            this.btnExit_.TabIndex = 29;
            this.btnExit_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit_.Click += new System.EventHandler(this.btnExit__Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.txbPassWord);
            this.groupBox1.Controls.Add(this.txbUserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(169, 317);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(423, 150);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HotelManager.Properties.Resources._621d23cb92a9c100016587b2__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit_);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbUserName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPassWord;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit_;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

