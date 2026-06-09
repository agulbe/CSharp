namespace Ders09_2c.Model
{
    public delegate void StokAzaldiEventHandler (object urun, 
        StokEventArgs e);
    public class Urun
    {
        public event StokAzaldiEventHandler StokAzaldi;
        static int Kalem = 0;

        private int id;
        public int Id
        {
            get => id;       
        }

        private string ad;
        public string Ad
        {
            get => ad;
            set { ad = value; }
        }

        private double stokMiktari;

        public double StokMiktari
        {
            get => stokMiktari;
            set 
            {
                if (value < 0) return;
                stokMiktari = value;
                if (stokMiktari < kritikStokSeviyesi)
                {
                    if (StokAzaldi != null)
                    {
                        StokAzaldi(this,
                            new StokEventArgs {
                                AnlikStokMiktari = stokMiktari,
                            AsgariStokSeviyesi=kritikStokSeviyesi});
                    }
                }
            }
        }

        private decimal birimFiyat;

        public decimal BirimFiyat
        {
            get => birimFiyat;
            set { birimFiyat = value; }
        }

        private double kritikStokSeviyesi;

        public double KritikStokSeviyesi
        {
            get => kritikStokSeviyesi;
            set { kritikStokSeviyesi = value; }
        }

        public Urun()
        {
            id = ++Kalem;
        }
        public Urun(string ad, decimal fiyat, double stok, double kritik)
        {
            id = ++Kalem;
            Ad = ad;
            BirimFiyat = fiyat;
            StokMiktari = stok;
            KritikStokSeviyesi = kritik;
        }

        public override string ToString() =>
            Ad + " adlı üründen stokta " + StokMiktari + " birim var.";
        
        public void Al(double miktar)
        {
            if (miktar < 0)
                throw new Exception("Negatif sayıda ürün satın alamazsınız.");
                
            StokMiktari += miktar;
        }

        public void Sat(double miktar)
        {
            if (miktar < 0)
                throw new Exception("Negatif sayıda ürün satamazsınız.");

            StokMiktari -= miktar;
        }
    }
}
