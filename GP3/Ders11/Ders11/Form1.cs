namespace Ders11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.Filter = "Salt metin dosyası|*.txt|" +
                "Web dosyaları|*.htm;*.html;*.css|" +
                "Tün dosyalar|*.*";
            ofd.Title = "Metin dosyası aç";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDosya.Text = ofd.FileName;
                txtMetin.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void txtMetin_DragEnter(object sender, DragEventArgs e)
        {
            // Sürüklenen dosyanın
            // Metin, web, kaynak kod dosyası olduğunu kontrol et
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] dosyalar = (string[])e.Data.GetData(DataFormats.FileDrop);
                string?[] parcalar = dosyalar[0].ToLower().Split('.');
                string[] uzantilar = ["txt", "htm", "html", "css", "cs"];
                if (uzantilar.Contains(parcalar[parcalar.Length - 1]))
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtMetin_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] dosyalar = (string[])e.Data.GetData(DataFormats.FileDrop);
                    txtMetin.Text = File.ReadAllText(dosyalar[0]);
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
