using System;
using System.Collections.Generic;
using System.Text;

namespace Ders08_2a.Model
{
    public class Insan : IInsan
    {
        public string Ad { get ; set; }
        public int Yas { get ;
            set {
                if (value >= 0)
                    Yas = value;
            }

        }

        public void Konus()
        {
            Console.WriteLine("Merhaba, ben insanım!");
        }

        public void Yuru()
        {
            Console.WriteLine("Yaşasın yürüyorum.");
        }
    }
}
