using Microsoft.AspNetCore.Mvc;
using Web2.Models;

namespace Web2.Controllers
{
    public class ExpensesController : Controller
    {
        // private readonly ILogger<ExpensesController> _logger;
        private readonly Data.FinanceAppContext _context;

        public ExpensesController(/* ILogger<ExpensesController> logger,*/ Data.FinanceAppContext context)
        {
            //_logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            var expenses = _context.Expenses.ToList();
            return View(expenses);
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Expenses.Add(expense);
            //    _context.SaveChanges();

            //    return RedirectToAction("Index");
            //}
            return View(expense);
        }
    }
}
