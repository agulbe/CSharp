namespace Final
{
    internal class Program
    {
        struct sNokta { public int X; }
        class cNokta { public int X; }
        
        static void q1a()
        {
            int? a;
            a = (int?)int.Parse(Console.ReadLine() ?? "5");

            if (a.HasValue)
            {
                Console.WriteLine("a is not null");
            }
            else
            {
                Console.WriteLine("a is null");
            }
        }
        
        static void q2a()
        {            
            sNokta p1 = new sNokta { X = 5 };
            sNokta p2 = p1;
            p2.X = 10;
            Console.WriteLine(p1.X);  // 5
        }

        static void q3a()
        {
            cNokta p1 = new cNokta { X = 5 };
            cNokta p2 = p1;
            p2.X = 10;
            Console.WriteLine(p1.X);  // 10
        }
        static void Main(string[] args)
        {
            //q2a();  // 5    
            //q3a();  // 10
            do
            {
                Console.Write(@"
Menü
----------
1. Günlük Notu Ekle
2. Günlük Notlarını Görüntüle
0. Çıkış

Seçiminiz: ");
                string secim = Console.ReadLine() ?? "0";
                switch (secim)
                {
                    case "1":
                        Console.Write("Notunuz: ");
                        string not = Console.ReadLine() ?? "";
                        Gunluk.NotEkle(not);
                        break;
                    case "2":
                        Gunluk.Yazdir();
                        break;
                    case "0":
                        Console.WriteLine("Çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
                Console.WriteLine("Devam etmek için Enter'a basın...");
            } while (true);
        }
    }
}
