namespace WinFormsApp1
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
            txtFiyat = new TextBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            chkLojman = new CheckBox();
            cboEgitim = new ComboBox();
            tmrAnimasyon = new System.Windows.Forms.Timer(components);
            lstArkadaslar = new ListBox();
            txtFahrenheit = new TextBox();
            label2 = new Label();
            lstServis = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(66, 80);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(100, 23);
            txtFiyat.TabIndex = 0;
            txtFiyat.TextChanged += txtFiyat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 62);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(91, 159);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(91, 196);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton1";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // chkLojman
            // 
            chkLojman.AutoSize = true;
            chkLojman.Location = new Point(66, 35);
            chkLojman.Name = "chkLojman";
            chkLojman.Size = new Size(66, 19);
            chkLojman.TabIndex = 3;
            chkLojman.Text = "Lojman";
            chkLojman.UseVisualStyleBackColor = true;
            chkLojman.CheckedChanged += chkLojman_CheckedChanged;
            // 
            // cboEgitim
            // 
            cboEgitim.FormattingEnabled = true;
            cboEgitim.Items.AddRange(new object[] { "İlkokul", "Orta okul", "Lise", "Ön lisans" });
            cboEgitim.Location = new Point(66, 109);
            cboEgitim.Name = "cboEgitim";
            cboEgitim.Size = new Size(121, 23);
            cboEgitim.TabIndex = 4;
            cboEgitim.SelectedIndexChanged += cboEgitim_SelectedIndexChanged;
            // 
            // tmrAnimasyon
            // 
            tmrAnimasyon.Interval = 200;
            // 
            // lstArkadaslar
            // 
            lstArkadaslar.FormattingEnabled = true;
            lstArkadaslar.Location = new Point(204, 35);
            lstArkadaslar.Name = "lstArkadaslar";
            lstArkadaslar.Size = new Size(120, 214);
            lstArkadaslar.TabIndex = 5;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(66, 263);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(100, 23);
            txtFahrenheit.TabIndex = 6;
            txtFahrenheit.TextChanged += txtFahrenheit_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 245);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Fahrenheit";
            // 
            // lstServis
            // 
            lstServis.FormattingEnabled = true;
            lstServis.Items.AddRange(new object[] { "ActiveX Yükleyicisi", "Agent activation", "Ağ Bağlantıları", "Akıllı Kart", "Algılayıcı Hizmeti", "BranchCache", "Bulut Yedekleme" });
            lstServis.Location = new Point(330, 35);
            lstServis.Name = "lstServis";
            lstServis.SelectionMode = SelectionMode.MultiExtended;
            lstServis.Size = new Size(120, 214);
            lstServis.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(330, 263);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 309);
            Controls.Add(button1);
            Controls.Add(lstServis);
            Controls.Add(label2);
            Controls.Add(txtFahrenheit);
            Controls.Add(lstArkadaslar);
            Controls.Add(cboEgitim);
            Controls.Add(chkLojman);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(txtFiyat);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFiyat;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox chkLojman;
        private ComboBox cboEgitim;
        private System.Windows.Forms.Timer tmrAnimasyon;
        private ListBox lstArkadaslar;
        private TextBox txtFahrenheit;
        private Label label2;
        private ListBox lstServis;
        private Button button1;
    }
}
