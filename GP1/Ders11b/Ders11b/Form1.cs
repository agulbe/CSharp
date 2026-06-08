namespace Ders11b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            button1.Visible = false;
            Width = label1.Width + 24;
            Top = 2;
            Opacity = 0.75;
        }
    }
}
