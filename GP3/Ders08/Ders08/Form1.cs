using System.Drawing.Printing;

namespace Ders08
{
    public partial class Form1 : Form
    {
        Image resim = null;
        string dosya = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            openFileDialog1.Filter = "All Image files | *.bmp; *.gif; *.jpg; *.ico; " +
            "*.emf, .wmf | Bitmap Files (*.bmp; *.gif; *.jpg; " +
            "*.ico) | *.bmp; *.gif; *.jpg; *.ico|" +
            "Meta Files (*.emf; *.wmf) | *.emf; *.wmf";
            string filter = openFileDialog1.Filter;
            openFileDialog1.InitialDirectory =
                  Environment.CurrentDirectory;
            openFileDialog1.Title = "Resim Dosyası AÇ";
            openFileDialog1.ShowHelp = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya = openFileDialog1.FileName;
                resim = Image.FromFile(dosya);
            }
            if (resim != null)
            {
                g.DrawImage(resim, AutoScrollPosition.X, AutoScrollPosition.Y,
                   resim.Width, resim.Height);
            }
            g.Dispose();

        }
        private void sayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sayfa ayarları için nesne oluşturç
            System.Drawing.Printing.PageSettings sayfaAyar = new System.Drawing.Printing.PageSettings();

            // Sayfa kenar boşlukları
            sayfaAyar.Margins.Left = 250;
            sayfaAyar.Margins.Top = 250;


            // Sayfa ayarlarını alacağım PrintDocument nesnesi
            pageSetupDialog1.Document = printDocument1;

            // Bazı sayfa ayaları

            pageSetupDialog1.AllowMargins = true;
            pageSetupDialog1.AllowOrientation = true;
            pageSetupDialog1.AllowPaper = true;
            pageSetupDialog1.AllowPrinter = true;

            // Yaptığım sayfa ayarlarını sıfırla
            // pageSetupDialog1.Reset();

            // Sayfa ayarlarını ileti kutusuna aktar
            pageSetupDialog1.PageSettings = sayfaAyar;

            // İleti kutusunda belirlenenen ayarları PrintDocument nesnesine aktar.
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                // Sayfa ayarlarını aktar
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
                // Yazıcı ayarlarını aktar.
                printDocument1.PrinterSettings = pageSetupDialog1.PrinterSettings;
            }

        }


        private void yaziciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.PrintToFile = false;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();

        }

        private void baskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void GrafikNesneleriCiz(Graphics gobj)
        {
            gobj.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gobj.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            if (resim != null)
            {
                gobj.DrawImage(resim, AutoScrollPosition.X,
                    AutoScrollPosition.Y, resim.Width, resim.Height);
            }
            gobj.DrawString("İleti kutusu metin yazdırıyor", new Font("Verdana", 25),
            new SolidBrush(Color.Violet), 40, 40);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            GrafikNesneleriCiz(e.Graphics);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GrafikNesneleriCiz(this.CreateGraphics());
        }

        private void yazdirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
