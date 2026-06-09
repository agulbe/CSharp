namespace Ders09_2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // public delegate void EventHandler(object? sender, EventArgs e);
        private void Selamla(object? nesne, EventArgs prm)
        {
            Button buton = nesne as Button;
            MessageBox.Show("Üzerinde " + buton.Text + " yazan düğme tarafından çağrıldım");
        }

        private void Baslik(object? nesne, EventArgs prm)
        {
            Text = "Selam!";
        }

    }
}
