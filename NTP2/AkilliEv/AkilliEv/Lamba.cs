namespace AkilliEv
{
    public class Lamba : AkilliCihaz, IKontrolEdilebilir
    {
        public Lamba(string ad, OdaTipi konum) : base(ad, konum) { }
        public void Ac()
        { 
            Console.WriteLine($" -> 💡 {Konum} {Ad} YANDI."); 
        } 
        public void Kapat()
        {
            Console.WriteLine($" -> 🌑 {Konum} {Ad} SÖNDÜ.");
        }  
    }
}
