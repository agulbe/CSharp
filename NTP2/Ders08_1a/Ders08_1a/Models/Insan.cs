using System.Reflection.Metadata.Ecma335;

namespace Ders08_1a.Models
{
    // Temel Sınıf
    public class Insan
    {
        protected string dogumYeri;

        public string DogumYeri
        {
            get => dogumYeri;
            set { dogumYeri = value; }
        }

        public string Ad { get; set; }
        private int yas;

        public int Yas
        {
            get { return yas; }
            set 
            {
                if (value >= 1)
                    yas = value;
            }
        }


        public double Boy { get; set; }
        public float Kutle { get; set; }

        public Insan()
        {
            Ad = "İsimsiz";
            Yas = 1;
            Boy = 0.5;
            Kutle = 3.5F;            
        }

        public Insan(string ad, int yas, double boy, float kutle)
        {
            Ad = ad;
            Yas = yas;
            Boy = boy;
            Kutle = kutle;
        }

        public void Konus()
        {
            Console.WriteLine("Merhaba, ben bir insanım.");
        }

        public void Yuru()
        {
            if(Yas <= 1)
                Console.WriteLine("Şimdilik en fazla emekleyebilirim.");
            else Console.WriteLine("Yaşasın, yürüyorum!");
        }
    }
}
