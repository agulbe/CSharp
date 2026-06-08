namespace Ders02
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
            txtSayi1 = new TextBox();
            label2 = new Label();
            txtSayi2 = new TextBox();
            btnHesap = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Sayı &1:";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(12, 27);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(100, 23);
            txtSayi1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Sayı &2:";
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(139, 27);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(100, 23);
            txtSayi2.TabIndex = 3;
            // 
            // btnHesap
            // 
            btnHesap.Location = new Point(12, 56);
            btnHesap.Name = "btnHesap";
            btnHesap.Size = new Size(227, 61);
            btnHesap.TabIndex = 4;
            btnHesap.Text = "&Hesapla";
            btnHesap.UseVisualStyleBackColor = true;
            btnHesap.Click += btnHesap_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.Location = new Point(9, 134);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(225, 71);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç";
            lblSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 217);
            Controls.Add(lblSonuc);
            Controls.Add(btnHesap);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Toplama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSayi1;
        private Label label2;
        private TextBox txtSayi2;
        private Button btnHesap;
        private Label lblSonuc;
    }
}
