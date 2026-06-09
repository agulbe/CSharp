using Microsoft.Data.SqlClient;
namespace Ders10_1a
{
    public partial class Form1 : Form
    {
        SqlConnection bag;
        List<Customer> customers;
        List<OrderDto> orders;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                orders = new();
                bag = new("Data Source=(local);Integrated Security=Yes;Initial Catalog=NorthWind;Trust Server Certificate=Yes");
                bag.Open();

                string? sql = "SELECT OrderID, CompanyName, CONCAT( E.FirstName ,' ', E.LastName) as EmployeeName, RequiredDate, ShipAddress, ShipCity FROM Orders O JOIN Customers C ON C.CustomerID = O.CustomerID JOIN Employees E ON O.EmployeeID = E.EmployeeID";
                SqlCommand komut = new(sql, bag);

                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    OrderDto? order = new()
                    {
                        OrderID = (int)dr["OrderID"],
                        CompanyName = dr["CompanyName"].ToString(),
                        EmployeeName = dr["EmployeeName"].ToString(),
                        RequiredDate = Convert.ToDateTime( dr["RequiredDate"]),
                        ShipAddress = dr["ShipAddress"].ToString(),
                        ShipCity = dr["ShipCity"].ToString()
                    };
                    orders.Add(order);
                }
                dgvSorgu.DataSource = orders;
                dr.Close();
                komut.Dispose();
                bag.Close();
                bag.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = 0;
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            // DateTime bas = new DateTime(1996, 10, 1);
            // DateTime son = new DateTime(1996, 10, 31);
            var sonuc = from order in orders
                        where // order.RequiredDate >= bas &&
                              // order.RequiredDate <= son &&
                              order.ShipCity == cboCity.Text
                        select order;

            var sonuc1 = orders.Where(o => o.ShipCity == cboCity.Text);
                

            dgvSorgu.DataSource = sonuc.ToList();
        }
    }
}
