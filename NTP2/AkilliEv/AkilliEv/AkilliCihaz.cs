namespace AkilliEv
{
    public abstract class AkilliCihaz
    {
        public string Ad { get; set; }
        public OdaTipi Konum { get; set; }
        public AkilliCihaz(string ad, OdaTipi konum) { Ad = ad; Konum = konum; }
    }
}
