namespace AkilliEv
{
    public class Klima : AkilliCihaz, IKontrolEdilebilir
    {
        public Klima(string ad, OdaTipi konum) : base(ad, konum) { }
        public void Ac()  
        { 
            Console.WriteLine($" -> ❄️ {Konum} {Ad} SOĞUTMAYA BAŞLADI."); 
        }
        public void Kapat() 
        { 
            Console.WriteLine($" -> 🛑 {Konum} {Ad} DURDU."); 
        }
    }
}
