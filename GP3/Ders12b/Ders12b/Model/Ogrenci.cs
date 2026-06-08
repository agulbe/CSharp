namespace Ders12b.Model
{
    public class Ogrenci
    {
        public string Numara { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Vize { get; set; }

        public string AdSoyad { get => Ad + " " + Soyad; }
    }
}
