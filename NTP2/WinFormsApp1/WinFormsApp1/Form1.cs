namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Merhaba, Dünya!", "Hata", MessageBoxButtons.OK,
            //     MessageBoxIcon.Hand);
            Text = "Hesap Makinesi";
            Random rastgeleSayi = new Random();
            txtFiyat.Text = rastgeleSayi.Next(0, 100).ToString();
            tmrAnimasyon.Interval = 200;

            string[] adlar = ["Ali", "Ela", "Cem", "Nur", "Efe"];

            // Vize C 1
            lstArkadaslar.Items.Clear(); // opsiyonel
            foreach (var i in adlar)
                lstArkadaslar.Items.Add(i);

            for (int i = 0; i < adlar.Length; i++)
                lstArkadaslar.Items.Add(adlar[i]);
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            // float fiyat = float.Parse(txtFiyat.Text);
            float fiyat = Convert.ToSingle(txtFiyat.Text);
        }

        private void cboEgitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string egitimDurumu = cboEgitim.Text;
            // string egitimDurumu = cboEgitim.SelectedItem.ToString();
            string egitimDurumu =
                cboEgitim.Items[cboEgitim.SelectedIndex].ToString();
        }

        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            float fahrenheit = Convert.ToSingle(
                txtFahrenheit.Text);
            double celcius = (fahrenheit - 32) / 1.8;
        }

        private void chkLojman_CheckedChanged(object sender, EventArgs e)
        {
            int lojmanKesintisi;

            if (chkLojman.Checked)
                lojmanKesintisi = 5000;
            else
                lojmanKesintisi = 0;


            lojmanKesintisi = (chkLojman.Checked) ? 5000 : 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = lstServis.SelectedItems.Count;
            string[] dizi = new string[n];
            // lstServis.SelectedItems.CopyTo(dizi, 0);

            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = lstServis.SelectedItems[i].ToString();
        }
    }
}
