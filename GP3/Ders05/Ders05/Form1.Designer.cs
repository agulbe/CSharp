namespace Ders05
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
            toolStrip1 = new ToolStrip();
            btnAc = new ToolStripButton();
            btnYaz = new ToolStripButton();
            txtMetin = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAc, toolStripSeparator1, btnYaz });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(352, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAc
            // 
            btnAc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAc.Image = Properties.Resources.open16;
            btnAc.ImageTransparentColor = Color.Magenta;
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(24, 24);
            btnAc.Text = "toolStripButton1";
            btnAc.Click += btnAc_Click;
            // 
            // btnYaz
            // 
            btnYaz.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnYaz.Image = Properties.Resources.print16;
            btnYaz.ImageTransparentColor = Color.Magenta;
            btnYaz.Name = "btnYaz";
            btnYaz.Size = new Size(24, 24);
            btnYaz.Text = "toolStripButton2";
            btnYaz.Click += btnYaz_Click;
            // 
            // txtMetin
            // 
            txtMetin.Dock = DockStyle.Fill;
            txtMetin.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtMetin.Location = new Point(0, 27);
            txtMetin.Margin = new Padding(3, 2, 3, 2);
            txtMetin.Multiline = true;
            txtMetin.Name = "txtMetin";
            txtMetin.ScrollBars = ScrollBars.Both;
            txtMetin.Size = new Size(352, 272);
            txtMetin.TabIndex = 1;
            txtMetin.WordWrap = false;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 299);
            Controls.Add(txtMetin);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Metin dosyasından yazdırma";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAc;
        private ToolStripButton btnYaz;
        private TextBox txtMetin;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripSeparator toolStripSeparator1;
    }
}
