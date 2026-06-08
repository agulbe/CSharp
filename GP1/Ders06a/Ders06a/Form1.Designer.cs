namespace Ders06a
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
            groupBox1 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            lblDurum = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eğitim Durumu";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.CommandParameter = "Egitim";
            radioButton7.Location = new Point(264, 57);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(67, 19);
            radioButton7.TabIndex = 0;
            radioButton7.Text = "&Doktora";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += EgitimTiklandi;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.CommandParameter = "Egitim";
            radioButton6.Location = new Point(264, 32);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 0;
            radioButton6.Text = "&Yüksek lisans";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += EgitimTiklandi;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.CommandParameter = "Egitim";
            radioButton5.Location = new Point(164, 57);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(57, 19);
            radioButton5.TabIndex = 0;
            radioButton5.Text = "Li&sans";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += EgitimTiklandi;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.CommandParameter = "Egitim";
            radioButton4.Location = new Point(164, 32);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(73, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "&Ön lisans";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += EgitimTiklandi;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.CommandParameter = "Egitim";
            radioButton3.Location = new Point(15, 82);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(45, 19);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "&Lise";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += EgitimTiklandi;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.CommandParameter = "Egitim";
            radioButton2.Location = new Point(15, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 19);
            radioButton2.TabIndex = 0;
            radioButton2.Text = "&Ortaokul";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += EgitimTiklandi;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.CommandParameter = "Egitim";
            radioButton1.Location = new Point(15, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "&İlkokul";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += EgitimTiklandi;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton10);
            groupBox2.Controls.Add(radioButton9);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Location = new Point(12, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 103);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cinsiyet";
            // 
            // radioButton10
            // 
            radioButton10.AutoEllipsis = true;
            radioButton10.BackColor = Color.Yellow;
            radioButton10.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton10.Checked = true;
            radioButton10.CommandParameter = "Cinsiyet";
            radioButton10.Location = new Point(328, 32);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(150, 50);
            radioButton10.TabIndex = 2;
            radioButton10.TabStop = true;
            radioButton10.Text = "&Belirtmek istemiyorum";
            radioButton10.UseVisualStyleBackColor = false;
            radioButton10.CheckedChanged += CinsiyetTiklandi;
            // 
            // radioButton9
            // 
            radioButton9.BackColor = Color.Cyan;
            radioButton9.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton9.CommandParameter = "Cinsiyet";
            radioButton9.Location = new Point(172, 32);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(150, 50);
            radioButton9.TabIndex = 1;
            radioButton9.Text = "&Erkek";
            radioButton9.UseVisualStyleBackColor = false;
            radioButton9.CheckedChanged += CinsiyetTiklandi;
            // 
            // radioButton8
            // 
            radioButton8.BackColor = Color.Pink;
            radioButton8.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton8.CommandParameter = "Cinsiyet";
            radioButton8.Location = new Point(16, 32);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(150, 50);
            radioButton8.TabIndex = 0;
            radioButton8.Text = "&Kadın";
            radioButton8.UseVisualStyleBackColor = false;
            radioButton8.CheckedChanged += CinsiyetTiklandi;
            // 
            // lblDurum
            // 
            lblDurum.BorderStyle = BorderStyle.Fixed3D;
            lblDurum.Location = new Point(6, 261);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(502, 55);
            lblDurum.TabIndex = 2;
            lblDurum.Text = "label1";
            lblDurum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 325);
            Controls.Add(lblDurum);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private Label lblDurum;
    }
}
