using Ders09_2b.Model;

namespace Ders09_2b
{
    internal class Program
    {
        // Olay metodları tanımla
        // Metodları olaya abone et


        // Metod tanımlamaları
        public static void YemekVer(Kedi kedi, CatEventArgs e)
        {            
            if(e.SonOlayZamani < DateTime.Now.AddHours(-4))
            {
                Console.WriteLine("Kediye mama verdim.");
                kedi.SonYemekZamani = DateTime.Now;
            }
            else
                Console.WriteLine("Kedi acıkmış olamaz.");
            
            kedi.AcMi = false;
        }

        public static void SuVer(Kedi kedi, CatEventArgs e)
        {
            if (e.SonOlayZamani < DateTime.Now.AddHours(-2))
            {
                Console.WriteLine("Kediye su verdim.");
                kedi.SonSuZamani = DateTime.Now;
            }
            else
                Console.WriteLine("Kedi susamış olamaz.");
            kedi.SusamisMi = false;
        }

        public static void Oksa(Kedi kedi, CatEventArgs e)
        {
            Console.WriteLine("Kediyi okşadım.");
            kedi.UrkmusMu = false;
            kedi.SonSevmeZamani = DateTime.Now;
        }

        static void Main(string[] args)
        {
            Kedi garfield = new();

            // Olaya abone olma
            garfield.Acikti += YemekVer;
            garfield.Susadi += SuVer;
            garfield.Urktu += Oksa;

            garfield.AcMi = true;
        }
    }
}
