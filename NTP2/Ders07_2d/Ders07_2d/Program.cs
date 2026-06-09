using System.Collections;
namespace Ders07_2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HashTable oluşturma
            // Hashtable hashtable = new Hashtable();
            // var hashtable = new Hashtable();
            Hashtable tablo = new();

            // Veri ekleme
            tablo.Add("ad", "Ahmet"); // Anahtar ve değer ekleme / Eski yöntem
            tablo["yas"] = 25;// Bu şekilde de ekleyebiliriz
            tablo["Gano"] = 3.75;
            tablo[2444030062] = "Ahmed ASSAF";

            // Tabloyu yazdırma
            Console.WriteLine("--- Keys koleksiyonu aracılığıyla ---");
            foreach (var anahtar in tablo.Keys)
                Console.WriteLine($"Anahtar: {anahtar}, Değer: {tablo[anahtar]}");

            Console.WriteLine("--- DictionaryEntry aracılığıyla ---");
            foreach(DictionaryEntry entry in tablo)
                Console.WriteLine($"Anahtar: {entry.Key}, Değer: {entry.Value}");

            Console.WriteLine(" > "+tablo["soyad"]);

            // Anahtar kontrolü
            if (tablo.ContainsKey("ad"))
                Console.WriteLine("Anahtar 'ad' mevcut.");
            else
                Console.WriteLine("Anahtar 'ad' mevcut değil.");

            // Değer kontrolü
            if(tablo.ContainsValue(30))
                Console.WriteLine("Değer 30 mevcut.");
            else
                Console.WriteLine("Değer 30 mevcut değil.");

            // Tabloyu diziye kopyalama
            object[] dizi = new object[tablo.Count];
            tablo.CopyTo(dizi, 0);

            foreach (var item in dizi)
                Console.WriteLine(item);

            // Öğe silme
            tablo.Remove("ad");

            // Tabloyu temizleme
            tablo.Clear();

        }
    }
}
