
using Ders08_2a.Model;

namespace Ders08_2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dunyali dunyali1 = new();
            IInsan insan = new Insan();
            insan.Konus();

            IInsan dunyali = dunyali1;
            dunyali.Konus();
            // dunyali.Zipla();
            dunyali1.Zipla();

            IInsan marsli = new Marsli();
            marsli.Konus();
            // marsli.Uc();



        }
    }
}
