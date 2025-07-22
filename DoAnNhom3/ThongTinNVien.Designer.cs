namespace DoAnNhom3
{
    partial class ThongTinNVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btSuaNV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmanhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbsdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbtennhanvien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbdiachi = new System.Windows.Forms.TextBox();
            this.btThemNV = new System.Windows.Forms.Button();
            this.btXoaNV = new System.Windows.Forms.Button();
            this.dgvdsnv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsnv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // btSuaNV
            // 
            this.btSuaNV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaNV.Location = new System.Drawing.Point(298, 371);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(131, 45);
            this.btSuaNV.TabIndex = 16;
            this.btSuaNV.Text = "Sửa";
            this.btSuaNV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbmanhanvien
            // 
            this.txbmanhanvien.Location = new System.Drawing.Point(481, 99);
            this.txbmanhanvien.Name = "txbmanhanvien";
            this.txbmanhanvien.Size = new System.Drawing.Size(193, 20);
            this.txbmanhanvien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số điện thoại";
            // 
            // txbsdt
            // 
            this.txbsdt.Location = new System.Drawing.Point(482, 237);
            this.txbsdt.Name = "txbsdt";
            this.txbsdt.Size = new System.Drawing.Size(193, 20);
            this.txbsdt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên nhân viên";
            // 
            // txbtennhanvien
            // 
            this.txbtennhanvien.Location = new System.Drawing.Point(481, 168);
            this.txbtennhanvien.Name = "txbtennhanvien";
            this.txbtennhanvien.Size = new System.Drawing.Size(193, 20);
            this.txbtennhanvien.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Địa chỉ";
            // 
            // txbdiachi
            // 
            this.txbdiachi.Location = new System.Drawing.Point(481, 308);
            this.txbdiachi.Name = "txbdiachi";
            this.txbdiachi.Size = new System.Drawing.Size(193, 20);
            this.txbdiachi.TabIndex = 13;
            this.txbdiachi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btThemNV
            // 
            this.btThemNV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemNV.Location = new System.Drawing.Point(91, 371);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(131, 45);
            this.btThemNV.TabIndex = 14;
            this.btThemNV.Text = "Thêm";
            this.btThemNV.UseVisualStyleBackColor = true;
            // 
            // btXoaNV
            // 
            this.btXoaNV.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaNV.Location = new System.Drawing.Point(492, 371);
            this.btXoaNV.Name = "btXoaNV";
            this.btXoaNV.Size = new System.Drawing.Size(131, 45);
            this.btXoaNV.TabIndex = 15;
            this.btXoaNV.Text = "Xóa";
            this.btXoaNV.UseVisualStyleBackColor = true;
            // 
            // dgvdsnv
            // 
            this.dgvdsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsnv.Location = new System.Drawing.Point(29, 81);
            this.dgvdsnv.Name = "dgvdsnv";
            this.dgvdsnv.Size = new System.Drawing.Size(423, 224);
            this.dgvdsnv.TabIndex = 2;
            // 
            // ThongTinNVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSuaNV);
            this.Controls.Add(this.btXoaNV);
            this.Controls.Add(this.btThemNV);
            this.Controls.Add(this.txbdiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbtennhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbsdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbmanhanvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvdsnv);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinNVien";
            this.Size = new System.Drawing.Size(692, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSuaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmanhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbsdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbtennhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbdiachi;
        private System.Windows.Forms.Button btThemNV;
        private System.Windows.Forms.Button btXoaNV;
        private System.Windows.Forms.DataGridView dgvdsnv;
    }
}
