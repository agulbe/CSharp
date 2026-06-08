using Ders12b.Model;
using Microsoft.Data.SqlClient;

namespace Ders12b
{
    public partial class Form1 : Form
    {
        SqlConnection bag;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ogrenciSayisi = 0;
            List<Ogrenci> liste = new();
            try
            {
               using (bag = new("Data Source=(local); Integrated Security=Yes;Initial Catalog=Okul;Trust Server Certificate=Yes"))
                {
                    bag.Open();
                    string sql = "SELECT * FROM Ogrenci";
                    using (SqlCommand komut = new(sql, bag))
                    {
                        using (SqlDataReader dr = komut.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                liste.Add(new Ogrenci
                                {
                                    Numara = dr["Numara"].ToString(),
                                    Ad = dr["Ad"].ToString(),
                                    Soyad = dr["Soyad"].ToString()
                                }
                                );
                                ogrenciSayisi++;
                            }
                        }
                    }
                }
            }
            catch { }
            
            
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                // Numara gösterecek Label
                Label lblNumara = new()
                {
                    AutoSize = false,
                    Size = new Size(100, 30),
                    Location = new Point(16, 40 + i * 40),
                    BorderStyle = BorderStyle.Fixed3D,
                    TextAlign = ContentAlignment.MiddleRight,
                    Text = liste[i].Numara
                };
                Controls.Add(lblNumara);

                // Ad ve Soyad TextBox
                TextBox txtAd = new()
                {
                    Width = 120,
                    Location = new Point(120, 40 + 40 * i),
                    ReadOnly = true,
                    Text = liste[i].AdSoyad
                };
                Controls.Add(txtAd);

                // Not girişi için NumericUpDown
                NumericUpDown nudVize = new()
                {
                    Minimum = -1,
                    Maximum = 100,
                    Increment = 1,
                    DecimalPlaces = 0,
                    Width = 50,
                    Location = new Point(250, 40 + 40 * i)
                };
                Controls.Add(nudVize);
            }
        }
    }
}
