using System.Collections;
namespace Ders07_2c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yığın oluşturma
            Stack yigin = new();

            // Yığına eleman ekleme
            yigin.Push("Elma");
            yigin.Push("Armut");
            yigin.Push("Muz");
            yigin.Push(new { Tur = "Kavun", Cesit = "Kantalup" });
            yigin.Push(3.14);

            Console.WriteLine("--- Elemanlar eklendikten sonra ---");
            object[] ogeler = yigin.ToArray();
            foreach (var oge in ogeler)
                Console.WriteLine(oge);

            // Sıradaki öğe işleme
            Console.WriteLine($"sırada işlem görecek olna öğe: {yigin.Pop()}");

            Console.WriteLine("--- Sıradaki öğe işlendikten sonra Yığın ---");
            ogeler = yigin.ToArray();
            foreach (var oge in ogeler)
                Console.WriteLine(oge);

            // Yığının en üstündeki öğeyi görüntüleme
            Console.WriteLine($"--- Yığının en üstündeki öğe {yigin.Peek()}--- ");

            var aranan = "Mahmut";
            if (yigin.Contains(aranan))
                Console.WriteLine($"Yığın içinde {aranan} var.");
            else
                Console.WriteLine($"Yığın içinde {aranan} yok.");

            // Yığındaki öğe sayısı
                        Console.WriteLine($"Yığındaki öğe sayısı: {yigin.Count}");

            // Klonlama
            Stack klon = new();
            klon = (Stack)yigin.Clone();

            // Kopyalama
            yigin.CopyTo(ogeler, 2);

            // Yığının temizlenmesi
            yigin.Clear();
            Console.WriteLine($"Yığındaki öğe sayısı: {yigin.Count}");

            string[] dizi = new string[klon.Count];
            for (int i = 0; i < klon?.Count; i++)
                dizi[i] = klon.Pop().ToString();

        }
    }
}
