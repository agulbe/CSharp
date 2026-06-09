using System.Collections;

namespace Ders07_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, string> sinifListesi = new Dictionary<long, string>();
            sinifListesi.Add(2444030008, "Zelal DARTAN");
            sinifListesi[2444030010] = "Kenan BARAN";
            sinifListesi[2444030010] = "Evin BORAN";
            sinifListesi[2444030012] = "Melisa GÜNEŞ";

            Console.Write("Öğrenci No.: ");
            long anahtar = long.Parse(Console.ReadLine());
            string deger;
            if(sinifListesi.TryGetValue(anahtar, out deger))
                Console.WriteLine($"Numarası: {anahtar}  Adı ve Soyadı: {deger}");
            Console.WriteLine($" Numara: {anahtar}  Adı ve Soyadı: {sinifListesi.GetValueOrDefault(anahtar)}");

            if(sinifListesi.TryAdd(anahtar, "Abdullah Gökce TEL"))
                Console.WriteLine("Eklendi.");
            else
                Console.WriteLine("Ekleme başarısız");

            // Anahtarları yazdırma
            Console.WriteLine(new String('-', 20)+ " Anahtarlar...");
            foreach (long item in sinifListesi.Keys)
                Console.WriteLine(item);

            // Değerleri yazdırma
            Console.WriteLine(new String('-', 20) + " Değerler...");
            foreach (string item in sinifListesi.Values)
                Console.WriteLine(item);


            // for ile yazdırma
            Console.WriteLine(new String('-', 20) + " for ile...");
            for (int i = 0; i < sinifListesi.Count; i++)
                Console.WriteLine($" Anahtar: {anahtar = sinifListesi.Keys.ElementAt(i)} "+
                    $" Değeri: {sinifListesi[anahtar]}");

            sinifListesi.Remove(2444030010);
            // foreach ile yazdırma
            Console.WriteLine(new String('-', 20) + " foreach ile anahtar değer çifti...");
            foreach (KeyValuePair<long, string> item in sinifListesi)
                Console.WriteLine(item.Key + " " + item.Value);

        }
    }
}
