namespace Ders07c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1440;
            Height = 900;
            Top = 0; Left = 0;
            WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left > 1300)
                pictureBox1.Left = -200;
        }
    }
}
