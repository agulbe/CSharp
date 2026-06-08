namespace Ders17a
{
    public partial class Form1 : Form
    {
        List<Ogrenci> ogrenciler; // Öğrenci listesi
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ogrenciler = new()
            // {
            //    new Ogrenci()
            //    {
            //        Numara = "2544030001",
            //        Ad="Malik Eşter",
            //        Soyad="KAMIŞ",
            //        Vize = 70,
            //        Final =70
            //    },

            //    new Ogrenci()
            //    {
            //        Numara="2544030002",
            //        Ad="Firdevs",
            //        Soyad="ENSAR",
            //        Vize=67,
            //        Final=80
            //    },

            //    new Ogrenci()
            //    {
            //        Numara="2544030003",
            //        Ad="Boran",
            //        Soyad="GÜVEN",
            //        Vize=51,
            //        Final=65
            //    }
            //};
            //BindingSource kaynak = new();
            //kaynak.DataSource = ogrenciler;
            //dgvOgrenciler.DataSource = kaynak;
            //

            ogrenciler = new(); // Boş liste oluştur
            string[] satirlar = File.ReadAllLines("D:\\Code\\C#\\GP1\\prog.csv");
            for (int i = 1; i < satirlar.Length; i++)
            {
                string[] data = satirlar[i].Split(";");
                Ogrenci ogrenci = new()
                {
                    Numara = data[0],
                    Ad = data[1],
                    Soyad = data[2],
                    Vize = int.Parse(data[3]),
                    Final = Convert.ToInt32(data[4])
                };
                ogrenciler.Add(ogrenci);
            }

            dgvOgrenciler.DataSource = ogrenciler;
        }

        private void dgvOgrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView'daki aktif öğrenci bilgilerinden bir Onrenci nesnesi oluştur. 
            int i = e.RowIndex;
            if (i < 0) return;
            Ogrenci ogrenci = ogrenciler[i];
            nudNumara.Value = decimal.Parse(ogrenci.Numara);
            txtAd.Text = ogrenci.Ad;
            txtSoyad.Text = ogrenci.Soyad;
            nudVize.Value = ogrenci.Vize;
            nudFinal.Value = ogrenci.Final;

            int ortalama = (int)(ogrenci.Vize * 0.4 + ogrenci.Final * 0.6 + 0.5);
            lblOrtalama.Text = "Ortalama: " + ortalama;             
            
        }
    }
}
