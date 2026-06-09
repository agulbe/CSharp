// using System.Collections.Generic;
namespace Ders07_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<string> isimler1 = new List<string>();
            // var isimler2 = new List<string>();
            List<string> isimler = new();

            // List<string> liste1 = new List<string> { "Ali", "Can", "Ela" };
            List<string> liste = ["Ali", "Can", "Ela"];

            // Eleman ekleme
            isimler.Add("Ali");
            isimler.Add("Can");
            isimler.Add("Ela");

            Console.WriteLine(new string('-', 20) + " 3 öğe Add...");
            foreach (string isim in isimler)
                Console.WriteLine(isim);

            // Eleman ekleme - 2
            isimler.Insert(1, "Ayşe");

            Console.WriteLine(new string('-', 20) + " 1 öğe Insert...");
            foreach (string isim in isimler)
                Console.WriteLine(isim);

            // Eleman ekleme - 3
            // isimler.AddRange(new string[] { "Cem", "Eda", "Nil", "Nur" });
            isimler.AddRange([ "Cem", "Eda", "Nil", "Nur" ]);
            isimler.AddRange(liste);

            Console.WriteLine(new string('-', 20) + " AddRange ...");
            foreach (string isim in isimler)
                Console.WriteLine(isim);

            // Eleman silme
            isimler.Remove("Ayşe");

            Console.WriteLine(new string('-', 20) + " 1 öğe Remove (Ayşe)...");
            foreach (string isim in isimler)
                Console.WriteLine(isim);

            // Eleman silme - 2
            // 5. öğeyi sil
            isimler.RemoveAt(5);

            Console.WriteLine(new string('-', 20) + " 5. öğe silindi RemoveAt...");
            foreach (string isim in isimler)
                Console.WriteLine(isim);

            // Eleman silme - 3
            // 2. öğeden başla, 3 eleman sil
            isimler.RemoveRange(2, 3);

            Console.WriteLine(new string('-', 20) + " 2. ile başlayan 3 öğe silindi RemoveRange...");
            foreach (string isim in isimler)
                Console.WriteLine(isim);

            // Elemanları yazdırma
            Console.WriteLine(new string('-', 20) + " for ile...");
            for(int i = 0; i < isimler.Count; i++)
                Console.WriteLine(isimler[i]);

            Console.WriteLine(new string('-', 20) + " for ile geriye doğru...");
            for (int i = isimler.Count-1; i >= 0; i--)
                Console.WriteLine(isimler[i]);

            Console.WriteLine(new string('-', 20) + " foreach ile...");
            foreach (string isim in isimler)
                Console.WriteLine(isim);

            // Öğe sayısı
            Console.WriteLine($" isimler listesinde kalan öğe sayısı: {isimler.Count}.");

            // öğe arama
            string aranan = "Cem";
            int konum = -1;
            if(isimler.Contains(aranan))
            {
                Console.WriteLine($" {aranan} isimler listesinde var.");
                Console.WriteLine($"{aranan} listede {konum=isimler.IndexOf(aranan)}. sırada yer alıyor.");
                Console.WriteLine($"{aranan} listede {isimler.IndexOf(aranan, konum+1)}. sırada yer alıyor.");
            }                
            else
                Console.WriteLine($" {aranan} isimler listesinde yok.");
            Console.WriteLine($"{aranan} listede {konum = isimler.IndexOf(aranan)}. sırada yer alıyor.");

            // Tüm öğeleri sil
            isimler.Clear();
            Console.WriteLine($"  artık listede {isimler.Count} öğe var.");

            string[] dizi = ["Cem", "Nil", "Nur"];
            List<string> adlar = new List<string>(dizi);

            string[] dizim = new string[adlar.Count];
            liste.CopyTo(dizim);
            adlar.InsertRange(0, dizim);

            adlar.ForEach(isim => Console.Write(isim[0]));

            if( adlar.TrueForAll(isim => isim.Length == 3) )
                Console.WriteLine(" adlar listesindeki tüm öğeler 3 karakterden oluşur.");
            else
                Console.WriteLine(" adlar listesindeki öğelerden en az biri 3 karakter uzunluğunda değildir.");

            string metin = string.Join(", ", adlar);

            File.WriteAllText("adlar.txt", metin);

            adlar.Insert(0, "Ege");
            adlar.Insert(5, "Efe");
            adlar.Insert(2, "İsa");

            Console.WriteLine(new string('-', 20) + " sıralamadan önce...");
            foreach (string isim in adlar)
                Console.WriteLine(isim);
            
            adlar.Sort();
            Console.WriteLine(new string('-', 20) + " siraladıktan sonra...");
            foreach (string isim in adlar)
                Console.WriteLine(isim);
            
            adlar.Reverse();
            Console.WriteLine(new string('-', 20) + " ters çevirdikten sonra...");
            foreach (string isim in adlar)
                Console.WriteLine(isim);

            isimler = adlar.GetRange(2, 4);
            Console.WriteLine(new string('-', 20) + " GetRange...");
            foreach (string isim in isimler)
                Console.WriteLine(isim);

            // İlk eleman
            Console.WriteLine($" ilk eleman: {adlar[0]}");
            // Son eleman
            Console.WriteLine($" son eleman: {adlar[adlar.Count - 1]}");
            Console.WriteLine($" son eleman: {adlar[^1]}");

            // Sondan 3. eleman
            Console.WriteLine($" son eleman: {adlar[^3]}");

            Console.WriteLine($"  adlar listesinin kapasitesi: {adlar.Capacity},  eleman sayısı: {adlar.Count}.");
            adlar.TrimExcess();
            Console.WriteLine($"  adlar listesinin kapasitesi: {adlar.Capacity},  eleman sayısı: {adlar.Count}.");

            int n = adlar.BinarySearch("Ege");
            Console.WriteLine("Ege "+n+". sırada.");

            List<string> list = new List<string>();
            list = adlar.GetRange(0, adlar.Count);

            if(list == adlar)
                Console.WriteLine("list VE adlar EŞİTTİR.");
            else
                Console.WriteLine("list VE adlar EŞİT DEĞİLDİR.");

            if(list.SequenceEqual(adlar))
                Console.WriteLine("list VE adlar EŞİTTİR.");
            else
                Console.WriteLine("list VE adlar EŞİT DEĞİLDİR.");

            if(isimler is ["İsa", "Ela", "Ege", "Efe"])
                Console.WriteLine("Evet isimler [\"İsa\", \"Ela\", \"Ege\", \"Efe\"].");
            else
                Console.WriteLine("Hayır!");

            var yeni = adlar.Concat(list).ToList();
            Console.WriteLine(new string('-', 20) + " Concat...");
            foreach (string isim in yeni)
                Console.WriteLine(isim);
        }
    }
}
