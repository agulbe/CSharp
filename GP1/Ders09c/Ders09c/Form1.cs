namespace Ders09c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "İnsan neyi hak ediyorsa hayat ona onu verir.";
            label1.Left = 288; // Width - 12
            label1.Top = 184;  // Height - 32 - 6 - 10 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left -= 4;
            if (label1.Left < -label1.Width)
                label1.Left = 288;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
