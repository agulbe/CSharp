namespace Ders08_2a.Model
{
    public class Dunyali : IInsan
    {
        public string Ad { get ; set ; }
        public int Yas { get; set ; }

        public void Konus()
        {
            Console.WriteLine("Merhaba, ben bir Dünya'lı insanım.");
        }

        public void Zipla()
        {
            Console.WriteLine("Yerden 1 metre yukarı zıplayabiliyorum.");
        }
    }
}
