namespace Ders_08_1b.Models
{
    internal class Ogrenci : Insan
    {
        public long Numara { get; set; }

        public Ogrenci(long numara = 2644030001L, string ad = "İsimsiz", int yas = 0)
            :base(ad, yas)
        {
           Numara = numara; 
        }

        public override string ToString()
        {
            return $"Merhaba. Ben {Numara} numaralı öğrenciniz {Ad} ve {Yas} yaşındayım.";
        }
    }
}
