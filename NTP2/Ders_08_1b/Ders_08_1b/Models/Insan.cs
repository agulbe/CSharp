namespace Ders_08_1b.Models
{
    internal class Insan
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        public Insan(string ad = default, int yas = default)
        {
            Ad = ad;
            Yas = yas;
        }


        public override string ToString()
        {
            return $"Merbaba. Ben {Ad} ve {Yas} yaşındayım.";
        }
    }
}
