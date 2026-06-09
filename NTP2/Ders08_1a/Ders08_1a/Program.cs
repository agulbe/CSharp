using Ders08_1a.Models;
namespace Ders08_1a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new();
            Console.WriteLine("Öğrencinin Adı: " + ogrenci.Ad);
            Console.WriteLine("Yaşı: " + ogrenci.Yas);
            

            BilgisayarOgrencisi blg = new(
               2444030010, "BL2-10", "Evin", 18, 1.61, 55);
            Console.WriteLine(blg.ToString());
            blg.Konus();
        }
    }
}
