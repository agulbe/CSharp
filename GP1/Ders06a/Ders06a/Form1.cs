namespace Ders06a
{
    public partial class Form1 : Form
    {
        string cinsiyet, egitim;

        public Form1()
        {
            InitializeComponent();
        }

        private void CinsiyetTiklandi(object sender, EventArgs e)
        {
            var radyo = (RadioButton) sender;
            cinsiyet = radyo.Text;
            lblDurum.Text = "Cinsiyet: " + cinsiyet;
        }

        private void EgitimTiklandi(object sender, EventArgs e)
        {
            var radyo = (RadioButton) sender;
            egitim = radyo.Text;
            lblDurum.Text = "Eğitim durumu: " + egitim;
        }
    }
}
