namespace Ders09_1a
{
    internal class Program
    {
        // Temsilci tanımlama
        // imza: geri dönüş tipi (void) + parametreler (2 adet double)
        private delegate void AritmetikEventHandler(double a, double b);

        // Temsilcinin çalıştırabileceği metodları tanımlama
        // imza: geri dönüş tipi (double) + parametreler (2 adet double) 
        private static void Topla(double a, double b)
        {
            Console.WriteLine("Toplam: " + (a + b));
        }

        private static void Carp(double a, double b)
        {
            Console.WriteLine("Çarpım: " + (a * b));
        }

        private static void Cikar(double a, double b)
        {
            Console.WriteLine("Fark: " + (a - b));
        }

        private static void Bol(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Sıfıra bölme hatası!");
                return; // Not a Number
            }
            Console.WriteLine("Bölüm: " + (a / b));
        }  

        private static void Ortalama(double a, double b)
        {
            Console.WriteLine("Ortalama: " + ((a + b)/2));
        }



        static void Main(string[] args)
        {
            // Temsilci tanımla ve ilk metodu (Topla) abone et
            AritmetikEventHandler temsilci = new(Topla);

            // Temsilci ile metodu çalıştır.
            temsilci(15, 25);

            // Temsilciye metod abone etme (+=)
            temsilci += Carp;

            // Temsilci ile metodları çağır
            temsilci(25, 15);

            temsilci += Cikar;
            temsilci += Bol;
            temsilci -= Topla; // Temsilciden metod çıkarma (-=)


            temsilci(15, 25);

            int[] dizi = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29];
            //foreach (var i in dizi)
            //    i = 0;
            for(int i=0; i<=10;i+=2)
                Console.WriteLine(i);

        }
    }
}
