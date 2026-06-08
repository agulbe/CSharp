namespace Ders03
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
            printDocument = new System.Drawing.Printing.PrintDocument();
            label1 = new Label();
            cboYazici = new ComboBox();
            label2 = new Label();
            lstKagit = new ListBox();
            label3 = new Label();
            lstBaski = new ListBox();
            groupBox1 = new GroupBox();
            chkDubleks = new CheckBox();
            nudKopya = new NumericUpDown();
            label4 = new Label();
            chkHarman = new CheckBox();
            chkGecerli = new CheckBox();
            chkPlotter = new CheckBox();
            chkRenk = new CheckBox();
            chkVarsayilan = new CheckBox();
            btnYazdir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudKopya).BeginInit();
            SuspendLayout();
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "&Yazıcı";
            // 
            // cboYazici
            // 
            cboYazici.FormattingEnabled = true;
            cboYazici.Location = new Point(12, 32);
            cboYazici.Name = "cboYazici";
            cboYazici.Size = new Size(460, 28);
            cboYazici.TabIndex = 1;
            cboYazici.SelectedIndexChanged += cboYazici_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "&Kağıtlar";
            // 
            // lstKagit
            // 
            lstKagit.FormattingEnabled = true;
            lstKagit.Location = new Point(12, 97);
            lstKagit.Name = "lstKagit";
            lstKagit.Size = new Size(279, 144);
            lstKagit.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 74);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 4;
            label3.Text = "&Baskı Kalitesi";
            // 
            // lstBaski
            // 
            lstBaski.FormattingEnabled = true;
            lstBaski.Location = new Point(310, 97);
            lstBaski.Name = "lstBaski";
            lstBaski.Size = new Size(265, 144);
            lstBaski.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkDubleks);
            groupBox1.Controls.Add(nudKopya);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chkHarman);
            groupBox1.Controls.Add(chkGecerli);
            groupBox1.Controls.Add(chkPlotter);
            groupBox1.Controls.Add(chkRenk);
            groupBox1.Controls.Add(chkVarsayilan);
            groupBox1.Location = new Point(12, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 183);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Özellikler";
            // 
            // chkDubleks
            // 
            chkDubleks.AutoSize = true;
            chkDubleks.Location = new Point(298, 56);
            chkDubleks.Name = "chkDubleks";
            chkDubleks.Size = new Size(162, 24);
            chkDubleks.TabIndex = 7;
            chkDubleks.Text = "Çift taraflı yazdırma";
            chkDubleks.UseVisualStyleBackColor = true;
            // 
            // nudKopya
            // 
            nudKopya.Location = new Point(434, 26);
            nudKopya.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudKopya.Name = "nudKopya";
            nudKopya.Size = new Size(102, 27);
            nudKopya.TabIndex = 6;
            nudKopya.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 30);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 5;
            label4.Text = "Max. Kopya Sayısı:";
            // 
            // chkHarman
            // 
            chkHarman.AutoSize = true;
            chkHarman.Location = new Point(6, 146);
            chkHarman.Name = "chkHarman";
            chkHarman.Size = new Size(96, 24);
            chkHarman.TabIndex = 4;
            chkHarman.Text = "&Harmanla";
            chkHarman.UseVisualStyleBackColor = true;
            // 
            // chkGecerli
            // 
            chkGecerli.AutoSize = true;
            chkGecerli.Location = new Point(6, 116);
            chkGecerli.Name = "chkGecerli";
            chkGecerli.Size = new Size(126, 24);
            chkGecerli.TabIndex = 3;
            chkGecerli.Text = "Geçerli (Hazır)";
            chkGecerli.UseVisualStyleBackColor = true;
            // 
            // chkPlotter
            // 
            chkPlotter.AutoSize = true;
            chkPlotter.Location = new Point(6, 86);
            chkPlotter.Name = "chkPlotter";
            chkPlotter.Size = new Size(124, 24);
            chkPlotter.TabIndex = 2;
            chkPlotter.Text = "Çizici (Plotter)";
            chkPlotter.UseVisualStyleBackColor = true;
            // 
            // chkRenk
            // 
            chkRenk.AutoSize = true;
            chkRenk.Location = new Point(6, 56);
            chkRenk.Name = "chkRenk";
            chkRenk.Size = new Size(71, 24);
            chkRenk.TabIndex = 1;
            chkRenk.Text = "Renkli";
            chkRenk.UseVisualStyleBackColor = true;
            // 
            // chkVarsayilan
            // 
            chkVarsayilan.AutoSize = true;
            chkVarsayilan.Location = new Point(6, 26);
            chkVarsayilan.Name = "chkVarsayilan";
            chkVarsayilan.Size = new Size(138, 24);
            chkVarsayilan.TabIndex = 0;
            chkVarsayilan.Text = "&Varsayilan Yazici";
            chkVarsayilan.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            btnYazdir.Location = new Point(483, 31);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(94, 29);
            btnYazdir.TabIndex = 7;
            btnYazdir.Text = "Ya&zdır";
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(btnYazdir);
            Controls.Add(groupBox1);
            Controls.Add(lstBaski);
            Controls.Add(label3);
            Controls.Add(lstKagit);
            Controls.Add(label2);
            Controls.Add(cboYazici);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Yazıcı Özellikleri";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudKopya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private Label label1;
        private ComboBox cboYazici;
        private Label label2;
        private ListBox lstKagit;
        private Label label3;
        private ListBox lstBaski;
        private GroupBox groupBox1;
        private CheckBox chkVarsayilan;
        private CheckBox chkRenk;
        private CheckBox chkPlotter;
        private CheckBox chkGecerli;
        private CheckBox chkHarman;
        private NumericUpDown nudKopya;
        private Label label4;
        private CheckBox chkDubleks;
        private Button btnYazdir;
    }
}
