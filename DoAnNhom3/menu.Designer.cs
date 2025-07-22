namespace DoAnNhom3
{
    partial class Menu
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
            btqlnhanvien = new Button();
            btbaocao = new Button();
            btkhuyenmai = new Button();
            btkhonguyenlieu = new Button();
            btqldanhmuc = new Button();
            btqlkhachhang = new Button();
            panel1 = new Panel();
            panelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btqlnhanvien
            // 
            btqlnhanvien.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqlnhanvien.Location = new Point(66, 140);
            btqlnhanvien.Margin = new Padding(4, 3, 4, 3);
            btqlnhanvien.Name = "btqlnhanvien";
            btqlnhanvien.Size = new Size(175, 52);
            btqlnhanvien.TabIndex = 0;
            btqlnhanvien.Text = "Quản lí nhân viên";
            btqlnhanvien.UseVisualStyleBackColor = true;
            // 
            // btbaocao
            // 
            btbaocao.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btbaocao.Location = new Point(56, 520);
            btbaocao.Margin = new Padding(4, 3, 4, 3);
            btbaocao.Name = "btbaocao";
            btbaocao.Size = new Size(180, 52);
            btbaocao.TabIndex = 1;
            btbaocao.Text = "Báo cáo thống kê";
            btbaocao.UseVisualStyleBackColor = true;
            btbaocao.Click += btbaocao_Click;
            // 
            // btkhuyenmai
            // 
            btkhuyenmai.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btkhuyenmai.Location = new Point(102, 323);
            btkhuyenmai.Margin = new Padding(4, 3, 4, 3);
            btkhuyenmai.Name = "btkhuyenmai";
            btkhuyenmai.Size = new Size(140, 52);
            btkhuyenmai.TabIndex = 2;
            btkhuyenmai.Text = "Khuyến mãi";
            btkhuyenmai.UseVisualStyleBackColor = true;
            // 
            // btkhonguyenlieu
            // 
            btkhonguyenlieu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btkhonguyenlieu.Location = new Point(69, 414);
            btkhonguyenlieu.Margin = new Padding(4, 3, 4, 3);
            btkhonguyenlieu.Name = "btkhonguyenlieu";
            btkhonguyenlieu.Size = new Size(170, 52);
            btkhonguyenlieu.TabIndex = 3;
            btkhonguyenlieu.Text = "Kho nguyên liệu";
            btkhonguyenlieu.UseVisualStyleBackColor = true;
            // 
            // btqldanhmuc
            // 
            btqldanhmuc.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqldanhmuc.ForeColor = Color.Black;
            btqldanhmuc.Location = new Point(93, 40);
            btqldanhmuc.Margin = new Padding(4, 3, 4, 3);
            btqldanhmuc.Name = "btqldanhmuc";
            btqldanhmuc.Size = new Size(148, 52);
            btqldanhmuc.TabIndex = 4;
            btqldanhmuc.Text = "Quản lí menu";
            btqldanhmuc.UseVisualStyleBackColor = true;
            btqldanhmuc.Click += btqldanhmuc_Click;
            // 
            // btqlkhachhang
            // 
            btqlkhachhang.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqlkhachhang.Location = new Point(42, 233);
            btqlkhachhang.Margin = new Padding(4, 3, 4, 3);
            btqlkhachhang.Name = "btqlkhachhang";
            btqlkhachhang.Size = new Size(200, 52);
            btqlkhachhang.TabIndex = 5;
            btqlkhachhang.Text = "Quản lí khách hàng";
            btqlkhachhang.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btqlnhanvien);
            panel1.Controls.Add(btqlkhachhang);
            panel1.Controls.Add(btqldanhmuc);
            panel1.Controls.Add(btbaocao);
            panel1.Controls.Add(btkhuyenmai);
            panel1.Controls.Add(btkhonguyenlieu);
            panel1.Location = new Point(2, 12);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 605);
            panel1.TabIndex = 6;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(258, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(785, 590);
            panelMain.TabIndex = 7;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 614);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btqlnhanvien;
        private System.Windows.Forms.Button btbaocao;
        private System.Windows.Forms.Button btkhuyenmai;
        private System.Windows.Forms.Button btkhonguyenlieu;
        private System.Windows.Forms.Button btqldanhmuc;
        private System.Windows.Forms.Button btqlkhachhang;
        private System.Windows.Forms.Panel panel1;
        public Panel panelMain;
    }
}