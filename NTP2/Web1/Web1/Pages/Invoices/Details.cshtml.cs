using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web1.Models;
using Web1.Services;

namespace Web1.Pages.Invoices
{
    public class DetailsModel : PageModel
    {
        public ApplicationDbContext context;
        [BindProperty]
        public InvoiceDto InvoiceDto { get; set; } = null;
        public int Id;
        public DetailsModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet(int id)
        {
            Invoice invoice = context.Invoices.Find(id);

            if (invoice != null)
            {
                Id = invoice.Id;
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
    }
}
