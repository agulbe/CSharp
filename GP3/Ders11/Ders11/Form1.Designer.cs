namespace Ders11
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
            txtMetin = new TextBox();
            label1 = new Label();
            txtDosya = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtMetin
            // 
            txtMetin.AllowDrop = true;
            txtMetin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMetin.Location = new Point(0, 32);
            txtMetin.Multiline = true;
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(318, 185);
            txtMetin.TabIndex = 0;
            txtMetin.DragDrop += txtMetin_DragDrop;
            txtMetin.DragEnter += txtMetin_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Dosya:";
            // 
            // txtDosya
            // 
            txtDosya.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDosya.Location = new Point(48, -3);
            txtDosya.Name = "txtDosya";
            txtDosya.ReadOnly = true;
            txtDosya.Size = new Size(238, 23);
            txtDosya.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.search;
            button1.Location = new Point(292, 0);
            button1.Name = "button1";
            button1.Size = new Size(26, 26);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 216);
            Controls.Add(button1);
            Controls.Add(txtDosya);
            Controls.Add(label1);
            Controls.Add(txtMetin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMetin;
        private Label label1;
        private TextBox txtDosya;
        private Button button1;
    }
}
