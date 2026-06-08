namespace Ders09b
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
            lblMetin = new Label();
            tmrAni = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblMetin
            // 
            lblMetin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMetin.Location = new Point(12, 9);
            lblMetin.Name = "lblMetin";
            lblMetin.Size = new Size(130, 101);
            lblMetin.TabIndex = 0;
            lblMetin.TextAlign = ContentAlignment.MiddleCenter;
            lblMetin.Click += lblMetin_Click;
            // 
            // tmrAni
            // 
            tmrAni.Interval = 250;
            tmrAni.Tick += tmrAni_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(166, 131);
            Controls.Add(lblMetin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblMetin;
        private System.Windows.Forms.Timer tmrAni;
    }
}
