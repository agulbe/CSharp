namespace Ders_08_1c.Models
{
    public class Insan
    {
        public string Ad { get; set; }
        private protected int Yas { get; set; }

        public virtual void Konus()
        {
            Console.WriteLine("Merhaba, ben bir insanım.");
            Console.WriteLine($"Adım {Ad} ve {Yas} yaşındayım.");
            Console.WriteLine();
        }

        public void Buyu()
        {
            Yas++;
        }

    }
}
