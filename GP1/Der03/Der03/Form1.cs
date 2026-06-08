namespace Der03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba. Ben Kaydet düðmesiyim.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýyi günler. Ýptal iþlemi baþladý.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = DateTime.Now.ToString();
        }
    }
}
