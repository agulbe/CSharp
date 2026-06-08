namespace Ders11a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.AllowDrop = true;
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] dosyalar = (string[])e.Data.GetData(DataFormats.FileDrop);
                listBox1.Items.Clear();
                foreach (string dosya in dosyalar)
                    listBox1.Items.Add(dosya);
            }
            else
            {
                MessageBox.Show("Burası çöplük değil. Bunları başka yere atın.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dosya = listBox1.SelectedItem as string;
            textBox1.Text = File.ReadAllText(dosya);
        }
    }
}
