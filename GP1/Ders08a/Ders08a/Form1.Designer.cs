namespace Ders08a
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
            btnBalik = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnBalik
            // 
            btnBalik.AutoSize = true;
            btnBalik.FlatAppearance.BorderSize = 0;
            btnBalik.FlatStyle = FlatStyle.Flat;
            btnBalik.Image = Properties.Resources.fish3;
            btnBalik.Location = new Point(13, 123);
            btnBalik.Name = "btnBalik";
            btnBalik.Size = new Size(508, 308);
            btnBalik.TabIndex = 0;
            btnBalik.UseVisualStyleBackColor = true;
            btnBalik.Click += btnBalik_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(134, 215, 254);
            ClientSize = new Size(800, 450);
            Controls.Add(btnBalik);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBalik;
        private System.Windows.Forms.Timer timer1;
    }
}
