using InvoiceApp.Models;
using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public InvoiceDto InvoiceDto { get; set; } = new();
        public Invoice? Invoice { get; set; } = new();
        private readonly ApplicationDbContext _context ;
        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet(int id)
        {
            Invoice = _context.Invoices.Find(id);
            if (Invoice != null)
            {
                InvoiceDto = new InvoiceDto
                {
                    Number = Invoice.Number,
                    Status = Invoice.Status,
                    IssueDate = Invoice.IssueDate,
                    DueDate = Invoice.DueDate,
                    Service = Invoice.Service,
                    UnitPrice = Invoice.UnitPrice, 
                    Quantity = Invoice.Quantity,
                    ClientName = Invoice.ClientName,
                    Email = Invoice.Email,
                    Phone = Invoice.Phone,
                    Address = Invoice.Address
                };
                _context.Invoices.Update(Invoice);
                return Page();
            }
            else return RedirectToPage("/Invoices/Index");
        }

        public string? successMessage = "";
        public IActionResult OnPost(int id)
        {
            var invoice = _context.Invoices.Find(id);
            if (invoice == null) return RedirectToPage("/Invoices/Index");
            Invoice = invoice;
            if (!ModelState.IsValid) return Page();

            Invoice.Number = InvoiceDto.Number;
            Invoice.Status = InvoiceDto.Status;
            Invoice.IssueDate = InvoiceDto.IssueDate;
            Invoice.DueDate = InvoiceDto.DueDate;
            Invoice.Service = InvoiceDto.Service;
            Invoice.UnitPrice = InvoiceDto.UnitPrice;
            Invoice.Quantity = InvoiceDto.Quantity;
            Invoice.ClientName = InvoiceDto.ClientName;
            Invoice.Email = InvoiceDto.Email;
            Invoice.Phone = InvoiceDto.Phone;
            Invoice.Address = InvoiceDto.Address;

            _context.SaveChanges();
            successMessage = "Invoice updated successfully.";
            return Page();
        }
    }
}
