namespace Ders13a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("D:\\Resim\\Portre\\noao0107a.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "Joint Picture element Group|*.jpg|" +
                "Poprtable Networks Graphics|*.png|" +
                "Graphics Interchage Format|*.gif|" +
                "Bit eşlem|*.bmp";
            openFileDialog1.Title = "Resim Dosyası Aç";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDosya.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
