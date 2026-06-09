using Ders_08_1c.Models;

namespace Ders_08_1c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Insan insan = new();
            insan.Yas = 20;
            insan.Konus();

            Bebek bebek = new();
            bebek.Konus();

            Insan yavru = new Bebek();
            yavru.Konus(); // Insan.Konus : türemiş sınıfta: new
                           // Bebek.Konus : türemiş sınıfta: override
        }
    }
}
