using System;
using System.Collections.Generic;
using System.Text;

namespace Ders08_2b.Model
{
    public abstract class OkuyanInsan
    {
        // Bu sınıftan nesne üretmeden Oku metodu kullanılsın.
        //public static void Oku()
        //{
        //    Console.WriteLine("Gayet düzgün okuyorum.");
        //}

        // Bu sınıftan türeyecek olan sınıflar kendi Oku metodlarını tanımlsınlar
        // public abstract void Oku();

        // Bu sıbnıftan türeyecek sınıflar bu metodu isterlerse override edebilirler.
        public virtual void Oku()
        {
            Console.WriteLine("Gayet düzgün okuyorum.");
        }

    }
}
