namespace Der04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label etiket;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba " +
                textBox1.Lines[^1]
                );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 2)
                MessageBox.Show(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
