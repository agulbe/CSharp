namespace Ders09_2b.Model
{
    // Olay tanımla
    // Olayı tetikle
    // Olayı çağır
    public class Kedi
    {
        public delegate void CatEventHandler(Kedi kedi, CatEventArgs args);
        // Olay tanımlamaları
        public event CatEventHandler Acikti;
        public event CatEventHandler Susadi;
        public event CatEventHandler Urktu;

        public DateTime SonYemekZamani { get; set; }
        public DateTime SonSuZamani { get; set; }
        public DateTime SonSevmeZamani { get; set; }

        private bool acMi;
        public bool AcMi { get; 
            set
            {
                acMi = value;
                if (acMi)
                    // AcMi özellik true olduğunda Acikti olayı tetiklenir
                    if (Acikti != null)
                        // Olayi çağır
                        Acikti(this, new CatEventArgs { SonOlayZamani = SonYemekZamani });
            } 
        }

        private bool susamisMi;
        public bool SusamisMi { get; 
            set; 
        }

        private bool urkmusMu;
        public bool UrkmusMu { get; 
            set; 
        }

        public Kedi()
        {
            SonYemekZamani = DateTime.Now.AddHours(-5);
            SonSuZamani = DateTime.Now;
            SonSevmeZamani = DateTime.Now;
        }
    }
}
