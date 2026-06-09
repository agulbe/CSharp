using Ders09_2c.Model;

namespace Ders09_2c
{
    internal class Program
    {
        private static void Dvd_StokAzaldi(object sender, StokEventArgs e)
        {
            Console.WriteLine("" + 
                (e.AsgariStokSeviyesi - e.AnlikStokMiktari) +
                " adet sipariş geçildi.");
        }

        static void Main(string[] args)
        {
            Urun Dvd = new Urun("DVD Windows 11 Pro 64b Tr",
                1197.75M, 15, 10);
            Dvd.StokAzaldi += Dvd_StokAzaldi;
            Dvd.Sat(2);
            Console.WriteLine(Dvd.ToString());
            Dvd.Sat(4);
            Console.WriteLine(Dvd.ToString());
            Dvd.Al(3);
        }
    }
}
