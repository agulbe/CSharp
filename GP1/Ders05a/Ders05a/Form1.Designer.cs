namespace Ders05a
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
            label2 = new Label();
            lstAdlar = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "&Eğitim durumu:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(4, 25);
            label2.Name = "label2";
            label2.Size = new Size(258, 122);
            label2.TabIndex = 2;
            // 
            // lstAdlar
            // 
            lstAdlar.BackColor = Color.Gainsboro;
            lstAdlar.BorderStyle = BorderStyle.None;
            lstAdlar.FormattingEnabled = true;
            lstAdlar.Items.AddRange(new object[] { "Ali", "Ata", "Berk", "Can", "Cem", "Ece", "Abdülmuttalip", "Ela", "Eda ", "Efe", "Ege", "Gül", "Gün", "Nil", "Nur", "Naz", "Hür", "Ada" });
            lstAdlar.Location = new Point(4, 25);
            lstAdlar.Name = "lstAdlar";
            lstAdlar.SelectionMode = SelectionMode.MultiExtended;
            lstAdlar.Size = new Size(256, 120);
            lstAdlar.TabIndex = 3;
            lstAdlar.SelectedIndexChanged += lstAdlar_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 229);
            Controls.Add(label3);
            Controls.Add(lstAdlar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstAdlar;
        private Label label3;
    }
}
