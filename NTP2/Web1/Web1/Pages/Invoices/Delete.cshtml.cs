using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web1.Models;
using Web1.Services;

namespace Web1.Pages.Invoices
{
    public class DeleteModel : PageModel
    {
        public ApplicationDbContext context;
        public DeleteModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet(int id)
        {
            Invoice invoice = context.Invoices.Find(id);
            if (invoice != null)
            {
                context.Invoices.Remove(invoice);
                context.SaveChanges();
            }
                
            return RedirectToPage("/Invoices/Index");
        }
    }
}
