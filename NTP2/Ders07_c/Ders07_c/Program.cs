namespace Ders07_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<float> sacboyasi = new();

            // Eleman ekleme
            sacboyasi.Push(1.5f);
            sacboyasi.Push(2.1f);
            sacboyasi.Push(5.7f);

            // FOR İLE YAZDİRMA
            Console.WriteLine(new String('-', 20)+ " for ile yazdırma");
            for (int i = 0; i < sacboyasi.Count; i++)
                Console.WriteLine(sacboyasi.ElementAt(i));

            // Sıradaki elemanı gösterme
            Console.WriteLine(" > Sıradaki eleman: " + sacboyasi.Peek());

            // Eleman çıkarma
            Console.WriteLine(" > İşlenen eleman: " + sacboyasi.Pop()+
                " ve yığından alındı.");

            // foreach ile yazdırma
            Console.WriteLine(new String('-', 20) + " for ile yazdırma");
            foreach (var item in sacboyasi)
                Console.WriteLine(item);
        }
    }
}
