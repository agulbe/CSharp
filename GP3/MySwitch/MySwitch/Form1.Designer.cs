namespace MySwitch
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
            modernSwitch1 = new MySwitch.MyControls.ModernSwitch();
            statusButton1 = new MySwitch.MyControls.StatusButton();
            SuspendLayout();
            // 
            // modernSwitch1
            // 
            modernSwitch1.Checked = true;
            modernSwitch1.CheckState = CheckState.Checked;
            modernSwitch1.Location = new Point(43, 31);
            modernSwitch1.Margin = new Padding(2);
            modernSwitch1.Name = "modernSwitch1";
            modernSwitch1.Size = new Size(253, 27);
            modernSwitch1.TabIndex = 0;
            modernSwitch1.Text = "Statüs düğmesi etkinleştir";
            modernSwitch1.UseVisualStyleBackColor = true;
            modernSwitch1.CheckedChanged += modernSwitch1_CheckedChanged;
            // 
            // statusButton1
            // 
            statusButton1.BackColor = Color.FromArgb(60, 60, 60);
            statusButton1.FlatAppearance.BorderSize = 0;
            statusButton1.FlatStyle = FlatStyle.Flat;
            statusButton1.ForeColor = Color.White;
            statusButton1.Location = new Point(75, 118);
            statusButton1.Name = "statusButton1";
            statusButton1.Size = new Size(177, 87);
            statusButton1.TabIndex = 1;
            statusButton1.Text = "Next";
            statusButton1.UseVisualStyleBackColor = false;
            statusButton1.Click += statusButton1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 341);
            Controls.Add(statusButton1);
            Controls.Add(modernSwitch1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private MyControls.ModernSwitch modernSwitch1;
        private MyControls.StatusButton statusButton1;
    }
}
