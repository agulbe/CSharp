namespace Ders15a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            if (txtMetin.Text.Length < 1) return;
            // .TrimEnd(): Metnin sonundaki boşluğu temizler
            // .TrimStart(): Metnin başındaki boşlukları temizler
            // .Trim(): Baştaki ve sondaki boşlukları temizler

            // .Remove(i): i. karakterden başlayarak sonuna kadar sil
            // .Remove(i, c): i. karakterden başlayarak c kadar karakter sil

            // .Replace(eski, yeni): eski metin parçasını yueni metin parçasıyla değiştirir.

            // .Substring(i, c): i. kadarkterden itibaren c kadar karakter döndür.

            // .ToUpper(): BÜYÜK HARFLERE DÖNÜŞTÜR
            // .ToLower(): küçük harflere dönüştür

            //.Contains(aranan): metin içerisinde aranan var mı yok mu onu bildirir.
            
            lblMetin.Text = "";
            lblMetin.Text += "Metnin uzunluğu: " + txtMetin.Text.Length + "\r\n";
            lblMetin.Text += "Metin: "+txtMetin.Text.Trim() +
                " (" + txtMetin.Text.Trim().Length + ")" + "\r\n";

            //lblMetin.Text += txtMetin.Text.Remove(5) + "\r\n";
            //lblMetin.Text += txtMetin.Text.Remove(5, 3)+"\r\n";

            // lblMetin.Text += txtMetin.Text.Replace(" ve ", " ile ") + "\r\n";

            // lblMetin.Text += txtMetin.Text.Substring(13, 11) + "\r\n";

            //lblMetin.Text += txtMetin.Text.ToUpper() + "\r\n";
            //lblMetin.Text += txtMetin.Text.ToLower() + "\r\n";

            if(txtMetin.Text.Contains("@"))
                lblMetin.Text+= "bu metin bir mail adresi olabilir."+"\r\n";
                else lblMetin.Text += "bu metin bir mail adresi olamaz." +"\r\n";

        }
    }
}
