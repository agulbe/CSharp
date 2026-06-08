namespace Ders17a
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
            splitContainer1 = new SplitContainer();
            lblOrtalama = new Label();
            nudFinal = new NumericUpDown();
            label5 = new Label();
            nudVize = new NumericUpDown();
            label4 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            nudNumara = new NumericUpDown();
            label1 = new Label();
            dgvOgrenciler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblOrtalama);
            splitContainer1.Panel1.Controls.Add(nudFinal);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(nudVize);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtSoyad);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtAd);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(nudNumara);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvOgrenciler);
            splitContainer1.Size = new Size(635, 314);
            splitContainer1.SplitterDistance = 211;
            splitContainer1.TabIndex = 1;
            // 
            // lblOrtalama
            // 
            lblOrtalama.BorderStyle = BorderStyle.FixedSingle;
            lblOrtalama.Location = new Point(9, 224);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(190, 77);
            lblOrtalama.TabIndex = 10;
            lblOrtalama.Text = "Ortalama:";
            lblOrtalama.TextAlign = ContentAlignment.MiddleCenter;
            lblOrtalama.UseCompatibleTextRendering = true;
            // 
            // nudFinal
            // 
            nudFinal.Location = new Point(112, 192);
            nudFinal.Name = "nudFinal";
            nudFinal.Size = new Size(56, 23);
            nudFinal.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 174);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "&Final";
            // 
            // nudVize
            // 
            nudVize.Location = new Point(12, 192);
            nudVize.Name = "nudVize";
            nudVize.Size = new Size(56, 23);
            nudVize.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "&Vize";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(12, 134);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(120, 23);
            txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "&Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(12, 80);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(120, 23);
            txtAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 2;
            label2.Text = "&Ad";
            // 
            // nudNumara
            // 
            nudNumara.Location = new Point(12, 27);
            nudNumara.Maximum = new decimal(new int[] { -1750936297, 0, 0, 0 });
            nudNumara.Minimum = new decimal(new int[] { 1044030001, 0, 0, 0 });
            nudNumara.Name = "nudNumara";
            nudNumara.Size = new Size(120, 23);
            nudNumara.TabIndex = 1;
            nudNumara.Value = new decimal(new int[] { 1044030001, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "&Numara";
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Dock = DockStyle.Fill;
            dgvOgrenciler.Location = new Point(0, 0);
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.Size = new Size(420, 314);
            dgvOgrenciler.TabIndex = 1;
            dgvOgrenciler.CellClick += dgvOgrenciler_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 314);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumara).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private NumericUpDown nudNumara;
        private Label label1;
        private DataGridView dgvOgrenciler;
        private Label lblOrtalama;
        private NumericUpDown nudFinal;
        private Label label5;
        private NumericUpDown nudVize;
        private Label label4;
        private TextBox txtSoyad;
    }
}
