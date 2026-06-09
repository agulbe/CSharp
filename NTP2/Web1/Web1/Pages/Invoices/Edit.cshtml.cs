using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web1.Models;
using Web1.Services;

namespace Web1.Pages.Invoices
{
    public class EditModel : PageModel
    {
        public ApplicationDbContext context { get; set; }
        public Invoice invoice { get; set; } = null;
        public string? SuccessMessage = "";
        [BindProperty]
        public InvoiceDto InvoiceDto { get; set; }
        public EditModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet(int Id)
        {
            invoice = context.Invoices.Find(Id);
            if (invoice != null)
            {
                InvoiceDto = new()
                {
                    Number = invoice.Number,
                    IssueDate = invoice.IssueDate,
                    DueDate = invoice.DueDate,
                    Status = invoice.Status,
                    ClientName = invoice.ClientName,
                    Email = invoice.Email,
                    Phone = invoice.Phone,
                    Address = invoice.Address,
                    Service = invoice.Service,
                    Quantity = invoice.Quantity,
                    UnitPrice = invoice.UnitPrice
                };
                return Page();
            }
            else
                return RedirectToPage("/Invoices/Index");
        }

        public IActionResult OnPost(int id)
        {
            if (InvoiceDto == null) {
                SuccessMessage = "InvoiceDto boş!";
                return Page();
            }
            invoice = context.Invoices.Find(id);
            if (invoice == null) {
                SuccessMessage = "Invoice boş!";
                return Page();
                }
            invoice.Number = InvoiceDto.Number;
            invoice.Status=InvoiceDto.Status;
            invoice.IssueDate = InvoiceDto.IssueDate;
            invoice.DueDate= InvoiceDto.DueDate;
            invoice.ClientName = InvoiceDto.ClientName;
            invoice.Email = InvoiceDto.Email;
            invoice.Phone = InvoiceDto.Phone;
            invoice.Address = InvoiceDto.Address;
            invoice.Service = InvoiceDto.Service;
            invoice.Quantity = InvoiceDto.Quantity;
            invoice.UnitPrice = InvoiceDto.UnitPrice;

            context.Invoices.Update(invoice);
            context.SaveChanges();
            return RedirectToPage("/Invoices/Index");
        }
    }
}
