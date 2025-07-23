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
            label1 = new Label();
            btthemvaogiohang = new Button();
            panel1 = new Panel();
            flpgiohang = new FlowLayoutPanel();
            btthanhtoanKH = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 3;
            label1.Text = "Giỏ hàng";
            // 
            // btthemvaogiohang
            // 
            btthemvaogiohang.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btthemvaogiohang.Location = new Point(119, 335);
            btthemvaogiohang.Name = "btthemvaogiohang";
            btthemvaogiohang.Size = new Size(103, 56);
            btthemvaogiohang.TabIndex = 34;
            btthemvaogiohang.Text = "Thêm vào giỏ hàng";
            btthemvaogiohang.UseVisualStyleBackColor = true;

            // 
            // panel1
            // 
            panel1.Controls.Add(flpgiohang);
            panel1.Controls.Add(btthanhtoanKH);
            panel1.Controls.Add(btthemvaogiohang);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(104, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 409);
            panel1.TabIndex = 37;
            // 
            // flpgiohang
            // 
            flpgiohang.AutoSize = true;
            flpgiohang.FlowDirection = FlowDirection.TopDown;
            flpgiohang.Location = new Point(56, 79);
            flpgiohang.Name = "flpgiohang";
            flpgiohang.Size = new Size(370, 240);
            flpgiohang.TabIndex = 43;
            // 
            // btthanhtoanKH
            // 
            btthanhtoanKH.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btthanhtoanKH.Location = new Point(277, 335);
            btthanhtoanKH.Name = "btthanhtoanKH";
            btthanhtoanKH.Size = new Size(103, 56);
            btthanhtoanKH.TabIndex = 39;
            btthanhtoanKH.Text = "Thanh toán";
            btthanhtoanKH.UseVisualStyleBackColor = true;
            // 
            // ucDonHang
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ucDonHang";
            Size = new Size(692, 488);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthemvaogiohang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btthanhtoanKH;
        private System.Windows.Forms.FlowLayoutPanel flpgiohang;
    }
}
