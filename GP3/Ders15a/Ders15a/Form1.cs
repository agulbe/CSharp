namespace Ders15a
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
            tmrSaat.Start();
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            string? sayi = DateTime.Now.ToString("HHmm");
            int irakam = 0, indis = 0;
            string? yol = "";

            for (int i = Controls.Count - 1; i >= 1; i--)
                Controls.RemoveAt(i);

            PictureBox pictureBox = null;
            foreach (char crakam in sayi)
            {
                irakam = crakam - '0';
                yol = rakamResim[irakam];

                pictureBox = new PictureBox();
                pictureBox.Left = (indis <2)? indis * 128: indis * 128+32;
                pictureBox.Top = 0;
                pictureBox.Width = 128; pictureBox.Height = 128;
                pictureBox.Image = Image.FromFile(yol);
                Controls.Add(pictureBox);
                indis++;

            }
        }
    }
}
