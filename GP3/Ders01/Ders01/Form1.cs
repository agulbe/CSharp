using System.Drawing.Printing;
namespace Ders01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboYazici.Items.Clear();
            foreach (var yazici in PrinterSettings.InstalledPrinters)
                cboYazici.Items.Add(yazici);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            // SelectedItem null olasılığına karşı güvenli kontrol yapıyoruz.
            if (cboYazici.SelectedItem is string printerName)
            {
                // printerName artık kesinlikle null değil (string pattern matching ile).
                printDocument1.PrinterSettings.PrinterName = printerName;
                printDocument1.Print();
            }
            else
            {
                // Seçim yoksa kullanıcıyı bilgilendiriyoruz.
                MessageBox.Show("Lütfen bir yazıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Times New Roman", 20F);
            SolidBrush brush = new SolidBrush(Color.Turquoise);
            Rectangle rect = new Rectangle(100, 100, 400, 200);
            g.DrawString("Merhaba, Yazıcı!", font, brush, rect);
        }
    }
}
