namespace Ders07a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkForm_CheckedChanged(object sender, EventArgs e)
        {
            chkOnay.Enabled = chkForm.Checked;
        }

        private void chkDosya_CheckedChanged(object sender, EventArgs e)
        {
            chkDoldur.Enabled = chkForm.Checked;
        }

        private void chkDoldur_CheckedChanged(object sender, EventArgs e)
        {
            chkTeslim.Enabled = chkDoldur.Checked;
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            if (chkForm.Checked &&
                chkOnay.Checked &&
                chkDosya.Checked &&
                chkDoldur.Checked &&
                chkTeslim.Checked)
                MessageBox.Show("Deftreriniz artık incelenebilir.");
            else
                MessageBox.Show(@"
Staj ile ilgili tamamlanmayan işlemlerini bulunmaktadır.
Öncelikle bütün işlemleri tamamlamalısınız.");
        }
    }
}
