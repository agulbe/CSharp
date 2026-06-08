namespace Ders05
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
            cboEgitim = new ComboBox();
            label2 = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "&Eğitim durumu:";
            // 
            // cboEgitim
            // 
            cboEgitim.FormattingEnabled = true;
            cboEgitim.IntegralHeight = false;
            cboEgitim.Items.AddRange(new object[] { "Doktora", "İlkokul", "Lisans", "Lise", "Ortaokul", "Ön lisans", "Yüksek lisans" });
            cboEgitim.Location = new Point(12, 27);
            cboEgitim.MaxDropDownItems = 5;
            cboEgitim.Name = "cboEgitim";
            cboEgitim.Size = new Size(151, 23);
            cboEgitim.Sorted = true;
            cboEgitim.TabIndex = 1;
            cboEgitim.SelectedIndexChanged += cboEgitim_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 174);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 2;
            label2.Text = "Seçilen eğitim düzeyi: ";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(169, 27);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "&Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 198);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(cboEgitim);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboEgitim;
        private Label label2;
        private Button btnEkle;
    }
}
