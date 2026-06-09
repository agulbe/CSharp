using System.Collections;
using System.Runtime.ConstrainedExecution;
namespace Ders07_2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kuyruk oluşturma
            Queue kuyruk = new(5);
            // Kuyruğa öğe ekleme
            kuyruk.Enqueue("Evin");
            kuyruk.Enqueue("Melisa");
            kuyruk.Enqueue("Abdullah");
            kuyruk.Enqueue(125);
            kuyruk.Enqueue(new { Ad = "Dilek", Soyad = "Topkaya" });

            object[] ogeler = kuyruk.ToArray();
            Console.WriteLine("--- Eleman ekledikten sonra ---");
            foreach (object oge in ogeler)
                Console.WriteLine(oge.ToString());

            // Kuyruktaki sıradaki elemanı işleme
            object siradaki = kuyruk.Dequeue();
            Console.WriteLine($"--- {siradaki} kuyruktan çıkarıltan sonra ---");
            ogeler = kuyruk.ToArray();
            foreach (object oge in ogeler)
                Console.WriteLine(oge.ToString());

            // Sıradakini öğrenme
            Console.WriteLine("--- Sıradaki eleman: "+kuyruk.Peek());

            // Kuyruktaki eleman sayısı
            Console.WriteLine($"Şu an kuyrukta {kuyruk.Count} kişi sırada bekliyor.");

            // Kuyrukta öğe arama
            var aranan = 124;
            if(kuyruk.Contains(aranan))
                Console.WriteLine($"Evet, kuyrukta {aranan} yer alıyor.");
            else
                Console.WriteLine($"Hayır, kuyrukta {aranan} yer almıyor.");

            // Kuyruğu klonlama
            Queue yedek = new();
            yedek = (Queue) kuyruk.Clone() ;

            // Kuyruğun elemanlarını bir diziye kopyalamak
            kuyruk.CopyTo(ogeler, 2);

            // Fazlalıkları kırpma
            kuyruk.TrimToSize();

            // Kuyruğu temizle
            kuyruk.Clear();
        }
    }
}
