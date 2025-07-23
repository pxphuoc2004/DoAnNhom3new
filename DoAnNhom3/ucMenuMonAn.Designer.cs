namespace DoAnNhom3
{
    partial class ucMenuMonAn
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
            flpgiohang = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // flpgiohang
            // 
            flpgiohang.Location = new Point(0, 75);
            flpgiohang.Name = "flpgiohang";
            flpgiohang.Size = new Size(807, 488);
            flpgiohang.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 25);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 2;
            label1.Text = "MENU";
            // 
            // ucMenuMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(flpgiohang);
            Name = "ucMenuMonAn";
            Size = new Size(807, 563);
            //Load += ucMenuMonAn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpgiohang;
        private Label label1;
    }
}
