using System.Drawing.Printing;
namespace Ders02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Kagitlar()
        {
            // Kağıt boyutlarını al
            lstKagit.Items.Clear();
            string oge = "";
            foreach (PaperSize kagit in printDocument1.PrinterSettings.PaperSizes)
            {
                oge = kagit.ToString();
                // oge += " (" + kagit.Width + " x " + kagit.Height + ") : " + kagit.Kind;
                lstKagit.Items.Add(oge);
            }
        }

        private void Kaliteler()
        {
            // Baskı kalitelerini
            lstKalite.Items.Clear();
            foreach(PrinterResolution kalite in printDocument1.PrinterSettings.PrinterResolutions)
            {
                lstKalite.Items.Add(kalite.ToString() /* +" (X:"+ kalite.X+"  Y:"+kalite.Y+")" */ );                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int varsayilanYazici = 0, i = 0;

            // Sisteme yüklenmiş yazıcıların listesini Açılır Kutuya kaydet
            cboYazicilar.Items.Clear();
            foreach (var yazici in PrinterSettings.InstalledPrinters)
            {
                printDocument1.PrinterSettings.PrinterName = yazici.ToString();
                if (printDocument1.PrinterSettings.IsDefaultPrinter)
                    varsayilanYazici = i;
                i++;
                cboYazicilar.Items.Add(yazici);
            }


            // Varsayılan yazıcıyı seçme
            cboYazicilar.SelectedIndex = varsayilanYazici;
            printDocument1.PrinterSettings.PrinterName = cboYazicilar.Items[varsayilanYazici].ToString();

            Kagitlar();
            Kaliteler();
        }

        private void cboYazicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kagitlar();
            Kaliteler();
        }
    }
}
