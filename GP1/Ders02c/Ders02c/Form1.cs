namespace Ders02c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Runtime'da oluşturulan buton
            btnSelam.Text = "&Selamla";

            btnKapat.Left = btnSelam.Left;
            btnKapat.Width = btnSelam.Width;
            btnKapat.Height = btnSelam.Height;
            btnKapat.Text = "&Kapat";
        }

        private void btnSelam_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("Lütfen adınızı giriniz!");
                return;
            }
            MessageBox.Show($"Merhaba, {txtAd.Text}!");
        }

        private void btnSelam_MouseEnter(object sender, EventArgs e)
        {
            btnSelam.Width += 50;
            btnSelam.Left -= 25;
        }

        private void btnSelam_MouseLeave(object sender, EventArgs e)
        {
            btnSelam.Width -= 50;
            btnSelam.Left += 25;
        }

        private void btnSelam_SizeChanged(object sender, EventArgs e)
        {
            lblDurum.Text = $"Buton boyutu: {btnSelam.Width}x{btnSelam.Height}";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
