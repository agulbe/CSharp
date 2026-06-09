using System;
using System.Collections.Generic;
using System.Text;

namespace Ders08_2d.Model
{
    public class EvcilHayvan : IBuyume
    {
        private int boy;
        public int Boy => boy;

        public void Buyu(int uzamaMiktari)
        {
            boy += uzamaMiktari;
        }
    }
}
