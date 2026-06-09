namespace Ders07_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> adlar = new();
            adlar.Add("Can");
            adlar.Add("Ali");
            adlar.Add("Nur");
            adlar.Add("Cem");
            adlar.Add("İsa");
            adlar.Add("Eda");
            adlar.Add("Nil");
            adlar.Add("Naz");
            adlar.Add("Ali"); // Zaten var.

            Console.WriteLine(new String('-', 20) + " foreach ile yazdırma...");
            foreach (string ad in adlar)
                Console.WriteLine(ad);

            HashSet<string> isimler = ["Ela", "Ege","İsa", "Efe", "Ece", "Ada", "Can" ];

            if(isimler.Overlaps(adlar))
                Console.WriteLine("İki kümenin ortak elemanı var.");
            else Console.WriteLine("İki kümenin ortak elemanı yok.");

            // A U B
            var birlesim = adlar.Union(isimler);
            Console.WriteLine(new String('-', 20) + " Union...");
            foreach (string ad in birlesim)
                Console.WriteLine(ad);

            // A n B
            var kesisim = adlar.Intersect(isimler);
            Console.WriteLine(new String('-', 20) + " Intersect...");
            foreach (string ad in kesisim)
                Console.WriteLine(ad);

            // A - B
            var fark = adlar.ToHashSet();
            fark.ExceptWith(isimler);
            Console.WriteLine(new String('-', 20) + " Except...");
            foreach (string ad in fark)
                Console.WriteLine(ad);

            // A-B U B-A
            adlar.SymmetricExceptWith(isimler);

            Console.WriteLine(new String('-', 20) + " SymmetricExceptWith ile yazdırma...");
            foreach (string ad in adlar)
                Console.WriteLine(ad);

            Console.WriteLine(new String('-', 20) + " for ile yazdırma...");
            for(int i=0; i<adlar.Count; i++)
                Console.WriteLine(adlar.ElementAt(i));

            // Öğe silme
            adlar.Remove("Naz");
            Console.WriteLine(new String('-', 20) + " Remove...");
            foreach (string ad in adlar)
                Console.WriteLine(ad);

            string aranan = "Ali";
            if(adlar.Contains(aranan))
                Console.WriteLine($"{aranan} kümede var.");
            else Console.WriteLine($"{aranan} kümede yok.");

            adlar.Add("Nuh");
            adlar.Add("Oya");
            adlar.Add("Alp");
            adlar.Add("Ulu");
            adlar.Add("Gül");
            adlar.Add("Ahu");
            adlar.Add("Asu");

            var names = adlar.Append("Ata");
            

            IEnumerable<string[]> chunk = names.Chunk(5);
            Console.WriteLine(new String('-', 20) + " Chunk...");
            foreach (var liste in chunk)
            {
                Console.Write(" > ");
                foreach (string ad in liste)
                    Console.Write(ad+" ");
                Console.WriteLine();
            }

            // Tümünü sil
            adlar.Clear();
            Console.WriteLine("adlar HashSet içinde "+adlar.Count+" isim var.");

        }

    }
}
