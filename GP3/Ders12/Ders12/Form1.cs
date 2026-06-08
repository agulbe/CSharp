namespace Ders12
{
    public partial class Form1 : Form
    {
        int hazirKontrolSayisi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            hazirKontrolSayisi = Controls.Count;
            int ogrenciSayisi = (int)nudSayi.Value;

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                // Numara gösterecek Label
                Label lblNumara = new() {
                    AutoSize = false,
                    Size = new Size(100, 30),
                    Location = new Point(16, 40+i*40),
                    BorderStyle = BorderStyle.Fixed3D,
                    TextAlign = ContentAlignment.MiddleRight,
                    Text = "25440300"+i
                };
                Controls.Add(lblNumara);

                // Ad ve Soyad TextBox
                TextBox txtAd = new()
                {
                    Width = 120,
                    Location = new Point(120, 40+40*i),
                    ReadOnly = true
                };
                Controls.Add(txtAd);

                // Not girişi için NumericUpDown
                NumericUpDown nudVize = new()
                {
                    Minimum = -1,
                    Maximum = 100,
                    Increment = 1,
                    DecimalPlaces = 0,
                    Width = 50,
                    Location = new Point(250, 40 + 40 * i)
                };
                Controls.Add(nudVize);
            }

        }
    }
}
