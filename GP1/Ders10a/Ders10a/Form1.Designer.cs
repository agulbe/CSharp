namespace Ders10a
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
            label3 = new Label();
            cboIslem = new ComboBox();
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
            label2.Location = new Point(393, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Sayı &2:";
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(331, 27);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(100, 23);
            txtSayi2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 6);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "İşlem";
            // 
            // cboIslem
            // 
            cboIslem.FormattingEnabled = true;
            cboIslem.Items.AddRange(new object[] { "Toplama (+)", "Çıkarma (-)", "Çarpma (*)", "Bölme (/)" });
            cboIslem.Location = new Point(163, 27);
            cboIslem.Name = "cboIslem";
            cboIslem.Size = new Size(121, 23);
            cboIslem.TabIndex = 5;
            // 
            // btnHesap
            // 
            btnHesap.Location = new Point(12, 56);
            btnHesap.Name = "btnHesap";
            btnHesap.Size = new Size(419, 44);
            btnHesap.TabIndex = 6;
            btnHesap.Text = "&Hesapla";
            btnHesap.UseVisualStyleBackColor = true;
            btnHesap.Click += btnHesap_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.BorderStyle = BorderStyle.Fixed3D;
            lblSonuc.Location = new Point(4, 114);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(430, 123);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "label4";
            lblSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AcceptButton = btnHesap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 245);
            Controls.Add(lblSonuc);
            Controls.Add(btnHesap);
            Controls.Add(cboIslem);
            Controls.Add(label3);
            Controls.Add(txtSayi2);
            Controls.Add(label2);
            Controls.Add(txtSayi1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dört İşlem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSayi1;
        private Label label2;
        private TextBox txtSayi2;
        private Label label3;
        private ComboBox cboIslem;
        private Button btnHesap;
        private Label lblSonuc;
    }
}
