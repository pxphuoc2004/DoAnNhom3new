namespace DoAnNhom3
{
    partial class QuenMatKhau
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
            this.btxacnhan = new System.Windows.Forms.Button();
            this.txbnhapmkmoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbmatkhaumoi = new System.Windows.Forms.TextBox();
            this.txbtendangnhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btxacnhan);
            this.panel1.Controls.Add(this.txbnhapmkmoi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbmatkhaumoi);
            this.panel1.Controls.Add(this.txbtendangnhap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(271, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 352);
            this.panel1.TabIndex = 0;
            // 
            // btxacnhan
            // 
            this.btxacnhan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxacnhan.Location = new System.Drawing.Point(132, 284);
            this.btxacnhan.Name = "btxacnhan";
            this.btxacnhan.Size = new System.Drawing.Size(118, 33);
            this.btxacnhan.TabIndex = 16;
            this.btxacnhan.Text = "Xác nhận";
            this.btxacnhan.UseVisualStyleBackColor = true;
            // 
            // txbnhapmkmoi
            // 
            this.txbnhapmkmoi.Location = new System.Drawing.Point(64, 243);
            this.txbnhapmkmoi.Name = "txbnhapmkmoi";
            this.txbnhapmkmoi.Size = new System.Drawing.Size(229, 20);
            this.txbnhapmkmoi.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txbmatkhaumoi
            // 
            this.txbmatkhaumoi.Location = new System.Drawing.Point(64, 169);
            this.txbmatkhaumoi.Name = "txbmatkhaumoi";
            this.txbmatkhaumoi.Size = new System.Drawing.Size(229, 20);
            this.txbmatkhaumoi.TabIndex = 13;
            // 
            // txbtendangnhap
            // 
            this.txbtendangnhap.Location = new System.Drawing.Point(64, 92);
            this.txbtendangnhap.Name = "txbtendangnhap";
            this.txbtendangnhap.Size = new System.Drawing.Size(229, 20);
            this.txbtendangnhap.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đăng nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quên mật khẩu";
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnNhom3.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(904, 532);
            this.Controls.Add(this.panel1);
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbmatkhaumoi;
        private System.Windows.Forms.TextBox txbtendangnhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbnhapmkmoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btxacnhan;
    }
}