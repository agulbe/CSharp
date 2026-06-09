namespace Ders_08_1b.Models
{
    internal class Ogretmen : Insan
    {
        public string SicilNo { get; set; }

        public Ogretmen(string sicilNo="A0000", string ad="Öğretmen", int yas = 21)
            :base (ad, yas)
        {
            SicilNo = sicilNo;
        }

        public override string ToString()
        {
            return base.ToString()+"\r\n"+ $"Ben aynı zamanda bir öğretmenim.";
        }
    }
}
