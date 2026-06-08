namespace Ders14.Models
{
    public enum InvoiceStatus {None, Pending, Paid };
    public class Invoice
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public InvoiceStatus Status { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly DueDate { get; set; }
        public string? Service { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string? ClientName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public Invoice()
        {
            IssueDate = DateOnly.FromDateTime(DateTime.Now.Date);
        }

        public void DueDateCalc()
        {
            DueDate = IssueDate.AddDays(15);
        }
    }
}
