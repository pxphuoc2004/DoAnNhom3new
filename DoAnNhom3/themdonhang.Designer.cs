namespace DoAnNhom3
{
    partial class themdonhang
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
            pictureBox1 = new PictureBox();
            txbtenmonan = new TextBox();
            txbdongia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 97);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txbtenmonan
            // 
            txbtenmonan.Location = new Point(158, 23);
            txbtenmonan.Margin = new Padding(4, 3, 4, 3);
            txbtenmonan.Name = "txbtenmonan";
            txbtenmonan.Size = new Size(200, 23);
            txbtenmonan.TabIndex = 1;
            // 
            // txbdongia
            // 
            txbdongia.Location = new Point(158, 53);
            txbdongia.Margin = new Padding(4, 3, 4, 3);
            txbdongia.Name = "txbdongia";
            txbdongia.Size = new Size(200, 23);
            txbdongia.TabIndex = 2;
            // 
            // themdonhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txbdongia);
            Controls.Add(txbtenmonan);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "themdonhang";
            Size = new Size(376, 99);
            Load += themdonhang_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbtenmonan;
        private System.Windows.Forms.TextBox txbdongia;
    }
}
