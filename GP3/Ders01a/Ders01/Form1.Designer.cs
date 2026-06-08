namespace Ders01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cboYazici = new ComboBox();
            btnYazdir = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Yazıcı &Listesi";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // cboYazici
            // 
            cboYazici.FormattingEnabled = true;
            cboYazici.Location = new Point(37, 49);
            cboYazici.Name = "cboYazici";
            cboYazici.Size = new Size(347, 33);
            cboYazici.TabIndex = 1;
            // 
            // btnYazdir
            // 
            btnYazdir.Location = new Point(272, 98);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(112, 34);
            btnYazdir.TabIndex = 2;
            btnYazdir.Text = "&Yazdır";
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // printDocument1
            // 
            printDocument1.DocumentName = "merhaba";
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 144);
            Controls.Add(btnYazdir);
            Controls.Add(cboYazici);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Yazdırma 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboYazici;
        private Button btnYazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
