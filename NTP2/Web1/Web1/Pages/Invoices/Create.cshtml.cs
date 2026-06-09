using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web1.Models;
using Web1.Services;

namespace Web1.Pages.Invoices
{
    public class CreateModel : PageModel
    {
        public  ApplicationDbContext context { get; set; }
        public string? SuccessMessage = "";
        [BindProperty]
        public InvoiceDto InvoiceDto { get; set; }
        public CreateModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(InvoiceDto invoiceDto)
        {
            if (ModelState.IsValid)
            {
                Invoice invoice = new()
                {
                    Number = invoiceDto.Number,
                    Status = invoiceDto.Status,
                    IssueDate = invoiceDto.IssueDate,
                    DueDate = invoiceDto.DueDate,
                    ClientName = invoiceDto.ClientName,
                    Email = invoiceDto.Email,
                    Phone = invoiceDto.Phone,
                    Address = invoiceDto.Address,
                    Service = invoiceDto.Service,
                    UnitPrice = invoiceDto.UnitPrice,
                    Quantity = invoiceDto.Quantity,
                };
                context.Invoices.Add(invoice);
                context.SaveChanges();
                SuccessMessage = "Fatura başarıyla kaydedildi.";
                return RedirectToPage("/Invoices/Index");
            }
                
            else
                return Page();
        }

    }
}
