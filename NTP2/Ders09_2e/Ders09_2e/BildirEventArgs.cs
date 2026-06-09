namespace Ders09_2e
{
    public class BildirEventArgs: EventArgs
    {   
        public string Ozellik { get; set; }
        public object EskiDeger { get; set; }
        public object YeniDeger { get; set; }

        public BildirEventArgs(string ozellik, object eski=null, object yeni=null)
        {
            Ozellik = ozellik;
            EskiDeger = eski;
            YeniDeger = yeni;
        }
    }
}
