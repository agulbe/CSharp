namespace Ders16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpYks_ValueChanged(object sender, EventArgs e)
        {
            tmrYks.Enabled = true;
            // Tarih saat oluşturma
            // DateTime YksTarihi = new DateTime(2026, 6, 21, 10, 0, 0);
            // Tarih oluşturma
            // DateTime YksSadeceTarih = new (2026, 6, 21);
        }

        private void tmrYks_Tick(object sender, EventArgs e)
        {
            DateTime YksTarihi = new DateTime(new DateOnly(
                dtpYks.Value.Year,
                dtpYks.Value.Month,
                dtpYks.Value.Day),
                new TimeOnly(10, 0, 0)
                );

            int Yil = YksTarihi.Year;
            int Ay = YksTarihi.Month;
            int Gun = YksTarihi.Day;
            DayOfWeek HaftaninGunu = YksTarihi.DayOfWeek;
            int YilinGunu = YksTarihi.DayOfYear;
            int haftaninGunu = (int)HaftaninGunu;
            int Saat = YksTarihi.Hour;
            int Dakika = YksTarihi.Minute;
            int Saniye = YksTarihi.Second;

            // int MiliSaniye = YksTarihi.Millisecond;
            // int NanoSaniye = YksTarihi.Nanosecond;
            DateTime Simdi = DateTime.Now;

            TimeSpan fark = YksTarihi.Subtract(Simdi);
            lblYks.Text = fark.ToString();

            int kalanGun = (int)fark.TotalDays;
            int kalanSaat = (int)(fark.Subtract(new TimeSpan(kalanGun, 0, 0, 0)).TotalHours);
            int kalanDakika = (int)(fark.Subtract(new TimeSpan(kalanGun, kalanSaat, 0, 0)))
                .TotalMinutes;
            double kalanSaniye = (fark.Subtract(new TimeSpan(kalanGun, kalanSaat, kalanDakika, 0)))
                .TotalSeconds;
            kalanSaniye = Math.Round(kalanSaniye);
            lblYks.Text += "\r\nGün: " + kalanGun;
            lblYks.Text += "\r\nSaat: " + kalanSaat;
            lblYks.Text += "\r\nDakika: " + kalanDakika;
            lblYks.Text += "\r\nSaniye: " + kalanSaniye;
        }
    }
}
