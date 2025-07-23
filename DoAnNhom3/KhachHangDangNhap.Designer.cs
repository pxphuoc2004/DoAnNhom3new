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
            panel1 = new Panel();
            btdangxuatKH = new Button();
            btqlitaikhoanKH = new Button();
            btmenuKH = new Button();
            panelkhachhang = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panelkhachhang.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btdangxuatKH);
            panel1.Controls.Add(btqlitaikhoanKH);
            panel1.Controls.Add(btmenuKH);
            panel1.Location = new Point(2, 159);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 507);
            panel1.TabIndex = 0;
            // 
            // btdangxuatKH
            // 
            btdangxuatKH.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btdangxuatKH.ForeColor = Color.Black;
            btdangxuatKH.Location = new Point(77, 305);
            btdangxuatKH.Margin = new Padding(4, 3, 4, 3);
            btdangxuatKH.Name = "btdangxuatKH";
            btdangxuatKH.Size = new Size(148, 52);
            btdangxuatKH.TabIndex = 8;
            btdangxuatKH.Text = "Đăng xuất";
            btdangxuatKH.UseVisualStyleBackColor = true;
            // 
            // btqlitaikhoanKH
            // 
            btqlitaikhoanKH.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqlitaikhoanKH.ForeColor = Color.Black;
            btqlitaikhoanKH.Location = new Point(80, 196);
            btqlitaikhoanKH.Margin = new Padding(4, 3, 4, 3);
            btqlitaikhoanKH.Name = "btqlitaikhoanKH";
            btqlitaikhoanKH.Size = new Size(148, 52);
            btqlitaikhoanKH.TabIndex = 7;
            btqlitaikhoanKH.Text = "Tài khoản";
            btqlitaikhoanKH.UseVisualStyleBackColor = true;
            btqlitaikhoanKH.Click += btqlitaikhoanKH_Click;
            // 
            // btmenuKH
            // 
            btmenuKH.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmenuKH.ForeColor = Color.Black;
            btmenuKH.Location = new Point(80, 82);
            btmenuKH.Margin = new Padding(4, 3, 4, 3);
            btmenuKH.Name = "btmenuKH";
            btmenuKH.Size = new Size(148, 52);
            btmenuKH.TabIndex = 6;
            btmenuKH.Text = "Menu";
            btmenuKH.UseVisualStyleBackColor = true;
            // 
            // panelkhachhang
            // 
            panelkhachhang.Controls.Add(label1);
            panelkhachhang.Controls.Add(flowLayoutPanel1);
            panelkhachhang.Location = new Point(251, 60);
            panelkhachhang.Margin = new Padding(4, 3, 4, 3);
            panelkhachhang.Name = "panelkhachhang";
            panelkhachhang.Size = new Size(807, 563);
            panelkhachhang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 17);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 72);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(799, 488);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // KhachHangDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 614);
            Controls.Add(panelkhachhang);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KhachHangDangNhap";
            Text = "KhachHangDangNhap";
            Load += KhachHangDangNhap_Load;
            panel1.ResumeLayout(false);
            panelkhachhang.ResumeLayout(false);
            panelkhachhang.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btqlitaikhoanKH;
        private System.Windows.Forms.Button btmenuKH;
        private System.Windows.Forms.Button btdangxuatKH;
        private Label label1;
        public Panel panelkhachhang;
        public FlowLayoutPanel flowLayoutPanel1;
    }
}