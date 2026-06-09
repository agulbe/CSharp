using Ders08_2b.Model;

namespace Ders08_2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new();
            Ogretmen ogretmen = new();



            IOkuyanInsan okuyanInsan = ogrenci;
            IMusteriInsan x = ogretmen;
            x.KitapAl();
            // ogretmen.KitapAl();
            // ogrenci.Oku();
            okuyanInsan.Oku();


        }
    }
}
