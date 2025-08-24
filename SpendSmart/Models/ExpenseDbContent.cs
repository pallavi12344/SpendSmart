using Microsoft.EntityFrameworkCore;
namespace SpendSmart.Models
{
    public class ExpenseDbContent : DbContext
    {
      public DbSet<Expense> Expenses { get; set; }

        public ExpenseDbContent(DbContextOptions<ExpenseDbContent> options) : base(options)
        {

        }
    }
}
