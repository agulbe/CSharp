using System.Drawing.Printing;

namespace Ders05
{
    public partial class Form1 : Form
    {
        // Üye deðiþkenler
        int satirNo; // Metin dosyasýnýn hangi satýrý yazdýrýlýyor?
        float satirYuksekligi; // Kaðýt üzerinde bir satýrýn yüksekliði
        Margins marj; // Kaðýdýn dört kenarýndaki boþluklar
        float kagitYuksekligi;  // Kaðýdýn yazdýrýlabilen alanýnýn yüksekliði
        int satirSayisi;       // Bir sayfaya yazdýralabilecek maksimum satýr sayýsý
        Font font; // Hangi font ile yazdýracaðýz?

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new();
            dosya.Filter = "Metin Dosyasý (*.txt)`|*.txt|" +
                "C# Kod dosyasý|*.cs|" +
                "HTML dosyasý|*.htm,*.html|" +
                "Stil dosyasý|*.css";
            dosya.Title = "Metin Dosyasý Aç";
            string[] satirlar = [];
            // Dosyayý seç ve satýrlarýný diziye oku
            if (dosya.ShowDialog() == DialogResult.OK)
                satirlar = File.ReadAllLines(dosya.FileName);
            dosya.Dispose();
            // Satýrlarýn baþýna satýr numarasý ekle
            for (int i = 0, j = 1; i < satirlar.Length; i++, j++)
            {
                // 4 basamaða tamamalamak 
                if (j < 10)
                    satirlar[i] = "   " + j + " " + satirlar[i];
                else if (j < 100)
                    satirlar[i] = "  " + j + " " + satirlar[i];
                else if (j < 1000)
                    satirlar[i] = " " + j + " " + satirlar[i];
                else
                    satirlar[i] = "" + j + " " + satirlar[i];
            }
            // TextBox'a ekle
            txtMetin.Lines = satirlar;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < satirSayisi && satirNo < txtMetin.Lines.Length; i++)
                g.DrawString(txtMetin.Lines[satirNo++],
                    font,
                    Brushes.Black,
                    marj.Left, marj.Top + i * satirYuksekligi);

            e.HasMorePages = satirNo < txtMetin.Lines.Length;  // Dosyanýn yazýomý bitti mi?
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // YaAzmaya baþlamadan önce
            satirNo = 0;
            font = new Font("Consolas", 10);
            satirYuksekligi = font.GetHeight() * 1.5F;
            marj = printDocument1.DefaultPageSettings.Margins;
            kagitYuksekligi = printDocument1.DefaultPageSettings.PaperSize.Height
                - marj.Top
                - marj.Bottom;

            satirSayisi = (int)(kagitYuksekligi / satirYuksekligi);
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
