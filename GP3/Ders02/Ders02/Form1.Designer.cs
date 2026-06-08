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
            cboYazicilar = new ComboBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label2 = new Label();
            lstKagit = new ListBox();
            label3 = new Label();
            lstKalite = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "&Yüklü yazıcılar";
            // 
            // cboYazicilar
            // 
            cboYazicilar.FormattingEnabled = true;
            cboYazicilar.Location = new Point(12, 27);
            cboYazicilar.Name = "cboYazicilar";
            cboYazicilar.Size = new Size(378, 23);
            cboYazicilar.TabIndex = 1;
            cboYazicilar.SelectedIndexChanged += cboYazicilar_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "&Kağıtlar";
            // 
            // lstKagit
            // 
            lstKagit.FormattingEnabled = true;
            lstKagit.Location = new Point(12, 86);
            lstKagit.Name = "lstKagit";
            lstKagit.Size = new Size(378, 94);
            lstKagit.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(706, 68);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "&Baskı Kaliteleri";
            // 
            // lstKalite
            // 
            lstKalite.FormattingEnabled = true;
            lstKalite.Location = new Point(396, 86);
            lstKalite.Name = "lstKalite";
            lstKalite.Size = new Size(392, 94);
            lstKalite.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKalite);
            Controls.Add(label3);
            Controls.Add(lstKagit);
            Controls.Add(label2);
            Controls.Add(cboYazicilar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Yzzıcı Özellikleri";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboYazicilar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label2;
        private ListBox lstKagit;
        private Label label3;
        private ListBox lstKalite;
    }
}
