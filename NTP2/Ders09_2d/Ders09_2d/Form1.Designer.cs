namespace Ders09_2d
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
            lstDers = new ListBox();
            label1 = new Label();
            txtDers = new TextBox();
            SuspendLayout();
            // 
            // lstDers
            // 
            lstDers.FormattingEnabled = true;
            lstDers.Location = new Point(226, 12);
            lstDers.Name = "lstDers";
            lstDers.Size = new Size(120, 169);
            lstDers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Ders Adı:";
            // 
            // txtDers
            // 
            txtDers.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDers.Location = new Point(12, 27);
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(198, 23);
            txtDers.TabIndex = 2;
            txtDers.TextChanged += txtDers_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 187);
            Controls.Add(txtDers);
            Controls.Add(label1);
            Controls.Add(lstDers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDers;
        private Label label1;
        private TextBox txtDers;
    }
}
