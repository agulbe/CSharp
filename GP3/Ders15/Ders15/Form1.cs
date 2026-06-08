namespace Ders15
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> rakamResim;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rakamResim = new Dictionary<int, string>()
            {
                {0, "D:\\Resim\\Rakam\\zero.png" },
                {1, "D:\\Resim\\Rakam\\one.png" },
                {2, "D:\\Resim\\Rakam\\two.png" },
                {3, "D:\\Resim\\Rakam\\three.png" },
                {4, "D:\\Resim\\Rakam\\four.png" },
                {5, "D:\\Resim\\Rakam\\five.png" },
                {6, "D:\\Resim\\Rakam\\six.png" },
                {7, "D:\\Resim\\Rakam\\seven.png" },
                {8, "D:\\Resim\\Rakam\\eight.png" },
                {9, "D:\\Resim\\Rakam\\nine.png" }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? sayi = numericUpDown1.Value.ToString();
            int irakam=0, indis=0;
            string? yol = "";

            for(int i = Controls.Count-1;  i >= 3; i--)
                Controls.RemoveAt(i);

            PictureBox pictureBox=null;
            foreach(char crakam in sayi)
            {
                irakam = crakam - '0';
                yol = rakamResim[irakam];

                pictureBox = new PictureBox();
                pictureBox.Left = 16 + indis * 138;
                pictureBox.Top = 40;
                pictureBox.Width = 128; pictureBox.Height = 128;
                pictureBox.Image = Image.FromFile(yol);
                Controls.Add(pictureBox);
                indis++;
            }
        }
    }
}
