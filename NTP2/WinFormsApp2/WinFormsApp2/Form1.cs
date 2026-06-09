namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<Ogrenci> ogrenciler;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciler = new();
            string[] satirlar = File.ReadAllLines("D:\\Code\\NDP3\\ndp3.csv");
            for (int i = 1; i < satirlar.Length; i++)
            {
                {
                    string[] parcalar = satirlar[i].Split(';');
                    Ogrenci ogrenci = new()
                    {
                        Numara = parcalar[0],
                        AdSoyad = parcalar[1],
                        Vize = int.Parse(parcalar[2]),
                        Final = int.Parse(parcalar[3])
                    };
                    ogrenciler.Add(ogrenci);
                }
                
            }            
            dataGridView1.DataSource = ogrenciler;
            // dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
