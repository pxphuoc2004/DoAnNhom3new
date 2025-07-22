namespace DoAnNhom3
{
    partial class ucDonHang
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
            this.btthemvaogiohang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpgiohang = new System.Windows.Forms.FlowLayoutPanel();
            this.btthanhtoanKH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giỏ hàng";
            // 
            // btthemvaogiohang
            // 
            this.btthemvaogiohang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemvaogiohang.Location = new System.Drawing.Point(119, 335);
            this.btthemvaogiohang.Name = "btthemvaogiohang";
            this.btthemvaogiohang.Size = new System.Drawing.Size(103, 56);
            this.btthemvaogiohang.TabIndex = 34;
            this.btthemvaogiohang.Text = "Thêm vào giỏ hàng";
            this.btthemvaogiohang.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpgiohang);
            this.panel1.Controls.Add(this.btthanhtoanKH);
            this.panel1.Controls.Add(this.btthemvaogiohang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(104, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 409);
            this.panel1.TabIndex = 37;
            // 
            // flpgiohang
            // 
            this.flpgiohang.AutoSize = true;
            this.flpgiohang.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpgiohang.Location = new System.Drawing.Point(56, 79);
            this.flpgiohang.Name = "flpgiohang";
            this.flpgiohang.Size = new System.Drawing.Size(370, 240);
            this.flpgiohang.TabIndex = 43;
            // 
            // btthanhtoanKH
            // 
            this.btthanhtoanKH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthanhtoanKH.Location = new System.Drawing.Point(277, 335);
            this.btthanhtoanKH.Name = "btthanhtoanKH";
            this.btthanhtoanKH.Size = new System.Drawing.Size(103, 56);
            this.btthanhtoanKH.TabIndex = 39;
            this.btthanhtoanKH.Text = "Thanh toán";
            this.btthanhtoanKH.UseVisualStyleBackColor = true;
            this.btthanhtoanKH.Click += new System.EventHandler(this.btthanhtoanKH_Click);
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::DoAnNhom3.Properties.Resources.banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DonHang";
            this.Size = new System.Drawing.Size(692, 488);
           // this.Load += new System.EventHandler(this.DonHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthemvaogiohang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btthanhtoanKH;
        private System.Windows.Forms.FlowLayoutPanel flpgiohang;
    }
}
