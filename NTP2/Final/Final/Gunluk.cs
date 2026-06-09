using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    static class Gunluk
    {
        private static readonly string Klasor = "gunluk";
        private static readonly string Dosya = Path.Combine(Klasor, "notlar.txt");

        public static void NotEkle(string metin)
        {
            Directory.CreateDirectory(Klasor);
            string satir = $"{DateTime.Now:g} - {metin}{Environment.NewLine}";
            File.AppendAllText(Dosya, satir);
        }

        public static void Yazdir()
        {
            if (!File.Exists(Dosya))
            {
                Console.WriteLine("Henüz günlük yok.");
                return;
            }

            using var okuyucu = new StreamReader(Dosya);
            Console.WriteLine(okuyucu.ReadToEnd());
        }
    }

}
