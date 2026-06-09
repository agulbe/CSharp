namespace Ders09_1b
{
    public partial class Form1 : Form
    {


        private delegate void AritemtikEventHandler(double a, double b); // Temsilci tanımlama
        private AritemtikEventHandler aritmetikEventHandler; // Temsilci nesnesi tanımlama

        // Temsilcinin çalıştırabileceği metodları tanımlama
        // imza: geri dönüş tipi (double) + parametreler (2 adet double) 
        private void Topla(double a, double b)
        {
            lblSonuc.Text += ("Toplam: " + (a + b)) + "\n";
        }

        private void Carp(double a, double b)
        {
            lblSonuc.Text += ("Çarpım: " + (a * b)) + "\n";
        }

        private void Cikar(double a, double b)
        {
            lblSonuc.Text += ("Fark: " + (a - b)) + "\n";
        }

        private void Bol(double a, double b)
        {
            if (b == 0)
            {
                return; // Not a Number
            }
            lblSonuc.Text += ("Bölüm: " + (a / b)) + "\n";
        }

        private void Ortalama(double a, double b)
        {
            lblSonuc.Text += ("Ortalama: " + ((a + b) / 2)) + "\n";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "Sonuçlar:\n";
            double a = double.Parse(txtSayi1.Text);
            double b = double.Parse(txtSayi2.Text);

            if(aritmetikEventHandler != null)
                aritmetikEventHandler(a, b); // Temsilciyi çalıştırma
        }

        private void chkTopla_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTopla.Checked)
                aritmetikEventHandler += Topla; // Temsilciye metod ekleme
            else
                aritmetikEventHandler -= Topla; // Temsilciden metod çıkarma
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aritmetikEventHandler = new AritemtikEventHandler(Topla); // Temsilciye metod atama   
        }

        private void chkCarp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarp.Checked)
                aritmetikEventHandler += Carp; // Temsilciye metod ekleme
            else
                aritmetikEventHandler -= Carp; // Temsilciden metod çıkarma
        }

        private void chkCikar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCikar.Checked)
                aritmetikEventHandler += Cikar; // Temsilciye metod ekleme
            else
                aritmetikEventHandler -= Cikar; // Temsilciden metod çıkarma
        }

        private void chkBol_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkBol.Checked)
                aritmetikEventHandler -= Bol; // Temsilciden metod çıkarma
            else
                aritmetikEventHandler += Bol; // Temsilciye metod ekleme
        }
    }
}
