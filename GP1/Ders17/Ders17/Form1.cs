using System.ComponentModel.DataAnnotations;

namespace Ders17
{
    public partial class Form1 : Form
    {
        List<Ogrenci>? ogrenciListesi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Örnekleme: Sınıftan nesne oluşturma
            ogrenciListesi = new();
            
            string[] satirlar = File.ReadAllLines("D:\\Code\\C#\\GP1\\prog.csv");
            for (int i = 1; i < satirlar.Length; i++)
            {
                string[] Ozellikler = satirlar[i].Split(';');
                Ogrenci? ogrenci = new()
                {
                    Numara = Ozellikler[0],
                    Ad = Ozellikler[1],
                    Soyad = Ozellikler[2],
                    Vize = int.Parse(Ozellikler[3]),
                    Final = int.Parse(Ozellikler[4])
                };

                txtAd.Text = ogrenci.Ad;
                txtSoyad.Text = ogrenci.Soyad;
                txtNumara.Text = ogrenci.Numara;
                nudVize.Value = ogrenci.Vize;
                nudFinal.Value = ogrenci.Final;

                ogrenciListesi.Add(ogrenci);
            }
            BindingSource kaynak = new();
            kaynak.DataSource= ogrenciListesi;
            dgvOgrenci.DataSource = kaynak;
            // dgvOgrenci.DataSource = ogrenciListesi;
        }
    }
}
