namespace Vize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] dizi1 = [1, 2, 3, 4];
                int[] dizi2 = {1, 2, 3, 4};
                int[] dizi3 = new int[] {1, 2, 3, 4};
                int[] dizi4 = new int[4] { 1, 2, 3, 4 };
            }

            {
                int[] eski = [1, 2, 3, 4];
                int[] yeni1 = new int[4];
                int[] yeni2 = new int[4];
                int[] yeni3 = new int[4];
                int[] yeni4 = new int[4];
                int[] yeni5 = new int[4];

                Array.Copy(eski, yeni1, eski.Length);
                eski.CopyTo(yeni2, 0);
                yeni3 = (int[])eski.Clone();
                yeni4 = eski;
                yeni5 = eski.ToArray();

                Console.WriteLine("yeni1...");
                foreach (int i in yeni1) Console.WriteLine(i);
                Console.WriteLine("yeni2...");
                foreach (int i in yeni2) Console.WriteLine(i);
                Console.WriteLine("yeni3...");
                foreach (int i in yeni3) Console.WriteLine(i);
                Console.WriteLine("yeni4...");
                foreach (int i in yeni4) Console.WriteLine(i);
                Console.WriteLine("yeni5...");
                foreach (int i in yeni5) Console.WriteLine(i);

            }

            {
                SortedList<string, int> liste = new SortedList<string, int>();
            }

        }
    }
}
