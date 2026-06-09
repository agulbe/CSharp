using Ders08_2d.Model;

namespace Ders08_2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new() { Ad = "Can"};
            insan.Buyu(150);

            EvcilHayvan pet = new();
            pet.Buyu(30);

            IBuyume buyuyenVarlik = insan;
            Console.WriteLine( buyuyenVarlik.Boy);
            buyuyenVarlik = pet;
            Console.WriteLine(buyuyenVarlik.Boy);

            List<IBuyume> buyuyenVarliklar = new();
            buyuyenVarliklar.Add(insan);
            buyuyenVarliklar.Add(pet);

            foreach (var varlik in buyuyenVarliklar)
                varlik.Buyu(4);

            foreach(var varlik in buyuyenVarliklar)
                Console.WriteLine(varlik.Boy);


        }
    }
}
