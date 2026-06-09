using System.Linq;

namespace Ders07_f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new();

            list.AddLast("Can");
            list.AddLast("Nuh");
            list.AddLast("Ali");
            list.AddLast("Ege");

            list.AddLast("Ali");
            // arama
            var aranan = "Ali";
            if(list.Find(aranan) != null)
            {
                Console.WriteLine($"{aranan} listede var.");
                //(int Index, string Item) Sonuc   = list.Index();
                //Console.WriteLine($"Yeri: {Sonuc.Yer}");
            }
                
            else
            {
                list.AddFirst(aranan);
                Console.WriteLine($"{aranan} listeye eklendi.");
            }
                Console.WriteLine(" ---- foreach"); 
            foreach(var oge in list)
                Console.WriteLine(oge);
        }
    }
}
