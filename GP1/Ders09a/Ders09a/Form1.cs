namespace Ders09a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dugme =  MessageBox.Show(
                "Programdan çıkmak istediğinize emin misiniz?",
                "Çıkış",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (dugme == DialogResult.Yes)
                Close();
            else if (dugme == DialogResult.No)
                lblDugme.Text = "Hayır düğmesine tıkladın. Devam ediyoruz.";
            else lblDugme.Text ="İptal düğmesine tıkladın. Korkacak bir şey yok!";
        }
    }
}
