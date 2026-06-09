namespace AkilliEv
{
    internal class Program
    {
            static List<AkilliCihaz> EvCihazlari = new();


        static void Hareket(OdaTipi oda, int sicaklik)
        {
            // İlgili odadaki cihazları bul
            var aktifOdaCihazlari = EvCihazlari.Where(c => c.Konum == oda).ToList();

            if (aktifOdaCihazlari.Count == 0) return;

            foreach (var cihaz in aktifOdaCihazlari)
            {
                if (cihaz is Lamba lamba)
                {
                    lamba.Ac();
                }
                else if (cihaz is GuvenlikKamerasi kamera)
                {
                    kamera.Ac();
                }
                else if (cihaz is Klima klima)
                {
                    // Gelen sıcaklık parametresini doğrudan kullanıyoruz
                    if (sicaklik > 30)
                        klima.Ac();
                    else
                        Console.WriteLine($" -> ℹ️ {cihaz.Konum} Klima çalışmadı"+
                                           " (Sıcaklık uygun).");
                }
            }
        }
            static void Main(string[] args)
            {
                // Cihazları ekleyelim...
                EvCihazlari.Add(new GuvenlikKamerasi("Salon Kamerası", OdaTipi.Salon));
                EvCihazlari.Add(new Klima("Salon Kliması", OdaTipi.Salon));
                EvCihazlari.Add(new Lamba("Avize", OdaTipi.Salon));
                EvCihazlari.Add(new Klima("Oturma Odası Kliması", OdaTipi.OturmaOdasi));
                EvCihazlari.Add(new Lamba("Spotlar", OdaTipi.OturmaOdasi));
                EvCihazlari.Add(new Lamba("Mutfak Işığı", OdaTipi.Mutfak));
                EvCihazlari.Add(new GuvenlikKamerasi("Mutfak Kamerası", OdaTipi.Mutfak));
                EvCihazlari.Add(new Lamba("Banyo Lambası", OdaTipi.Banyo));
                EvCihazlari.Add(new GuvenlikKamerasi("Dış Kamera", OdaTipi.Balkon));
                EvCihazlari.Add(new Lamba("Balkon Işığı", OdaTipi.Balkon));

                HareketSensoru sensor = new();

                // 4. Olaya Abone Olma
                // Tanımladığımız delege üzerinden.
                sensor.HareketAlgilandi += Hareket;

                // Testler
                // Mutfakta sadece lamba ve kamera var
                sensor.HareketiSimuleEt(OdaTipi.Mutfak, 25);
                // Oturma odasında lamba ve klima var,
                // Sıcaklık 33 olduğu için klima da açılacak
                sensor.HareketiSimuleEt(OdaTipi.OturmaOdasi, 33);  
            }
    }
}
