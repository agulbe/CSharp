namespace Ders12a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yuzluk = 0.0;
            double dortluk = (double) nudGano.Value;

            yuzluk = dortluk * 23.3333333333333 + 6.66666666666666;

            MessageBox.Show("Ganonuz: " + dortluk + 
                "\r\nYüzlük sistemde karşılığı: " + (int)yuzluk);
            
        }
    }
}
