namespace Ders02b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Runtime: Çalışma zamanında, yani program çalışırken, kod ile özellikleri değiştirebiliriz.
            btnSelam.Text = "&Selamla";

            btnKapat.Text = "&Kapat";
            btnKapat.Left = btnSelam.Left;
            btnKapat.Width = btnSelam.Width;
            btnKapat.Height = btnSelam.Height;
        }

        private void btnSelam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba, " + txtAd.Text + "!",
                "SELAM!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close(); // Application.Exit();
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
            lblDurum.Text = $"Button boyutu: {btnSelam.Width} x {btnSelam.Height}"; 
        }
    }
}
