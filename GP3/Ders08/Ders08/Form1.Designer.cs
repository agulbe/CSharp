namespace Ders08
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            acToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sayfaToolStripMenuItem = new ToolStripMenuItem();
            yaziciToolStripMenuItem = new ToolStripMenuItem();
            baskiToolStripMenuItem = new ToolStripMenuItem();
            yazdirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            kapatToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Text = "Baskı önizleme";
            printPreviewDialog1.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(388, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acToolStripMenuItem, toolStripMenuItem1, sayfaToolStripMenuItem, yaziciToolStripMenuItem, baskiToolStripMenuItem, yazdirToolStripMenuItem, toolStripMenuItem2, kapatToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // acToolStripMenuItem
            // 
            acToolStripMenuItem.Name = "acToolStripMenuItem";
            acToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            acToolStripMenuItem.Size = new Size(232, 22);
            acToolStripMenuItem.Text = "Aç...";
            acToolStripMenuItem.Click += acToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(229, 6);
            // 
            // sayfaToolStripMenuItem
            // 
            sayfaToolStripMenuItem.Name = "sayfaToolStripMenuItem";
            sayfaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.P;
            sayfaToolStripMenuItem.Size = new Size(232, 22);
            sayfaToolStripMenuItem.Text = "Sayfa Ayarları...";
            sayfaToolStripMenuItem.Click += sayfaToolStripMenuItem_Click;
            // 
            // yaziciToolStripMenuItem
            // 
            yaziciToolStripMenuItem.Name = "yaziciToolStripMenuItem";
            yaziciToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.P;
            yaziciToolStripMenuItem.Size = new Size(232, 22);
            yaziciToolStripMenuItem.Text = "Yazıcı Ayarları...";
            yaziciToolStripMenuItem.Click += yaziciToolStripMenuItem_Click;
            // 
            // baskiToolStripMenuItem
            // 
            baskiToolStripMenuItem.Name = "baskiToolStripMenuItem";
            baskiToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.P;
            baskiToolStripMenuItem.Size = new Size(232, 22);
            baskiToolStripMenuItem.Text = "Baskı Önizleme...";
            baskiToolStripMenuItem.Click += baskiToolStripMenuItem_Click;
            // 
            // yazdirToolStripMenuItem
            // 
            yazdirToolStripMenuItem.Name = "yazdirToolStripMenuItem";
            yazdirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            yazdirToolStripMenuItem.Size = new Size(232, 22);
            yazdirToolStripMenuItem.Text = "Yazıdr...";
            yazdirToolStripMenuItem.Click += yazdirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(229, 6);
            // 
            // kapatToolStripMenuItem
            // 
            kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            kapatToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            kapatToolStripMenuItem.Size = new Size(232, 22);
            kapatToolStripMenuItem.Text = "Kapat";
            kapatToolStripMenuItem.Click += kapatToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 277);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem acToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sayfaToolStripMenuItem;
        private ToolStripMenuItem yaziciToolStripMenuItem;
        private ToolStripMenuItem baskiToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem yazdirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem kapatToolStripMenuItem;
    }
}
