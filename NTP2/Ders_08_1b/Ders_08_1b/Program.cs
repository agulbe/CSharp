using Ders_08_1b.Models;

namespace Ders_08_1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan adam; // İnsan sınıfından adam adlı bir nesne tanımlama
            // adam.Ad = "Adam";

            adam = new Insan(); // Insan sınıfının kurucusunu çağırak örnekleme 
            Console.WriteLine(adam.ToString());


            adam.Ad = "Adam Sandler";
            adam.Yas = 60;
            Console.WriteLine(adam.ToString());

            Insan ben = new Insan(); // Insan sınıfından ben adlı bir nesne tnımlayıp örnekledik.
            Console.WriteLine(ben.ToString());
            ben.Ad = "Ben Stiller";
            ben.Yas = 61;
            Console.WriteLine(ben.ToString());

            Insan eddie = new("Eddie Murphy", 65);
            Console.WriteLine(eddie.ToString());

            Insan ogrenci = new Ogrenci(2444030015L, "Abdullah", 19);
            // Console.WriteLine(ogrenci.Numara);
            Console.WriteLine(ogrenci.ToString());

            // Ogrenci ogr = new Insan(); // Hata

            Ogretmen ogretmen = new("A0017", "Alper", 57);
            Console.WriteLine(ogretmen.ToString());
            
            List<Insan> insanlar = new List<Insan>();
            insanlar.Add(adam);
            insanlar.Add(ben);
            insanlar.Add(eddie);
            insanlar.Add(ogrenci);
            insanlar.Add(ogretmen);

            foreach (Insan insan in insanlar)
                Console.WriteLine(insan.ToString());
        }
    }
}
