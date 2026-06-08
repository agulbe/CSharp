namespace Ders13a
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
            nudKontrol = new NumericUpDown();
            btnEkle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)nudKontrol).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "&Kontrol Sayısı:";
            // 
            // nudKontrol
            // 
            nudKontrol.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            nudKontrol.Location = new Point(99, 7);
            nudKontrol.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            nudKontrol.Name = "nudKontrol";
            nudKontrol.Size = new Size(77, 23);
            nudKontrol.TabIndex = 1;
            nudKontrol.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(182, 7);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(60, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "&Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(248, 7);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(60, 23);
            btnSil.TabIndex = 3;
            btnSil.Text = "&Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(321, 331);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(nudKontrol);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudKontrol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudKontrol;
        private Button btnEkle;
        private Button btnSil;
    }
}
