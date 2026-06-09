using Microsoft.Data.SqlClient;

namespace Ders09_2d
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new("Data Source=ALPPC;Integrated Security=Yes;Initial Catalog=Okul;Trust Server Certificate=Yes");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AutoCompleteStringCollection liste = new();
            //foreach (var ders in lstDers.Items)
            //    liste.Add(ders.ToString() ?? "");
            //txtDers.AutoCompleteCustomSource = liste;
        }

        private async void txtDers_TextChanged(object sender, EventArgs e)
        {
            if (txtDers.Text.Length < 3) return;
            try
            {
                baglanti.Open();
                string sql = $"SELECT Ad FROM Ders WHERE Ad LIKE '%{txtDers.Text}%'";
                SqlCommand komut = new(sql, baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                lstDers.Items.Clear();
                while(dr.Read())
                    lstDers.Items.Add(dr["Ad"].ToString());
                dr.Close();
                await dr.DisposeAsync();
                komut.Dispose();
                baglanti.Close();

            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
