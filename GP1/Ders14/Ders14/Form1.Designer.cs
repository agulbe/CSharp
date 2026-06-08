namespace Ders14
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
            txtMetin = new TextBox();
            lstMetin = new ListBox();
            lblMetin = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "&Metin";
            // 
            // txtMetin
            // 
            txtMetin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMetin.Location = new Point(12, 27);
            txtMetin.Multiline = true;
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(245, 201);
            txtMetin.TabIndex = 1;
            // 
            // lstMetin
            // 
            lstMetin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstMetin.FormattingEnabled = true;
            lstMetin.Location = new Point(263, 27);
            lstMetin.Name = "lstMetin";
            lstMetin.Size = new Size(85, 199);
            lstMetin.TabIndex = 2;
            // 
            // lblMetin
            // 
            lblMetin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMetin.Location = new Point(12, 234);
            lblMetin.Multiline = true;
            lblMetin.Name = "lblMetin";
            lblMetin.ReadOnly = true;
            lblMetin.ScrollBars = ScrollBars.Both;
            lblMetin.Size = new Size(336, 109);
            lblMetin.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 344);
            Controls.Add(lblMetin);
            Controls.Add(lstMetin);
            Controls.Add(txtMetin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMetin;
        private ListBox lstMetin;
        private TextBox lblMetin;
    }
}
