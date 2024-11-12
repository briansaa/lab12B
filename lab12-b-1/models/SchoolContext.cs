using Microsoft.EntityFrameworkCore;
using lab12_b_1.models;

namespace lab12_b_1.models
{
    public class SchoolContext :DbContext
    {
        public DbSet<Detail> Details { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-7EGTO68Q\\SQLEXPRESS; Database=ApiDemo; Integrated Security=True;Trust Server Certificate=True ");
        }
        public DbSet<lab12_b_1.models.Invoice> Invoice { get; set; } = default!;
        public DbSet<lab12_b_1.models.Product> Product { get; set; } = default!;
        public DbSet<lab12_b_1.models.Customer> Customer { get; set; } = default!;
    }
}
