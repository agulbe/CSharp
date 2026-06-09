namespace Ders09_2e
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
            txtDosyaYolu = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            chkSaltOkunur = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "&Dosya:";
            // 
            // txtDosyaYolu
            // 
            txtDosyaYolu.Location = new Point(12, 27);
            txtDosyaYolu.Name = "txtDosyaYolu";
            txtDosyaYolu.ReadOnly = true;
            txtDosyaYolu.Size = new Size(221, 23);
            txtDosyaYolu.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.search;
            button1.Location = new Point(249, 21);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkSaltOkunur);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 158);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // chkSaltOkunur
            // 
            chkSaltOkunur.AutoSize = true;
            chkSaltOkunur.Location = new Point(16, 33);
            chkSaltOkunur.Name = "chkSaltOkunur";
            chkSaltOkunur.Size = new Size(85, 19);
            chkSaltOkunur.TabIndex = 0;
            chkSaltOkunur.Text = "SaltOkunur";
            chkSaltOkunur.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 227);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(txtDosyaYolu);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDosyaYolu;
        private Button button1;
        private GroupBox groupBox1;
        private CheckBox chkSaltOkunur;
    }
}
