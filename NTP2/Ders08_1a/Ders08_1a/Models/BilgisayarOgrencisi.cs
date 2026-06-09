using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08_1a.Models
{
    public class BilgisayarOgrencisi : Ogrenci
    {
        public string ZimmetliBilgisayar { get; set; }
        public BilgisayarOgrencisi()
        {
            
        }
        public BilgisayarOgrencisi(long numara, string bilgisayar,
            string ad, int yas, double boy, float kutle)
            : base(numara, ad, yas, boy, kutle)
        {
            ZimmetliBilgisayar = bilgisayar;
        }
    }
}
