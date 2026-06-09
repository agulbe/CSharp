namespace Ders07b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
            timer1.Interval = 1000/2;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }
    }
}
