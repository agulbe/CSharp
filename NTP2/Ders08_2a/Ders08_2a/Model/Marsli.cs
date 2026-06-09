using System;
using System.Collections.Generic;
using System.Text;

namespace Ders08_2a.Model
{
    public class Marsli : IInsan
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        public void Konus()
        {
            Console.WriteLine("XjzT ben bir Mars'lı insanım.");
        }

        public void Uc()
        {
            Console.WriteLine("Burada yerçekimi çok düşük." +
            " Bu nedenle zıplayınca uçuyorum.");
        }
    }
}
