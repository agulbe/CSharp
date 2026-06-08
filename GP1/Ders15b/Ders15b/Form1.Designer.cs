namespace Ders15b
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
            lstTaksit = new ListBox();
            label1 = new Label();
            nudTaksit = new NumericUpDown();
            label2 = new Label();
            nudGun = new NumericUpDown();
            btnHesapla = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTaksit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGun).BeginInit();
            SuspendLayout();
            // 
            // lstTaksit
            // 
            lstTaksit.FormattingEnabled = true;
            lstTaksit.Location = new Point(12, 84);
            lstTaksit.Name = "lstTaksit";
            lstTaksit.Size = new Size(392, 214);
            lstTaksit.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "&Taksit Sayısı: ";
            // 
            // nudTaksit
            // 
            nudTaksit.Location = new Point(101, 7);
            nudTaksit.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudTaksit.Name = "nudTaksit";
            nudTaksit.Size = new Size(71, 23);
            nudTaksit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "Ödeme &günü: ";
            // 
            // nudGun
            // 
            nudGun.Location = new Point(101, 44);
            nudGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nudGun.Name = "nudGun";
            nudGun.Size = new Size(71, 23);
            nudGun.TabIndex = 4;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(178, 7);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(217, 60);
            btnHesapla.TabIndex = 5;
            btnHesapla.Text = "&Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 310);
            Controls.Add(btnHesapla);
            Controls.Add(nudGun);
            Controls.Add(label2);
            Controls.Add(nudTaksit);
            Controls.Add(label1);
            Controls.Add(lstTaksit);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudTaksit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTaksit;
        private Label label1;
        private NumericUpDown nudTaksit;
        private Label label2;
        private NumericUpDown nudGun;
        private Button btnHesapla;
    }
}
