namespace Ders08_1a.Models
{
    // Türemiş sınıf (Insan sınıfından türemiştir.)
    public class Ogrenci : Insan
    {
        public long Numara;
        public Ogrenci()
        {
            Yas = 17;
            Boy = 1.45;
            Kutle = 45;
            dogumYeri = "Iğdır";
        }

        public Ogrenci(long numara, string ad, int yas, double boy, float kutle)
            : base(ad, yas, boy, kutle)
        {
            Numara = numara;
        }

        public void Konus()
        {
            base.Konus();
            Console.WriteLine("Aynı zamanda bir öğrenciyim.");
        }
    }
}
