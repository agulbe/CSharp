using System.Threading.Channels;

namespace AkilliEv
{
    public delegate void HareketTemsilcisi(OdaTipi oda, int sicaklik);

    public class HareketSensoru
    {
        // 2. Olayı Kendi Temsilcimiz Tipinde Tanımlıyoruz
        public event HareketTemsilcisi? HareketAlgilandi;

        public void HareketiSimuleEt(OdaTipi oda, int sicaklik)
        {
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine($"!!! SENSÖR: {oda} bölümünde hareket!");
            Console.WriteLine($" (Sıcaklık: {sicaklik}°C)");
            Console.WriteLine("------------------------------------------------");

            // 3. Olayı Tetikleme (Parametreleri doğrudan veriyoruz)
            // "Sender" veya "EventArgs" nesnesi oluşturmaya gerek kalmadı.
            if (HareketAlgilandi != null)
            {
                HareketAlgilandi(oda, sicaklik);
            }
        }
    }
}
