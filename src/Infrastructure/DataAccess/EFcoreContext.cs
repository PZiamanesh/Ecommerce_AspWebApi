using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess
{
    public class EFcoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public EFcoreContext(DbContextOptions<EFcoreContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
