namespace Ders13a
{
    public partial class Form1 : Form
    {

        int bosKontrolSayisi; // Başlangıçtaki kontrol sayısı
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bosKontrolSayisi = Controls.Count;
        }

        private void ResimGoster(object? s, EventArgs? e)
        {
            ResimKutusu resim = s as ResimKutusu;
            resim.Image = Image.FromFile(
                $"D:\\Resim\\Ogrenci\\{resim.Id}.png");
        }


        private void Sil(int n)
        {
            for (int i = 0, j = Controls.Count - 1; i < n; i++, j--)
                Controls.RemoveAt(j);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int eklenecek = (int)nudKontrol.Value;
            int sutunSayisi = (int)Math.Sqrt(eklenecek);
            int satirSayisi = eklenecek / sutunSayisi;
            int left = 0, top = 0,
                width = 64, height = 64, bosluk = 20, 
                solMarj = 15, ustMarj = 100;

            Sil(Controls.Count - bosKontrolSayisi);

            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    left = solMarj + i * (height + bosluk);
                    top = ustMarj + j * (width + bosluk);

                    ResimKutusu resim = new()
                    {
                        Left = left,
                        Top = top,
                        Width = width,
                        Height = height,
                        Image = Image.FromFile("d:\\Resim\\Simge\\user.png"),
                        BorderStyle = BorderStyle.Fixed3D,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        SatirNo = i,
                        SutunNo = j,
                        Id = i * sutunSayisi + j
                    };
                    resim.Click += ResimGoster; 
                    Controls.Add(resim);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil((int)nudKontrol.Value);
        }
    }
}
