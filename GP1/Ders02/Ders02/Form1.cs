namespace Ders02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Topla(double a, double b)
        {
            double sonuc = a + b;
            return sonuc;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);

            double sonuc = Topla(sayi1, sayi2);
            lblSonuc.Text = "Sonuç:\n" + sonuc.ToString();
        }
    }
}
