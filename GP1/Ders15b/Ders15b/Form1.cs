using System.ComponentModel;

namespace Ders15b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lstTaksit.Items.Clear();
            int taksitSayisi = (int)nudTaksit.Value;
            int ayinGunu = (int) nudGun.Value;
            //int ay = (DateTime.Now.Day < ayinGunu) ? DateTime.Now.Month : DateTime.Now.Month + 1;

            //for (int i=0; i<taksitSayisi; i++)
            //{
            //    DateTime taksit = new( DateTime.Now.Year + (ay + i-1)/12,
            //        1+(ay+i-1)%12,
            //        ayinGunu);
            //    lstTaksit.Items.Add($"{(i+1)}. Taksit: {taksit}");
            //}

            for (int i = 1; i <= taksitSayisi; i++)
                lstTaksit.Items.Add(DateTime.Now.AddDays(30*i));
        }
    }
}
