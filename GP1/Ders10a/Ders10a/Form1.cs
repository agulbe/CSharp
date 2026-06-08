using System.Linq.Expressions;

namespace Ders10a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            // İstisna Yönetimi: Exception Handling
            double a=default;
            double b=default;

            // Hata verme olasılığı yüksek
            try 
            {
                // Dene
                a = Convert.ToDouble(txtSayi1.Text);
                b = Convert.ToDouble(txtSayi2.Text);
            }
            catch (FormatException FormatHatasi) 
            {
                // FormatException istisnası oluşursa
                MessageBox.Show("OxA001: Lütfen Demir Yazılımı arayınız.",
                    "BİLGİ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch(Exception hata)
            {
                // FormatException dışında bir istisna oluşursa
                MessageBox.Show("Bir hata oluştu.\r\n" +
                    hata.Message,
                    "Hata!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            finally
            {
                // Hata olsun veya olmasın
                double c = 0.0;
            
                switch(cboIslem.SelectedIndex)
                {
                    case 0: c = a + b; break;
                    case 1: c = a - b; break;
                    case 2: c = a * b; break;
                    case 3: c = a / b; break;
                    default: MessageBox.Show("Lütfen bir işlem seçiniz."); break;
                }
                if (double.IsNaN(c))
                    lblSonuc.Text = "Tanımsız.";
                else if (double.IsInfinity(c))
                    lblSonuc.Text = "Sonsuz.";
                else 
                    lblSonuc.Text = c.ToString();
            }
            
            
        }
    }
}
