namespace Ders05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cboEgitim.Items.Clear();
            //cboEgitim.Items.Add("Primary school");
            //cboEgitim.Items.Add("Secondary school");
            //cboEgitim.Items.Add("High school");
            //cboEgitim.Items.Add("Philosophy of Doctorate");

            //cboEgitim.Items.Insert(3, "Vocational school");
            //cboEgitim.Items.Insert(4, "Bachelor");
            //cboEgitim.Items.Insert(5, "Master");

            cboEgitim.SelectedIndex = 3;

        }

        private void cboEgitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEgitim.SelectedIndex >= 0)
                label2.Text = "Seçilen eğitim düzeyi: " + cboEgitim.SelectedItem;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!cboEgitim.Items.Contains(cboEgitim.Text))
                cboEgitim.Items.Add(cboEgitim.Text);
        }
    }
}
