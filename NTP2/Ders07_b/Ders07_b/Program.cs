namespace Ders07_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> kuyruk = new();
            kuyruk.Enqueue(127);
            kuyruk.Enqueue(67);
            kuyruk.Enqueue(89);

            // for ile yazdırma
            Console.WriteLine(new String('-', 20) + " Yazdırma");
            for (int i = 0; i < kuyruk.Count; i++)
                Console.WriteLine(kuyruk.ElementAt(i));

            // Sıradaki elemanı alma
            Console.WriteLine(" > Sıradaki eleman: "+kuyruk.Peek());

            // Sıradaki öğeyi işleme ve kaldırma
            Console.WriteLine(" > Sıradaki eleman: " + kuyruk.Dequeue() +
                " işlemi yapıldı ve kuyruktan ayrıldı.");

            // Foreach ile yazdırma
            Console.WriteLine(new String('-', 20) + " Yazdırma");
            foreach (var item in kuyruk)
                Console.WriteLine(item);

            // kuyruk.Enqueue("Ahmet Amca"); // Hata verir, çünkü kuyruk int türünde tanımlandı, string kabul etmez
            // kuyruk.Enqueue(3.14); // Hata verir, çünkü kuyruk int türünde tanımlandı, double kabul etmez
            // kuyruk.Enqueue(12L); // Hata verir, çünkü kuyruk int türünde tanımlandı, long kabul etmez
        }
    }
}
