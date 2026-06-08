namespace Ders12a
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
            nudGano = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudGano).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // nudGano
            // 
            nudGano.DecimalPlaces = 2;
            nudGano.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudGano.Location = new Point(12, 27);
            nudGano.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudGano.Name = "nudGano";
            nudGano.Size = new Size(120, 23);
            nudGano.TabIndex = 1;
            nudGano.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(138, 25);
            button1.Name = "button1";
            button1.Size = new Size(68, 23);
            button1.TabIndex = 2;
            button1.Text = "&Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 143);
            Controls.Add(button1);
            Controls.Add(nudGano);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudGano).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudGano;
        private Button button1;
    }
}
