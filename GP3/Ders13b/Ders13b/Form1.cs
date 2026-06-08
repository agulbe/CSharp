namespace Ders13b
{
    public partial class Form1 : Form
    {
        Label etiket;
        int tiklamaSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dugme_Click(object? sender=null, EventArgs? e=null)
        {
            tiklamaSayisi++;
            etiket.Text = "TIKLAMA SAYISI: "+tiklamaSayisi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button dugme = new()
            {
                Width = 100,
                Height = 40,
                Left = 50,
                Top = 50,
                Text = "TIKLA BANA",
                Name = "btnTikla",
                BackColor = Color.Aquamarine,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                // Visual styles'ın BackColor'ı ezmesini engelle
                UseVisualStyleBackColor = false, 
                Enabled = true
            };
            dugme.FlatAppearance.BorderSize = 0;
            dugme.FlatAppearance.MouseOverBackColor = Color.Yellow;
            dugme.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            dugme.Click += dugme_Click;

            Controls.Add(dugme);

            etiket = new()
            {
                AutoSize = false,
                Width = 100,
                Height = 100,
                Left = dugme.Left,
                Top = dugme.Top + dugme.Height + 10,
                Text = "TIKLAMA SAYISI",
                Name = "lblTikla"
            };
            Controls.Add(etiket);
        }
    }
}
