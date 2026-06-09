using Microsoft.EntityFrameworkCore;
using Web2.Models;

namespace Web2.Data
{
    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base (options)
        {
            
        }

        public DbSet<Expense> Expenses { get; set; } = null!;
    }
}
