namespace Ders10
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
            switch1 = new Ders10.Kontrol.Switch();
            SuspendLayout();
            // 
            // switch1
            // 
            switch1.Image = Properties.Resources.home;
            switch1.Location = new Point(154, 24);
            switch1.Name = "switch1";
            switch1.Size = new Size(146, 99);
            switch1.TabIndex = 0;
            switch1.Text = "switch1";
            switch1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 259);
            Controls.Add(switch1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Kontrol.Switch switch1;
    }
}
