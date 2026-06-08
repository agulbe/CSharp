using System.Drawing.Printing;
namespace Ders03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YaziciListesi()
        {
            int varsayilanYaziciIndisi = 0, i = 0;
            // Sistemde kurulu yazýcý listesini cboYazici'ya aktar.
            cboYazici.Items.Clear();
            foreach (var yazici in PrinterSettings.InstalledPrinters)
            {
                cboYazici.Items.Add(yazici);
                printDocument.PrinterSettings.PrinterName = yazici.ToString() ?? "";
                if (printDocument.PrinterSettings.IsDefaultPrinter)
                    varsayilanYaziciIndisi = i;
                i++;
            }
            cboYazici.SelectedIndex = varsayilanYaziciIndisi;
        }

        private void Kagitlar()
        {
            lstKagit.Items.Clear();
            foreach (PaperSize kagit in printDocument.PrinterSettings.PaperSizes)
                lstKagit.Items.Add(kagit);
        }

        private void BaskiKaliteleri()
        {
            lstBaski.Items.Clear();
            foreach (PrinterResolution baski in printDocument.PrinterSettings.PrinterResolutions)
                lstBaski.Items.Add(baski);
        }

        private void Ayarlar()
        {
            Kagitlar();
            BaskiKaliteleri();
            chkVarsayilan.Checked = printDocument.PrinterSettings.IsDefaultPrinter;
            chkRenk.Checked = printDocument.PrinterSettings.SupportsColor;
            chkPlotter.Checked = printDocument.PrinterSettings.IsPlotter;
            chkGecerli.Checked = printDocument.PrinterSettings.IsValid;
            chkHarman.Checked = printDocument.PrinterSettings.Collate;
            nudKopya.Maximum = printDocument.PrinterSettings.MaximumCopies;
            // printDocument.PrinterSettings.CanDuplex
            chkDubleks.Enabled = printDocument.PrinterSettings.CanDuplex;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            YaziciListesi();
            Ayarlar();
        }

        private void cboYazici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYazici.SelectedIndex != -1)
                printDocument.PrinterSettings.PrinterName =
                cboYazici.SelectedItem?.ToString() ?? "";
            Ayarlar();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics? grafik = e.Graphics;

            Font font1 = new("Arial", 20, FontStyle.Bold);
            Font font2 = new("Times New Roman", 12, FontStyle.Regular);

            SolidBrush renk1 = new SolidBrush(Color.Red);
            SolidBrush renk2 = new SolidBrush(Color.DarkBlue);

            string[] siir = {"Portakalý soydum.",
                "Baþucuma koydum.",
                "Ben bir yalan uydurdum.",
                "Duma duma dum.",
                "Kýrmýzý mum."};

            grafik.DrawString("PORTAKAL", font1, renk1, 100, 50);
            for (int i= 0; i < siir.Length;i++)
            {
                grafik.DrawString(siir[i], font2, renk2, 
                    50, 100+i*font2.GetHeight());
            }
        }
    }
}
