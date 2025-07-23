
namespace DoAnNhom3
{
    partial class NhanVien
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
            button3 = new Button();
            bttaodonhang = new Button();
            btqldonhang = new Button();
            btqldanhmuc = new Button();
            button4 = new Button();
            dgvmenuNV = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbsoluongmenuNV = new TextBox();
            cbbTenmonmenuNV = new ComboBox();
            label1 = new Label();
            txbdongiamenuNV = new TextBox();
            txbtimkiemmon = new TextBox();
            cbbDanhMuc = new ComboBox();
            label5 = new Label();
            panelMain = new Panel();
            txbsizemenuNV = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmenuNV).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(bttaodonhang);
            panel1.Controls.Add(btqldonhang);
            panel1.Controls.Add(btqldanhmuc);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 614);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(37, 133);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(148, 52);
            button3.TabIndex = 8;
            button3.Text = "Thống kê";
            button3.UseVisualStyleBackColor = true;
            // 
            // bttaodonhang
            // 
            bttaodonhang.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttaodonhang.Location = new Point(37, 214);
            bttaodonhang.Margin = new Padding(4, 3, 4, 3);
            bttaodonhang.Name = "bttaodonhang";
            bttaodonhang.Size = new Size(159, 38);
            bttaodonhang.TabIndex = 25;
            bttaodonhang.Text = "Tạo đơn hàng";
            bttaodonhang.UseVisualStyleBackColor = true;
            // 
            // btqldonhang
            // 
            btqldonhang.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqldonhang.ForeColor = Color.Black;
            btqldonhang.Location = new Point(37, 61);
            btqldonhang.Margin = new Padding(4, 3, 4, 3);
            btqldonhang.Name = "btqldonhang";
            btqldonhang.Size = new Size(148, 66);
            btqldonhang.TabIndex = 7;
            btqldonhang.Text = "Quản lí đơn hàng";
            btqldonhang.UseVisualStyleBackColor = true;
            btqldonhang.Click += btqldonhang_Click;
            // 
            // btqldanhmuc
            // 
            btqldanhmuc.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqldanhmuc.ForeColor = Color.Black;
            btqldanhmuc.Location = new Point(37, 3);
            btqldanhmuc.Margin = new Padding(4, 3, 4, 3);
            btqldanhmuc.Name = "btqldanhmuc";
            btqldanhmuc.Size = new Size(148, 52);
            btqldanhmuc.TabIndex = 5;
            btqldanhmuc.Text = "Quản lí menu";
            btqldanhmuc.UseVisualStyleBackColor = true;
            btqldanhmuc.Click += btqldanhmuc_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(359, 3);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(148, 44);
            button4.TabIndex = 7;
            button4.Text = "MENU";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvmenuNV
            // 
            dgvmenuNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmenuNV.Location = new Point(129, 71);
            dgvmenuNV.Margin = new Padding(4, 3, 4, 3);
            dgvmenuNV.Name = "dgvmenuNV";
            dgvmenuNV.Size = new Size(602, 174);
            dgvmenuNV.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 274);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 14;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(129, 479);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 16;
            label3.Text = "Tìm kiếm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(129, 402);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 18;
            label4.Text = "Số lượng";
            // 
            // txbsoluongmenuNV
            // 
            txbsoluongmenuNV.Location = new Point(129, 429);
            txbsoluongmenuNV.Margin = new Padding(4, 3, 4, 3);
            txbsoluongmenuNV.Name = "txbsoluongmenuNV";
            txbsoluongmenuNV.Size = new Size(224, 23);
            txbsoluongmenuNV.TabIndex = 19;
            // 
            // cbbTenmonmenuNV
            // 
            cbbTenmonmenuNV.FormattingEnabled = true;
            cbbTenmonmenuNV.Items.AddRange(new object[] { "Gà rán nguyên con", "Khoai tây chiên", "Nước ép dưa hấu", "Nước ép dưa chuột" });
            cbbTenmonmenuNV.Location = new Point(129, 318);
            cbbTenmonmenuNV.Margin = new Padding(4, 3, 4, 3);
            cbbTenmonmenuNV.Name = "cbbTenmonmenuNV";
            cbbTenmonmenuNV.Size = new Size(215, 23);
            cbbTenmonmenuNV.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(470, 402);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 23;
            label1.Text = "Đơn giá";
            // 
            // txbdongiamenuNV
            // 
            txbdongiamenuNV.Location = new Point(475, 429);
            txbdongiamenuNV.Margin = new Padding(4, 3, 4, 3);
            txbdongiamenuNV.Name = "txbdongiamenuNV";
            txbdongiamenuNV.Size = new Size(224, 23);
            txbdongiamenuNV.TabIndex = 24;
            // 
            // txbtimkiemmon
            // 
            txbtimkiemmon.Location = new Point(128, 521);
            txbtimkiemmon.Name = "txbtimkiemmon";
            txbtimkiemmon.Size = new Size(225, 23);
            txbtimkiemmon.TabIndex = 26;
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(472, 521);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(227, 23);
            cbbDanhMuc.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(480, 490);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 28;
            label5.Text = "Danh mục";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(cbbDanhMuc);
            panelMain.Controls.Add(txbtimkiemmon);
            panelMain.Controls.Add(txbdongiamenuNV);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(cbbTenmonmenuNV);
            panelMain.Controls.Add(txbsoluongmenuNV);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(txbsizemenuNV);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(dgvmenuNV);
            panelMain.Controls.Add(button4);
            panelMain.Dock = DockStyle.Right;
            panelMain.Location = new Point(225, 0);
            panelMain.Margin = new Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(830, 614);
            panelMain.TabIndex = 1;
            // 
            // txbsizemenuNV
            // 
            txbsizemenuNV.Location = new Point(470, 318);
            txbsizemenuNV.Margin = new Padding(4, 3, 4, 3);
            txbsizemenuNV.Name = "txbsizemenuNV";
            txbsizemenuNV.Size = new Size(224, 23);
            txbsizemenuNV.TabIndex = 17;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 614);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NhanVien";
            Text = "NhanVien";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvmenuNV).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btqldonhang;
        private System.Windows.Forms.Button btqldanhmuc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bttaodonhang;
        private PaintEventHandler panel2_Paint;
        private Button button4;
        private DataGridView dgvmenuNV;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbsoluongmenuNV;
        private ComboBox cbbTenmonmenuNV;
        private Label label1;
        private TextBox txbdongiamenuNV;
        private TextBox txbtimkiemmon;
        private ComboBox cbbDanhMuc;
        private Label label5;
        private Panel panelMain;
        private TextBox txbsizemenuNV;
    }
}