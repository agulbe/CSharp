namespace Ders09_2e
{
    public partial class Form1 : Form
    {
        Dosya dosya;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaltOkunur(object sender, BildirEventArgs e)
        {
            Dosya yeniDosya = sender as Dosya;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Multiselect = false;
            ofd.Title = "Dosya Aç";
            ofd.Filter = "Tüm dosyalar|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYolu.Text = ofd.FileName;
                FileInfo dosyaBilgisi = new("ofd.FileName");
                dosya.Name = dosyaBilgisi.Name;
                dosya.FullName = dosyaBilgisi.FullName;
                dosya.Extension = dosyaBilgisi.Extension;
                // dosya.Length = dosyaBilgisi.Length;
                dosya.LastAccessTime = dosyaBilgisi.LastAccessTime;
                dosya.LastWriteTime = dosyaBilgisi.LastWriteTime;
                dosya.CreationTime = dosyaBilgisi.CreationTime;
                dosya.DirectoryName = dosyaBilgisi.DirectoryName;
                dosya.IsReadOnly = dosyaBilgisi.IsReadOnly;
                chkSaltOkunur.Checked = dosya.IsReadOnly;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dosya = new();
        }
    }
}
