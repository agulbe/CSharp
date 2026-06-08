namespace Ders17
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNumara = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label4 = new Label();
            nudVize = new NumericUpDown();
            label5 = new Label();
            nudFinal = new NumericUpDown();
            lblOrtalama = new Label();
            dgvOgrenci = new DataGridView();
            ogrenciBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)nudVize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "&Numara: ";
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(74, 6);
            txtNumara.MaxLength = 10;
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(100, 23);
            txtNumara.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "&Ad: ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(74, 43);
            txtAd.MaxLength = 20;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(172, 23);
            txtAd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "&Soyad: ";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(74, 84);
            txtSoyad.MaxLength = 20;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(172, 23);
            txtSoyad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "&Vize: ";
            // 
            // nudVize
            // 
            nudVize.Location = new Point(74, 125);
            nudVize.Name = "nudVize";
            nudVize.Size = new Size(40, 23);
            nudVize.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 127);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "&Final: ";
            // 
            // nudFinal
            // 
            nudFinal.Location = new Point(206, 125);
            nudFinal.Name = "nudFinal";
            nudFinal.Size = new Size(40, 23);
            nudFinal.TabIndex = 9;
            // 
            // lblOrtalama
            // 
            lblOrtalama.BorderStyle = BorderStyle.Fixed3D;
            lblOrtalama.Location = new Point(12, 156);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(239, 27);
            lblOrtalama.TabIndex = 10;
            lblOrtalama.Text = "Ortalama: ";
            lblOrtalama.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOgrenci
            // 
            dgvOgrenci.AutoGenerateColumns = false;
            dgvOgrenci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenci.DataSource = ogrenciBindingSource;
            dgvOgrenci.Dock = DockStyle.Right;
            dgvOgrenci.Location = new Point(279, 0);
            dgvOgrenci.Name = "dgvOgrenci";
            dgvOgrenci.Size = new Size(353, 193);
            dgvOgrenci.TabIndex = 11;
            // 
            // ogrenciBindingSource
            // 
            ogrenciBindingSource.DataSource = typeof(Ogrenci);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 193);
            Controls.Add(dgvOgrenci);
            Controls.Add(lblOrtalama);
            Controls.Add(nudFinal);
            Controls.Add(label5);
            Controls.Add(nudVize);
            Controls.Add(label4);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(txtNumara);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Öğrenci";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudVize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenci).EndInit();
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumara;
        private Label label2;
        private TextBox txtAd;
        private Label label3;
        private TextBox txtSoyad;
        private Label label4;
        private NumericUpDown nudVize;
        private Label label5;
        private NumericUpDown nudFinal;
        private Label lblOrtalama;
        private DataGridView dgvOgrenci;
        private BindingSource ogrenciBindingSource;
    }
}
