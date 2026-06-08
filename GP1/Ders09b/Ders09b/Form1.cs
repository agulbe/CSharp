namespace Ders09b
{
    public partial class Form1 : Form
    {
        string[] ani = { "―", "\\", "|", "/" };
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
            tmrAni.Start();
        }

        private void lblMetin_Click(object sender, EventArgs e)
        {
            tmrAni.Stop();
            Close();
        }

        private void tmrAni_Tick(object sender, EventArgs e)
        {
            lblMetin.Text = ani[i];
            i++;
            i%= ani.Length;
        }
    }
}
