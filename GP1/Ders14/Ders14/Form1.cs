namespace Ders14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dosyaAdi = "D:\\Code\\ogrenci.csv";
            string[]? kayitlar = File.ReadAllLines(dosyaAdi);


            lstMetin.Items.Clear();
            for(int i=1;i<kayitlar.Length;i++)
            {
                string[]? degerler = kayitlar[i].Split(';');
                lstMetin.Items.Add(degerler[1]);
            }

            lblMetin.Text = "";
            for (int i = 0; i < kayitlar.Length; i++)
            {
                string[]? degerler = kayitlar[i].Split(';');
                foreach (string deger in degerler)
                    lblMetin.Text += deger + "\t";
                lblMetin.Text += "\r\n";
            }
        }
    }
}
