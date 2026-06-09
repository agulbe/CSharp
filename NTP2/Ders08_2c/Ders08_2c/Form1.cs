namespace Ders08_2c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyRadioButton radyoA1 = new();
            MyRadioButton radyoA2 = new();

            radyoA1.Text = "Kadın"; radyoA1.GroupName = "Cinsiyet";
            radyoA1.Top = 20;
            radyoA2.Text = "Erkek"; radyoA2.GroupName = "Cinsiyet";
            radyoA2.Top = 40;

            MyRadioButton radyoB1 = new();
            MyRadioButton radyoB2 = new();
            MyRadioButton radyoB3 = new();

            radyoB1.Text = "Sigortalı"; radyoB1.GroupName = "Sigorta";
            radyoB1.Top = 70;

            radyoB2.Text = "Sigortasız"; radyoB2.GroupName = "Sigorta";
            radyoB2.Top = 90;
            radyoB3.Text = "Ailesinin sigortasını kullanıyor"; radyoB3.GroupName = "Sigorta";
            radyoB3.Top = 110;

            MyRadioButton radyoC1 = new();
            MyRadioButton radyoC2 = new();

            radyoC1.Text = "Evli"; radyoC1.GroupName = "Medeni";
            radyoC1.Top = 140;
            radyoC2.Text = "Bekar"; radyoC2.GroupName = "Medeni";
            radyoC2.Top = 160;

            Controls.Add(radyoA1);
            Controls.Add(radyoA2);
            Controls.Add(radyoB1);
            Controls.Add(radyoB2);
            Controls.Add(radyoB3);
            Controls.Add(radyoC1);
            Controls.Add(radyoC2);

            MyString Metin = new("TBMYO ");
            Text = Metin.A(5);
        }
    }
}
