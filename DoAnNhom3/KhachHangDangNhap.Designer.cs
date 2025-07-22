namespace DoAnNhom3
{
    partial class KhachHangDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btdangxuatKH = new System.Windows.Forms.Button();
            this.btqlitaikhoanKH = new System.Windows.Forms.Button();
            this.btmenuKH = new System.Windows.Forms.Button();
            this.panelkhachhang = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panelkhachhang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btdangxuatKH);
            this.panel1.Controls.Add(this.btqlitaikhoanKH);
            this.panel1.Controls.Add(this.btmenuKH);
            this.panel1.Location = new System.Drawing.Point(2, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 398);
            this.panel1.TabIndex = 0;
            // 
            // btdangxuatKH
            // 
            this.btdangxuatKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangxuatKH.ForeColor = System.Drawing.Color.Black;
            this.btdangxuatKH.Location = new System.Drawing.Point(66, 264);
            this.btdangxuatKH.Name = "btdangxuatKH";
            this.btdangxuatKH.Size = new System.Drawing.Size(127, 45);
            this.btdangxuatKH.TabIndex = 8;
            this.btdangxuatKH.Text = "Đăng xuất";
            this.btdangxuatKH.UseVisualStyleBackColor = true;
            // 
            // btqlitaikhoanKH
            // 
            this.btqlitaikhoanKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btqlitaikhoanKH.ForeColor = System.Drawing.Color.Black;
            this.btqlitaikhoanKH.Location = new System.Drawing.Point(69, 170);
            this.btqlitaikhoanKH.Name = "btqlitaikhoanKH";
            this.btqlitaikhoanKH.Size = new System.Drawing.Size(127, 45);
            this.btqlitaikhoanKH.TabIndex = 7;
            this.btqlitaikhoanKH.Text = "Tài khoản";
            this.btqlitaikhoanKH.UseVisualStyleBackColor = true;
            // 
            // btmenuKH
            // 
            this.btmenuKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenuKH.ForeColor = System.Drawing.Color.Black;
            this.btmenuKH.Location = new System.Drawing.Point(69, 71);
            this.btmenuKH.Name = "btmenuKH";
            this.btmenuKH.Size = new System.Drawing.Size(127, 45);
            this.btmenuKH.TabIndex = 6;
            this.btmenuKH.Text = "Menu";
            this.btmenuKH.UseVisualStyleBackColor = true;
            // 
            // panelkhachhang
            // 
            this.panelkhachhang.Controls.Add(this.button1);
            this.panelkhachhang.Controls.Add(this.flowLayoutPanel1);
            this.panelkhachhang.Location = new System.Drawing.Point(204, 48);
            this.panelkhachhang.Name = "panelkhachhang";
            this.panelkhachhang.Size = new System.Drawing.Size(692, 488);
            this.panelkhachhang.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(290, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 69);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(689, 418);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // KhachHangDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 532);
            this.Controls.Add(this.panelkhachhang);
            this.Controls.Add(this.panel1);
            this.Name = "KhachHangDangNhap";
            this.Text = "KhachHangDangNhap";
       //     this.Load += new System.EventHandler(this.KhachHangDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panelkhachhang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btqlitaikhoanKH;
        private System.Windows.Forms.Button btmenuKH;
        private System.Windows.Forms.Button btdangxuatKH;
        private System.Windows.Forms.Panel panelkhachhang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}