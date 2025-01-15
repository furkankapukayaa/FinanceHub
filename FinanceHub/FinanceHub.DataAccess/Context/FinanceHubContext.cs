using FinanceHub.Entity.DomainObjects;
using Microsoft.EntityFrameworkCore;

namespace FinanceHub.DataAccess.Context
{
    public class FinanceHubContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=dbFinanceHub;Trusted_Connection=true;Integrated Security=True;TrustServerCertificate=True");
            }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Spending> Spendings { get; set; }
    }
}