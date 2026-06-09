namespace Ders09_1b
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
            chkTopla = new CheckBox();
            chkCarp = new CheckBox();
            chkCikar = new CheckBox();
            chkBol = new CheckBox();
            btnHesap = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "&1. Sayı:";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(12, 32);
            txtSayi1.MaxLength = 12;
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(125, 27);
            txtSayi1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "&2. Sayı:";
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(181, 32);
            txtSayi2.MaxLength = 12;
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(125, 27);
            txtSayi2.TabIndex = 3;
            // 
            // chkTopla
            // 
            chkTopla.AutoSize = true;
            chkTopla.Checked = true;
            chkTopla.CheckState = CheckState.Checked;
            chkTopla.Location = new Point(21, 81);
            chkTopla.Name = "chkTopla";
            chkTopla.Size = new Size(68, 24);
            chkTopla.TabIndex = 4;
            chkTopla.Text = "&Topla";
            chkTopla.UseVisualStyleBackColor = true;
            chkTopla.CheckedChanged += chkTopla_CheckedChanged;
            // 
            // chkCarp
            // 
            chkCarp.AutoSize = true;
            chkCarp.Location = new Point(21, 120);
            chkCarp.Name = "chkCarp";
            chkCarp.Size = new Size(62, 24);
            chkCarp.TabIndex = 4;
            chkCarp.Text = "Çar&p";
            chkCarp.UseVisualStyleBackColor = true;
            chkCarp.CheckedChanged += chkCarp_CheckedChanged;
            // 
            // chkCikar
            // 
            chkCikar.AutoSize = true;
            chkCikar.Location = new Point(21, 150);
            chkCikar.Name = "chkCikar";
            chkCikar.Size = new Size(64, 24);
            chkCikar.TabIndex = 4;
            chkCikar.Text = "Çı&kar";
            chkCikar.UseVisualStyleBackColor = true;
            chkCikar.CheckedChanged += chkCikar_CheckedChanged;
            // 
            // chkBol
            // 
            chkBol.AutoSize = true;
            chkBol.Location = new Point(21, 180);
            chkBol.Name = "chkBol";
            chkBol.Size = new Size(53, 24);
            chkBol.TabIndex = 4;
            chkBol.Text = "&Böl";
            chkBol.UseVisualStyleBackColor = true;
            chkBol.CheckedChanged += chkBol_CheckedChanged;
            // 
            // btnHesap
            // 
            btnHesap.Location = new Point(21, 235);
            btnHesap.Name = "btnHesap";
            btnHesap.Size = new Size(94, 29);
            btnHesap.TabIndex = 5;
            btnHesap.Text = "&Hesapla";
            btnHesap.UseVisualStyleBackColor = true;
            btnHesap.Click += btnHesap_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.BorderStyle = BorderStyle.Fixed3D;
            lblSonuc.Location = new Point(121, 81);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(185, 179);
            lblSonuc.TabIndex = 6;
            lblSonuc.Text = "Sonuç";
            lblSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 276);
            Controls.Add(lblSonuc);
            Controls.Add(btnHesap);
            Controls.Add(chkBol);
            Controls.Add(chkCikar);
            Controls.Add(chkCarp);
            Controls.Add(chkTopla);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSayi1;
        private Label label2;
        private TextBox txtSayi2;
        private CheckBox chkTopla;
        private CheckBox chkCarp;
        private CheckBox chkCikar;
        private CheckBox chkBol;
        private Button btnHesap;
        private Label lblSonuc;
    }
}
