using Ders14.Models;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace Ders14
{
    public partial class Form1 : Form
    {
        SqlConnection bag;
        List<Invoice> faturalar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            faturalar = new();
            bag = new("Data Source=(local);" +
                "Integrated Security=Yes;" +
                "Initial Catalog=invoicedb;" +
                "Trust Server Certificate=Yes");
            try
            {
                bag.Open();
                string? sql = "SELECT * FROM Invoices";
                SqlCommand komut = new(sql, bag);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Invoice fatura = new()
                    {
                        Id = Convert.ToInt32(dr[0]),
                        Number = dr[1].ToString(),
                        Status = (dr[2].ToString() == "Paid") ?
                        InvoiceStatus.Paid : InvoiceStatus.Pending,
                        IssueDate = DateOnly.FromDateTime((DateTime)(dr[3])),
                        DueDate = DateOnly.FromDateTime((DateTime)(dr[4])),
                        Service = dr[5].ToString(),
                        UnitPrice = Convert.ToDecimal(dr[6]),
                        Quantity = Convert.ToInt32(dr[7]),
                        ClientName = dr[8].ToString(),
                        Email = dr[9].ToString(),
                        Phone = dr[10].ToString(),
                        Address = dr[11].ToString()
                    };
                    faturalar.Add(fatura);

                }

                dr.Close();
                komut.Dispose();
                //BindingSource kaynak = new();
                //kaynak.DataSource = faturalar;
                //dgvInvoice.DataSource = kaynak;
                dgvInvoice.DataSource = faturalar;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;

            Invoice fatura = faturalar[index];
            txtNumber.Text = fatura.Number;
            cboStatus.SelectedIndex = -1+ (int)fatura.Status;
            dtpIsuue.Value = new DateTime(fatura.IssueDate, new TimeOnly(0, 0));
            dtpDue.Value = new DateTime(fatura.DueDate, new TimeOnly(0, 0));
            txtService.Text = fatura.Service;
            nudPrice.Value = fatura.UnitPrice;
            nudQuantity.Value = fatura.Quantity;
            txtClient.Text = fatura.ClientName;
            txtEmail.Text= fatura.Email;
            txtPhone.Text= fatura.Phone;
            txtAddress.Text = fatura.Address;
        }
    }
}
