namespace Ders07a
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
            chkForm = new CheckBox();
            chkOnay = new CheckBox();
            chkDosya = new CheckBox();
            chkDoldur = new CheckBox();
            chkTeslim = new CheckBox();
            btnKontrol = new Button();
            SuspendLayout();
            // 
            // chkForm
            // 
            chkForm.AutoSize = true;
            chkForm.Location = new Point(12, 12);
            chkForm.Name = "chkForm";
            chkForm.Size = new Size(194, 19);
            chkForm.TabIndex = 0;
            chkForm.Text = "Staj kabul formalarını  çıkarrtım.";
            chkForm.UseVisualStyleBackColor = true;
            chkForm.CheckedChanged += chkForm_CheckedChanged;
            // 
            // chkOnay
            // 
            chkOnay.AutoSize = true;
            chkOnay.Enabled = false;
            chkOnay.Location = new Point(12, 47);
            chkOnay.Name = "chkOnay";
            chkOnay.Size = new Size(195, 19);
            chkOnay.TabIndex = 1;
            chkOnay.Text = "Staj kabul formlarını onaylattım.";
            chkOnay.UseVisualStyleBackColor = true;
            // 
            // chkDosya
            // 
            chkDosya.AutoSize = true;
            chkDosya.Location = new Point(12, 81);
            chkDosya.Name = "chkDosya";
            chkDosya.Size = new Size(222, 19);
            chkDosya.TabIndex = 2;
            chkDosya.Text = "Staj dosyasının çıktısını alıp ciltlettim.";
            chkDosya.UseVisualStyleBackColor = true;
            chkDosya.CheckedChanged += chkDosya_CheckedChanged;
            // 
            // chkDoldur
            // 
            chkDoldur.AutoSize = true;
            chkDoldur.Enabled = false;
            chkDoldur.Location = new Point(12, 121);
            chkDoldur.Name = "chkDoldur";
            chkDoldur.Size = new Size(238, 19);
            chkDoldur.TabIndex = 3;
            chkDoldur.Text = "Staj dosyasını günü gününe doldurdum.";
            chkDoldur.UseVisualStyleBackColor = true;
            chkDoldur.CheckedChanged += chkDoldur_CheckedChanged;
            // 
            // chkTeslim
            // 
            chkTeslim.AutoSize = true;
            chkTeslim.Enabled = false;
            chkTeslim.Location = new Point(12, 162);
            chkTeslim.Name = "chkTeslim";
            chkTeslim.Size = new Size(198, 19);
            chkTeslim.TabIndex = 4;
            chkTeslim.Text = "Staj dosyasını okula teslim ettim.";
            chkTeslim.UseVisualStyleBackColor = true;
            // 
            // btnKontrol
            // 
            btnKontrol.Location = new Point(232, 165);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(93, 35);
            btnKontrol.TabIndex = 5;
            btnKontrol.Text = "&Kontrol";
            btnKontrol.UseVisualStyleBackColor = true;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 212);
            Controls.Add(btnKontrol);
            Controls.Add(chkTeslim);
            Controls.Add(chkDoldur);
            Controls.Add(chkDosya);
            Controls.Add(chkOnay);
            Controls.Add(chkForm);
            Name = "Form1";
            Text = "Staj işlemleri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkForm;
        private CheckBox chkOnay;
        private CheckBox chkDosya;
        private CheckBox chkDoldur;
        private CheckBox chkTeslim;
        private Button btnKontrol;
    }
}
