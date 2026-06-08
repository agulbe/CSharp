namespace Ders08a
{
    public partial class Form1 : Form
    {
        // Üye değişken tanımları
        // Rastgele sayı üreteci tanımla
        Random rastgele;

        // Balığın gezinebileceği alan
        int gezinmeGenisligi, gezinmeYuksekligi;

        // Oyunun başlama zamanı
        DateTime baslamaZamani;

        // Fare koordinatları
        int mouseX, mouseY;

        public Form1()
        {
            InitializeComponent();
        }

        private bool BalikYakalanir()
        {
            return mouseX < btnBalik.Left + btnBalik.Width &&
                mouseX >= btnBalik.Left &&
                mouseY < btnBalik.Top + btnBalik.Height &&
                mouseX >= btnBalik.Top;
                
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ekranın kullanılabilir alanı
            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int height = Screen.PrimaryScreen.WorkingArea.Height;

            // Ekran çözünürlüğü
            //string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            //string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

            // Formun genişliği
            Width = width;
            Height = height;
            Left = 0;
            Top = 0;
            // WindowState = FormWindowState.Maximized;

            // Rastgele sayı üretecini oluştur.
            rastgele = new();

            // balığın gezinebileceği alanı belirle
            gezinmeGenisligi = Width - btnBalik.Width;
            gezinmeYuksekligi = Height - btnBalik.Height;

            // Oyunun başlangıç zamanını not et
            baslamaZamani = DateTime.Now;

            // Zamanlayıcıyı başlat
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Balığı rastgele hareket ettir
            do
            {
                btnBalik.Left = rastgele.Next(0, gezinmeGenisligi);
                btnBalik.Top = rastgele.Next(0, gezinmeYuksekligi);
            } while (BalikYakalanir());
        }

        private void btnBalik_Click(object sender, EventArgs e)
        {
            // Balık yakalandı

            // Zamanlayıcıyı durdur.
            timer1.Stop();

            // Süreyi hesapla ve ekrana yaz
            DialogResult sonuc = MessageBox.Show(@$"
Beni {(DateTime.Now - baslamaZamani).Seconds} saniyede  yakalayabildin.

Yeniden denemek ister misin?
",
                "BRAVO!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            // Cevap evet ise zamanlayıcıyı tekrar başlat
            if (sonuc == DialogResult.Yes)
            {
                // Oyunun başlangıç zamanını not et
                baslamaZamani = DateTime.Now;

                // Zamanlayıcıyı başlat
                timer1.Start();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}
