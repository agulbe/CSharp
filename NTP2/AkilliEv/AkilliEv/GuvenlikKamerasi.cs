namespace AkilliEv
{
    public class GuvenlikKamerasi : AkilliCihaz, IKontrolEdilebilir
    {
        public GuvenlikKamerasi(string ad, OdaTipi konum) : base(ad, konum) { }
        public void Ac() 
        { 
            Console.WriteLine($" -> 🎥 {Konum} {Ad} KAYITTA."); 
        }
        public void Kapat() 
        { 
            Console.WriteLine($" -> 🛑 {Konum} {Ad} KAYIT DURDU."); 
        }
    }
}
