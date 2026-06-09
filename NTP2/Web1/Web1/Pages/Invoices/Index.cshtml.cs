// Code behind

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web1.Models;
using Web1.Services;

namespace Web1.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        public ApplicationDbContext context { get; set; }
        public List<Invoice> invoiceList = new();

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            invoiceList = context.Invoices.
                OrderByDescending(i => i.IssueDate).ToList();
        }
    }
}
