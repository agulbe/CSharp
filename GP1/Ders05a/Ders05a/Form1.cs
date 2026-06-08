namespace Ders05a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstAdlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAdlar.SelectedIndex >= 0)
                label3.Text = "Seçili öğe: " +
                    lstAdlar.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // lstAdlar.SelectionMode = SelectionMode.MultiExtended;
        }
    }
}
