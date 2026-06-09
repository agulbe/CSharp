namespace Ders10_1a
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public string? CompanyName { get; set; }
        public string? EmployeeName { get; set; } // CONCAT(FirstName + ' ' + LastName)
        public DateTime? RequiredDate { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
    }
}
